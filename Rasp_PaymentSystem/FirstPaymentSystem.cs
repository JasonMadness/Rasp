using System.Security.Authentication;

namespace Rasp_PaymentSystem
{
    internal class FirstPaymentSystem : PaymentSystem
    {       
        public FirstPaymentSystem(HashAlgorithmType hashAlgorithm) : base(hashAlgorithm)
        {
            
        }

        public override string GetPayingLink(Order order)
        {
            string hash = GenerateHash(order.Id);
            return $"pay.system1.ru/order?amount={order.Amount}RUB&hash={hash}";
        }
    }
}
