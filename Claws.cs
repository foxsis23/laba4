
namespace ClawsClass{
    internal class Claws{
        public int sharpness { get; set; }
        public int length { get; set; }

        public Claws(){
            sharpness = 3;
            length = 20;
        }

        public Claws(int sharpness,int length){
            this.sharpness = sharpness;
            this.length = length;
        }

        public override string ToString()
        {
            return $"гострота {sharpness} довжина {length} кігтей";
        }

        public override bool Equals(object? obj)
        {
            if(obj is Claws claws1){
                return sharpness == claws1.sharpness && length == claws1.length;
            }

            return false;
        }
    }
}