using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ThreadingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;   
            List<EaterModel> eaters = new List<EaterModel>(5)
            {
                new EaterModel("John"),
                new EaterModel("Bill"),
                new EaterModel("Sarah"),
                new EaterModel("Samuel"),
                new EaterModel("Serg")
            };

            foreach (var a in eaters)
            {
                a.Position = eaters.IndexOf(a);
            }

            while (i < 10)
            {

                Thread t1 = new Thread(() => eaters[0].Eat(eaters));
                t1.Start();

                Thread t2 = new Thread(() => eaters[1].Eat(eaters));
                t2.Start();

                Thread t3 = new Thread(() => eaters[2].Eat(eaters));
                t3.Start();

                Thread t4 = new Thread(() => eaters[3].Eat(eaters));
                t4.Start();

                Thread t5 = new Thread(() => eaters[4].Eat(eaters));
                t5.Start();

                i++;
            }

        }


    }
}
