using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterfaceImp
{
    internal class CreaditCardPayment : IPaymentMode
    {
        public void MakePayment()
        {
            Console.WriteLine("Creadit card payment activated . . ");
        }
    }
}
