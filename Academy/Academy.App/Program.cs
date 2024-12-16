// See https://aka.ms/new-console-template for more information
Console.WriteLine("All menu items");

Order order = new Order();
order.OrderItems = new();
while (true)
{
    MenuItem.GetAll();
    Console.WriteLine("enter mealId");
    int mealId = int.Parse(Console.ReadLine());
    OrderItem orderItem = new OrderItem();
    orderItem.MenuItemId = mealId;
    order.OrderItems.Add(orderItem);
    Console.WriteLine("meal added to order");
}

//_orderservice.create(order)












class Order
{
    public List<OrderItem> OrderItems { get; set; }
}
class OrderItem
{
    public int MenuItemId { get; set; }
    public MenuItem MenuItem { get; set; }
    public static List<OrderItem> GetAll()
    {
        return new List<OrderItem>()
        {
            new(){MenuItemId=1},
            new(){MenuItemId=2},
            new(){MenuItemId=3},
        };
    }
}
class MenuItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public override string ToString()
    {
        return Id + " " + Name;
    }
    public static void GetAll()
    {
       var list=new List<MenuItem>()
        {
            new(){Id=1,Name="Meal1"},
            new(){Id=2,Name="Meal2"},
            new(){Id=3,Name="Meal3"},
        };
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}