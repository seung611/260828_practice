namespace ConsoleApp1;

struct ShoppingList : IShoppingList
{
    public string _menuName { get; set; }
    public MenuCategory _menuCategory;
    public int _menuPrice { get; set; }

    public ShoppingList(string name, MenuCategory category, int price)
    {
        _menuName = name;
        _menuCategory = category;
        _menuPrice = price;
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

    public void MenuListPrint()
    {
        Console.WriteLine($"{_menuName} ({GetMenu()}) {_menuPrice}원");
    }
}

enum MenuCategory :  byte
{
    None,
    drink,
    dessert
}