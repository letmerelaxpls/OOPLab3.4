using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab3._4
{
    class Invoice
    {
        public int account; //счет
        public string customer; // клиент
        public string provider; // поставщик
        public string article; // изделие
        public int quantity; // количество
        public int Sum;

        public int GetAccountWithNds(double nds = 0.2)
        {
            return Sum = (int)(account * nds);
        }
        public void Show()
        {
            Console.WriteLine(" {0} ordered {1} from {2} in quantity of {3} and invoiced for {4} without VAT and {5} with VAT", customer, article, provider, quantity, account, Sum);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();
            Console.WriteLine("Enter account: ");
            invoice.account = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter customer: ");
            invoice.customer = Console.ReadLine();
            Console.WriteLine("Enter provider: ");
            invoice.provider = Console.ReadLine();
            Console.WriteLine("Enter article: ");
            invoice.article = Console.ReadLine();
            Console.WriteLine("Enter quantity of article: ");
            invoice.quantity = int.Parse(Console.ReadLine());
            invoice.GetAccountWithNds();
            invoice.Show();
        }
    }
}
