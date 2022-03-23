namespace Rasp_PaymentSystem
{
    internal interface IPaymentSystem
    {
        string GetPayingLink(Order order);
    }
}
