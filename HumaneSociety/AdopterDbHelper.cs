using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    static class AdopterDbHelper
    {
        public static List<Adopter> GetTable()
        {
            HSDataDataContext context = new HSDataDataContext();
            var results = context.Adopters.Select(adopter => adopter);
            return results.ToList();
        }

        public static bool AddAdopter(Adopter addition)
        {
            try
            {
                HSDataDataContext context = new HSDataDataContext();
                context.Adopters.InsertOnSubmit(addition);
                context.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool AddAdopters(List<Adopter> adds)
        {
            try
            {
                HSDataDataContext context = new HSDataDataContext();
                context.Adopters.InsertAllOnSubmit(adds);
                context.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool UpdateAdopter(Adopter updated)
        {
            try
            {
                HSDataDataContext context = new HSDataDataContext();
                var res = (context.Adopters.Where(adopters => adopters.Adopter_ID == updated.Adopter_ID)).First();

                res.Adopter_Address = updated.Adopter_Address;
                res.Adopter_Age = updated.Adopter_Age;
                res.Adopter_Description = updated.Adopter_Description;
                res.Adopter_Name = updated.Adopter_Name;
                res.Adopter_Phone_Number = updated.Adopter_Phone_Number;
                context.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool DeleteAdopter(Adopter del)
        {
            try
            {
                HSDataDataContext context = new HSDataDataContext();
                context.Adopters.DeleteOnSubmit(del);
                context.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool DeleteAdopters(List<Adopter> del)
        {
            try
            {
                HSDataDataContext context = new HSDataDataContext();
                context.Adopters.DeleteAllOnSubmit(del);
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