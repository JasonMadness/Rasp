using System.Security.Authentication;

namespace Rasp_PaymentSystem
{
    internal class SecondPaymentSystem : PaymentSystem
    {
        public SecondPaymentSystem(HashAlgorithmType hashAlgorithm) : base(hashAlgorithm)
        {
            
        }

        public override string GetPayingLink(Order order)
        {
            string hash = GenerateHash(order.Id + order.Amount);
            return $"order.system2.ru/pay?hash={hash}";
        }
    }
}
