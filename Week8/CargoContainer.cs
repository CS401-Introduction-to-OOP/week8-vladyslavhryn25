namespace Week8;

public class CargoContainer <T> where T : DeliveryItem
{
    private List<T> _items = new List<T>();
    public void AddItem(T item)
    {
        _items.Add(item);
        Console.WriteLine($"Додано: {item.TrackingNumber}");
    }
    public double GetTotalCost()
    {
        double total = 0;
        foreach (var item in _items)
            total += item.CalculateCost();
        return total;
    }
}