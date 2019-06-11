namespace Visitor
{
    public class Food : IItem
    {
        private int _price = 0;
        private string _name;

        public Food(int price, string name)
        {
            _price = price;
            _name = name;
        }

        public int Price => _price;
        public string Name => _name;

        public int Accept(IPaymentMethodVisitor visitor)
        {
            return visitor.visitFood(this);
        }
    }
}