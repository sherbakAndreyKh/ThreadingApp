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
            EatingTable table = new EatingTable();

            List<EaterModel> eaters = new List<EaterModel>(5)
            {
                new EaterModel("John"),
                new EaterModel("Bill"),
                new EaterModel("Sarah"),
                new EaterModel("Samuel"),
                new EaterModel("Serg")
            };

           List<CutleryModel> cutleries = new List<CutleryModel>(5)
            {
                new CutleryModel(),
                new CutleryModel(),
                new CutleryModel(),
                new CutleryModel(),
                new CutleryModel()
            };

            table.AddTable(cutleries, eaters);

           

           



        }

       
        

    }
}
