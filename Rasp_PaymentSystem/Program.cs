using System;
using System.Security.Authentication;

namespace Rasp_PaymentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new(1, 12000);
            FirstPaymentSystem firstPaymentSystem = new(HashAlgorithmType.Md5);
            var temp1 = firstPaymentSystem.GetPayingLink(order);
            SecondPaymentSystem secondPaymentSystem = new(HashAlgorithmType.Md5);
            var temp2 = secondPaymentSystem.GetPayingLink(order);
            ThirdPaymentSystem thirdPaymentSystem = new(HashAlgorithmType.Sha1);
            var temp3 = thirdPaymentSystem.GetPayingLink(order);
            Console.WriteLine(temp1);
            Console.WriteLine(temp2);
            Console.WriteLine(temp3);
        }
    }
}
