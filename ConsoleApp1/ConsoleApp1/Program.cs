// https://github.com/seung611/26.08.28_practice

using System;
using ConsoleApp1;

class Program
{
    private const string CafeName = "one썸 플레이스";
    private const int DisCountNumber = 3;
    private const int DisCount = 10;
    
    static void Main(string[] args)
    {
        ShoppingList[] menuList = new []
        {
            new ShoppingList("아메리카노", (MenuCategory)1, 4500, "정가"),
            new ShoppingList("카페라떼", (MenuCategory)1, 5000, "정가"),
            new ShoppingList("자몽에이드", (MenuCategory)1, 5500, "정가"),
            new ShoppingList("휘낭시에", (MenuCategory)2, 2500,"3개 이상 10% 할인"),
            new ShoppingList("마카다미아쿠키", (MenuCategory)2, 3000,"3개 이상 10% 할인"),
            new ShoppingList("딸기케이크", (MenuCategory)2, 6000,"정가")
        };
        
        ShoppingCart<IShoppingList> inCart = new ShoppingCart<IShoppingList>(5);
        
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"{CafeName} 주문 키오스크");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("[메뉴판]");
        for (int i = 0; i < menuList.Length; i++)
        {
            Console.Write($"{i + 1}. ");
            menuList[i].MenuListPrint();
        }
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("[장바구니]");
        Pay pay = new ("아메리카노", 4500, 3);
        pay.PayPrint();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("1. 담기  2. 전체 비우기  3. 결제  4. 영업 종료");
        int cartNumber = ConsoleInput.ReadIntInRange("번호 : ", 1, 4);
        

        // 1부터 6 사이의 번호를 받습니다. 숫자가 아니거나 범위를 벗어나면 다시 묻습니다.  
        int menuNumber = ConsoleInput.ReadIntInRange("메뉴 번호 : ", 1, 6);

        // 0 이상의 값을 받습니다. 위쪽 한계를 정하기 어려울 때 씁니다.  
        int paid = ConsoleInput.ReadIntAtLeast("받은 금액 : ", 0);

        // 결과를 보여 준 뒤 화면을 지우기 전에 잠시 멈춥니다.  
        ConsoleInput.Pause();
    }  
}
