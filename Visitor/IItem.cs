using System.Data;

namespace Visitor
{
    public interface IItem
    {
        int Accept(IPaymentMethodVisitor visitor);
    }
}