using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingApp
{
   public class EaterModel
    {

        public string Name { get; set; }
        public int Position { get; set; }
        public bool Cutlery { get; set; }
        static object locker = new object();

        public EaterModel()
        {
         
        }

        public EaterModel ( string Name)
        {
            this.Name = Name;
        }

       public void Eat(List<EaterModel> eaters)
        {
            lock (locker)
            {
                if (Position == 0)
                {
                    if (Cutlery == false && eaters[eaters.Count - 1].Cutlery == false)
                    {
                        Cutlery = true;
                        eaters[eaters.Count - 1].Cutlery = true;
                        Console.WriteLine(Name + " Eating");
                        Console.WriteLine();
                        Cutlery = false;
                        eaters[eaters.Count - 1].Cutlery = false;
                    }
                   
                }
                else if (Cutlery == false && eaters[Position - 1].Cutlery == false)
                {
                    Cutlery = true;
                    eaters[Position - 1].Cutlery = true;
                    Console.WriteLine(Name + " Eating");
                    Console.WriteLine();
                    Cutlery = false;
                    eaters[Position - 1].Cutlery = false;
                }
            }
        }
    }
}
