using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
   static class TransactionDBHelper
    {
        public static List<Transaction> GetTransaction()
        {
            HSDataDataContext context = new HSDataDataContext();
            var results = context.Transactions.Select(transactions => transactions);
            return results.ToList();
        }

        public static bool AddTransaction(Transaction addition)
        {
            try
            {
                HSDataDataContext context = new HSDataDataContext();
                context.Transactions.InsertOnSubmit(addition);
                context.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static bool AddTransactions(List<Transaction> adds)
        {
            try
            {
                HSDataDataContext context = new HSDataDataContext();
                context.Transactions.InsertAllOnSubmit(adds);
                context.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool UpdateTransaction(Transaction updated)
        {
            try
            {
                HSDataDataContext context = new HSDataDataContext();
                var res = (from transactions in context.Transactions
                    where transactions.Transaction_ID == updated.Transaction_ID
                    select transactions).First();

                res.Animal = updated.Animal;
                res.Adopter = updated.Adopter;
                res.Amont_Paid = updated.Amont_Paid;
                res.Amount_Owed = updated.Amount_Owed;
                context.SubmitChanges();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool DeleteTransaction(Transaction del)
        {
            try
            {
                HSDataDataContext context = new HSDataDataContext();
                context.Transactions.DeleteOnSubmit(del);
                context.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool DeleteTransactions(List<Transaction> del)
        {
            try
            {
                HSDataDataContext context = new HSDataDataContext();
                context.Transactions.DeleteAllOnSubmit(del);
                context.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }

    
}
