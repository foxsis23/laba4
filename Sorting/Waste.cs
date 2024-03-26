namespace WasteClass{
    internal class Waste
    {
        private string type;
        private double size; 

        public string Type => type;
        public double Size => size;

        public Waste(string type, double size)
        {
            this.type = type;
            this.size = size;
        }
    }
}

