using System;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;

namespace Rasp_PaymentSystem
{
    internal class PaymentSystem : IPaymentSystem
    {
        private HashAlgorithmType _hashAlgorithmType;

        public PaymentSystem(HashAlgorithmType hashAlgorithmType)
        {
            if (hashAlgorithmType == HashAlgorithmType.None)
                throw new ArgumentNullException(nameof(hashAlgorithmType));

            _hashAlgorithmType = hashAlgorithmType;
        }

        protected string GenerateHash(int input)
        {
            string data = input.ToString();
            HashAlgorithm hashAlgorithm = HashAlgorithm.Create(_hashAlgorithmType.ToString());
            byte[] hash = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(data));
            return Convert.ToBase64String(hash);
        }

        public virtual string GetPayingLink(Order order)
        {
            return String.Empty;
        }
    }
}
