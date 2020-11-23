using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class SavingsAccount : Account
    {
        int trans = 0;

        public SavingsAccount(string name, string id, double balance) : base(name, id, balance)
        {

        }

        override public void transaction(double ammount)
        {

            if (trans >= 5)
            {
                Console.WriteLine(" The maximum transaction time commited");
            }
            else if (this.balance - amount < 500)
            {
                Console.WriteLine(" The transaction couldn't be completed due to balance less than 500$");
            }
            else
            {
                this.balance = this.balance - amount;
                trans++;
            }

        }
        override public void ShowInfo()
        {
            Console.WriteLine("Name :" + name + " ID :" + id + "  Balance :" + balance);
        }
    }
}
