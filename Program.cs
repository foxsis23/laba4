using PredatorClass;
using ClawsClass;
using TeethClass;
using SortingClass;
using PlasticClass;
using GlassClass;
using PaperClass;
using MetalClass;

Claws claws = new Claws(5, 10);
Teeth teeth = new Teeth(3, 30);
Predator predator = new Predator("Wolf", "Canine", claws, teeth);

Claws claws1 = new Claws(4, 12);
Teeth teeth1 = new Teeth(3, 30);
Predator predator1 = new Predator("Eagle", "Air", claws, teeth);

predator.bark();
predator.run();
predator.sleep();
predator.find_food();


Console.WriteLine(predator.ToString());
Console.WriteLine(claws.ToString());
Console.WriteLine(teeth.ToString());

Console.WriteLine(predator.Equals(predator1));
Console.WriteLine(claws.Equals(claws1));
Console.WriteLine(teeth.Equals(teeth1));

Sorting sortStation = new Sorting();
sortStation.addWaste(new Paper(10));
sortStation.addWaste(new Plastic(40));
sortStation.addWaste(new Metal(590));
sortStation.addWaste(new Glass(5));

Console.WriteLine("Сортування по типу: ");
var sort1 = sortStation.sortWasteByType();
sortStation.showList(sort1);

Console.WriteLine("Сортування по розміру: ");
var sort2 = sortStation.sortWasteBySize();
sortStation.showList(sort2);

Console.WriteLine("Сортування по розміру більше чим 30: ");
var sort3 = sortStation.filterWasteBySize(30);
sortStation.showList(sort3);




