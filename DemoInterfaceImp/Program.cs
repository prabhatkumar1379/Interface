namespace DemoInterfaceImp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var creditCard = PaymentModeFactorycs.Create(Mode.GooglePay);
            PaymentManager paymentManager = new PaymentManager(creditCard);
            paymentManager.ManagePayment();
 
                Console.ReadLine();
        }
    }
}