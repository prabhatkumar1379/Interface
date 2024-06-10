namespace DemoInterFace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreaditCardPayment creaditCardPayment = new CreaditCardPayment();
            DebitCardPayment debitCardPayment = new DebitCardPayment();
            GooglePay googlePay= new GooglePay();   
            PhonePay phonePay = new PhonePay();

            PaymentManager paymentManager = new PaymentManager(creaditCardPayment, debitCardPayment, googlePay, phonePay);
            paymentManager.MakePament();
            Console.ReadLine();  

        }
    }
}