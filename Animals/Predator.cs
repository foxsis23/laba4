using ClawsClass;
using TeethClass;

namespace PredatorClass{
    internal class Predator{
        public string name { get; set; }
        public string type { get; set; }
        public Claws PredatorClaws { get; set; }
        public Teeth PredatorTeeth{ get; set; }

        public Predator(){
            name = "Wolf";
            type = "ground";
            PredatorClaws = new Claws();
            PredatorTeeth = new Teeth();
        }

        public Predator(string name, string type,Claws claws,Teeth teeth){
            this.name = name;
            this.type = type;
            PredatorTeeth = teeth;
            PredatorClaws = claws;
        }

        public void bark(){
            Console.WriteLine($"{name} гарчить");
        }

        public void run(){
            Console.WriteLine($"{name} біжить");
        }


        public void sleep(){
            Console.WriteLine($"{name} спить");
        }

        public void find_food(){
            Console.WriteLine($"{name} шукає їжу використовуючи кігті з гостротою {PredatorClaws.sharpness} і довжиною {PredatorClaws.length}");
            Console.WriteLine($"{name} шукає їжу використовуючи зуби({PredatorTeeth.count}) з гостротою {PredatorTeeth.sharpness}");
        }

        public override string ToString()
        {
            return $"{name} {type} гострота {PredatorClaws.sharpness} к-ть зубів {PredatorTeeth.count}";
        }

        public override bool Equals(object? obj)
        {
            if(obj is Predator predator1){
                return name == predator1.name && type == predator1.type && PredatorClaws.length == predator1.PredatorClaws.length && PredatorClaws.sharpness == predator1.PredatorClaws.sharpness && PredatorTeeth.sharpness == predator1.PredatorTeeth.sharpness && PredatorTeeth.count == predator1.PredatorTeeth.count;
            }
            return false;
        }
    }
}