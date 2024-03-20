namespace Bank
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Just checking weather things work or not
            BankAccountNS ba = new BankAccountNS()
            {
                m_cutomerName = "Mr. Bryan Walton",
                m_balance = 11.99
            };
            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is $" , ba.Balance);
        }
    }

    public class BankAccountNS()
    {
        //variables
        public string m_cutomerName;
        public double m_balance;


        private void BankAccount()
        {

        }
        //To make a new aboount based of nameof the customer 
        //balance of the customer
        public void BankAccount(string custonmername, double balance)
        {
            m_balance = balance;
            m_cutomerName = custonmername;
        }

        //Subtrats the amount from balance and cathes expetions basedon  the condition 
        public void Debit(double amount)
        {
            if (m_balance < amount)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");

            }
            m_balance -= amount;
        }

        //Add the amout  into balance if the amount is geater than zero
        //otherwise throws an expetion
        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance += amount;
        }

        //Setting getters
        public string CustomerName
        {
            get { return m_cutomerName; }
        }

        public double Balance
        {
            get { return m_balance; }
        }
    }
}
