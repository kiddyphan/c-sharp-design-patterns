namespace Visitor
{
    public class Book : IItem
    {
        private int _price = 0;
        private string _name;

        public Book(int price, string name)
        {
            _price = price;
            _name = name;
        }

        public int Price => _price;
        public string Name => _name;

        public int Accept(IPaymentMethodVisitor visitor)
        {
            return visitor.visitBook(this);
        }
    }
}