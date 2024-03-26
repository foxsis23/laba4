namespace TeethClass{
    internal class Teeth{
        public int sharpness { get; set; }
        public int count { get; set; }

        public Teeth(){
            sharpness = 5;
            count = 32;
        }
        
        public Teeth(int sharpness,int count){
            this.sharpness = sharpness;
            this.count = count;
        }

        public override string ToString()
        {
            return $"гострота {sharpness} к-ть {count} зубів";
        }

        public override bool Equals(object? obj)
        {
            if(obj is Teeth teeth1){
                return sharpness == teeth1.sharpness && count == teeth1.count;
            }

            return false;
        }
    }
}