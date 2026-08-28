namespace ConsoleApp1;

class ShoppingList : IShoppingList
{
    public string _menuName { get; set; }
    public MenuCategory _menuCategory;
    public int _menuPrice { get; set; }
    public string _discount { get; set; }

    public ShoppingList(string name, MenuCategory category, int price, string discount)
    {
        _menuName = name;
        _menuCategory = category;
        _menuPrice = price;
        _discount =  discount;
    }

    public string GetMenu()
    {
        switch (_menuCategory)
        {
            case MenuCategory.drink:
                return "음료";
            case MenuCategory.dessert:
                return "디저트";
            default:
                return "잘못된 선택";
        }
    }
    
    public static void PrintDurability(ShoppingCart<IShoppingList> inCart)
    {
        for (int i = 0; i < inCart.Count; i++)
        {
            IShoppingList item = inCart.Get(i);

            Console.WriteLine($"{item._menuName} {item._menuPrice}");
        }
    }

    public void MenuListPrint()
    {
        Console.WriteLine($"{_menuName} ({GetMenu()}) {_menuPrice}원 [{_discount}]");
    }
}

enum MenuCategory :  byte
{
    None,
    drink,
    dessert
}