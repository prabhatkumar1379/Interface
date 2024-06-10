using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterfaceImp
{
    internal class DebitCardPayment : IPaymentMode
    {
        public void MakePayment()
        {
            Console.WriteLine("Debit  card payment activated . . ");
        }
    }
}
