namespace ConsoleApp1;

public class Pay
{
    private string _SelctName;
    private int _HowMuch;
    private int _HowMany;
    public int total_pay;
    public Pay(string selectname, int price, int manynumber)
    {
        _SelctName = selectname;
        _HowMuch = price;
        _HowMany = manynumber;
        total_pay = price * manynumber;
    }
    
    public void PayPrint()
    {
        Console.WriteLine($"{_SelctName} x{_HowMany} {total_pay}원");
        Console.WriteLine($"합계 : {total_pay}");
    }
    
    /*if (total_pay< )
    {
        
    }*/
    

    
}