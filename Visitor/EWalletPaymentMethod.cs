namespace Visitor
{
    public class EWalletPaymentMethod : IPaymentMethodVisitor
    {
        public int visitBook(Book book)
        {
            var discount = 10;
            if (book.Price > 200)
            {
                discount = 20;
            }

            return book.Price - (book.Price * discount/100);
        }

        public int visitFood(Food food)
        {
            var discount = 0;
            if (food.Price > 200)
            {
                discount = 10;
            }

            return food.Price - (food.Price * discount/100);
        }
    }
}