using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterfaceImp
{
    public enum Mode
    {
        CreditCard,
        DebitCard,
        GooglePay
    }
    internal class PaymentModeFactorycs
    {
        public static IPaymentMode Create(Mode mode)
        {
            if (mode == Mode.CreditCard)
            {
                return new CreaditCardPayment();
            }
            else if (mode == Mode.DebitCard)
            {
                return new DebitCardPayment();
            }
            else
            {
                return new GooglePay();
            }
               
        }
    }
}
