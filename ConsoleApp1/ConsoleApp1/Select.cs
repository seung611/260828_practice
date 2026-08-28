namespace ConsoleApp1;

public class Select : IShoppingList
{
    public string _menuName { get; set; }
    public int _menuPrice { get; set; }

    public void _Select(int selnumber)
    {
        if (selnumber == 1)
        {
            ShoppingCart<IShoppingList> inCart;
        }
        else if (selnumber == 2)
        {
            // inCart.Clear();
        }
        else if (selnumber == 3)
        {
            
        }
        else if (selnumber == 4)
        {
            
        }
        else
        {
            Console.WriteLine("잘못 선택하셨습니다.");
        }
    }
}