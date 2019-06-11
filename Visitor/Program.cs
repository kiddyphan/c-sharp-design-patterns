using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book(100, "The Bell");
            var food1 = new Food(100, "Hot dog");

            var food2 = new Food(200, "Bread");
            var book2 = new Book(200, "Into The Woods");
            
            var book3 = new Book(200, "Final Exams");
            var food3 = new Food(200, "Noodle");
            
            var book4 = new Book(300, "Conan");
            var food4 = new Food(300, "Soup");
            
            var cash = new CashPaymentMethod();
            var visa = new VisaPaymentMethod();
            var ewallet = new EWalletPaymentMethod();

            // Book discount 10%: 100$ -> 90$
            var cost1 = book1.Accept(cash) + food1.Accept(cash);
            Console.WriteLine($"Cost 1: {cost1}");
            
            // Food discount 10%: 200$ -> 180$ 
            var cost2 = book2.Accept(visa) + food2.Accept(visa);
            Console.WriteLine($"Cost 2: {cost2}");
            
            // Book < 200 discount 10%: 200$ -> 180$
            var cost3 = book3.Accept(cash) + food3.Accept(ewallet);
            Console.WriteLine($"Cost 3: {cost3}");
            
            // Book > 200 discount 20%: 300$ -> 240$
            // Food > 200 discount 10%: 300$ -> 270$
            var cost4 = book4.Accept(ewallet) + food4.Accept(ewallet);
            Console.WriteLine($"Cost 4: {cost4}");

        }
    }
}