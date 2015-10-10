using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVariable = 0;
            using (TransactionScope transactionScope = new TransactionScope())
            {
                myVariable = 1;
                transactionScope.Dispose();
            }

            Console.Write("myVariable value is: {0}", myVariable);
        }
    }
}
