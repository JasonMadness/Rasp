using System.Security.Authentication;

namespace Rasp_PaymentSystem
{
    internal class ThirdPaymentSystem : PaymentSystem
    {
        private int _secretKey = 123;

        public ThirdPaymentSystem(HashAlgorithmType hashAlgorithm) : base(hashAlgorithm)
        {
            
        }

        public override string GetPayingLink(Order order)
        {
            string hash = GenerateHash(order.Amount + order.Id + _secretKey);
            return $"system3.com/pay?amount={order.Amount}&currency=RUB&hash={hash}";
        }
    }
}
