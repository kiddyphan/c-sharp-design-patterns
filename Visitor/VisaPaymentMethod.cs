namespace Visitor
{
    public class VisaPaymentMethod : IPaymentMethodVisitor
    {
        public int visitBook(Book book)
        {
            return book.Price;
        }

        public int visitFood(Food food)
        {
            return food.Price - (food.Price * 10/100);
        }
    }
}