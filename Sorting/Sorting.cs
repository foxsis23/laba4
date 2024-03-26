using WasteClass;

namespace SortingClass{
    internal class Sorting{
    public List<Waste> wastes;

    public Sorting()
    {
        wastes = new List<Waste>();
    }

    public void addWaste(Waste waste)
    {
        wastes.Add(waste);
    }

    public IEnumerable<Waste> sortWasteByType()
    {
        return wastes.OrderBy(waste => waste.Type);
    }

    public IEnumerable<Waste> sortWasteBySize()
    {
        return wastes.OrderBy(waste => waste.Size);
    }

    public IEnumerable<Waste> filterWasteBySize(int size)
    {
        return wastes.Where(waste => waste.Size > size);
    }

    public void showList(IEnumerable<Waste> wastes){
        foreach (var waste in wastes)
        {
            Console.WriteLine($"Тип сміття: {waste.Type}, Розмір: {waste.Size}");
        }
    }
}
}