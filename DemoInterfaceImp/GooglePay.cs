using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterfaceImp
{
    internal class GooglePay : IPaymentMode
    {
        public void MakePayment()
        {
            Console.WriteLine("Google Pay payment activated . . ");
        }
    }
}
