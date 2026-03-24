using Week8;
class Program
{
    static void Main(string[] args)
    {
        Letter letter1 = new Letter("1", 0.25);
        Letter letter2 = new Letter("2", 0.55);
        Parcel parcel1 = new Parcel("3", 4.0, "30x20x15");
        Parcel parcel2 = new Parcel("4", 8, "50x40x30");
        
        Console.WriteLine("PrintInfo");
        letter1.PrintInfo();
        Console.WriteLine();
        parcel1.PrintInfo();
        Console.WriteLine();
        
        Console.WriteLine("Завантаження контейнера");
        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        myCargo.AddItem(letter1);
        myCargo.AddItem(letter2);
        myCargo.AddItem(parcel1);
        myCargo.AddItem(parcel2);
        
        Console.WriteLine($"\nЗагальна вартість доставки: {myCargo.GetTotalCost()} грн");
    }
}