namespace ConsoleApp1;

public class ShoppingCart<T> where T : IShoppingList
{
    private T[] Cart;  
    private int count = 0;

    public ShoppingCart(int capacity)  
    {  
        Cart = new T[capacity];  
    }

    public void Add(T item)  
    {  
        if (count >= Cart.Length)  
        {  
            Console.WriteLine("더 담을 수 없습니다.");  
            return;  
        }

        Cart[count] = item;  
        count = count + 1;  
    }

    public T Get(int index)  
    {  
        return Cart[index];  
    }

    public int Count  
    {  
        get  
        {  
            return count;  
        }  
    }
}