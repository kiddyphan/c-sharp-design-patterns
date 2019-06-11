namespace Visitor
{
    public class CashPaymentMethod : IPaymentMethodVisitor
    {
        public int visitBook(Book book)
        {
            return book.Price - (book.Price * 10/100);
        }

        public int visitFood(Food food)
        {
            return food.Price;
        }
    }
}