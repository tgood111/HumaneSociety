using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    static class AnimalDbHelper
    {
        public static List<Animal> GetTable()
        {
            HSDataDataContext context = new HSDataDataContext();
            var results = context.Animals.Select(animals => animals);
            return results.ToList();
        }

        public static bool AddAnimal(Animal addition)
        {
            try
            {
                HSDataDataContext context = new HSDataDataContext();
                context.Animals.InsertOnSubmit(addition);
                context.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool AddAnimals(List<Animal> adds)
        {
            try
            {
                HSDataDataContext context = new HSDataDataContext();
                context.Animals.InsertAllOnSubmit(adds);
                context.SubmitChanges();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool UpdateAnimal(Animal updated)
        {
            try
            {
                HSDataDataContext context = new HSDataDataContext();
                var res = (from animals in context.Animals
                    where animals.Animal_ID == updated.Animal_ID
                    select animals).First();

                res.Adoption_Status = updated.Adoption_Status;
                res.Color = updated.Color;
                res.Food_Intake = updated.Food_Intake;
                res.Has_Shot = updated.Has_Shot;
                res.Name = updated.Name;
                res.Room = updated.Room;
                res.Type = updated.Type;
                context.SubmitChanges();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool DeleteAnimal(Animal del)
        {
            try
            {
                HSDataDataContext context = new HSDataDataContext();
                context.Animals.DeleteOnSubmit(del);
                context.SubmitChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool DeleteAnimals(List<Animal> del)
        {
            try
            {
                HSDataDataContext context = new HSDataDataContext();
                context.Animals.DeleteAllOnSubmit(del);
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
