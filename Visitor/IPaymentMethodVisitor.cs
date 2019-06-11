namespace Visitor
{
    public interface IPaymentMethodVisitor
    {
        int visitBook(Book book);
        int visitFood(Food food);
    }
}