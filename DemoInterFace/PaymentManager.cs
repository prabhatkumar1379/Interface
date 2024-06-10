using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterFace
{
    internal class PaymentManager
    {
        private readonly CreaditCardPayment _creaditCard;
        private readonly DebitCardPayment _debitCard;
        private readonly GooglePay _googlePay;
        private readonly PhonePay _phonePay;
        public PaymentManager(CreaditCardPayment creaditCard, DebitCardPayment debitCard ,GooglePay googlePay, PhonePay phonePay)
        {
            _creaditCard = creaditCard;
            _debitCard = debitCard;
            _googlePay = googlePay;
            _phonePay = phonePay;

        }
        public void MakePament()
        {
            _creaditCard.MakePayment();
            _debitCard.MakePayment();
            _googlePay.MakePayment();
            _phonePay.MakePayment();
        }
    }
}
