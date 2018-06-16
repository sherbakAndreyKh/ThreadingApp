using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingApp
{
    public class EatingTable
    {
        public object[] table = new Object[10];

        public void AddTable(List<CutleryModel> cutleries, List<EaterModel> eaters)
        {
            for (int i = 0, y = 0; i < table.Length; i += 2, y++)
            {
                table[i] = cutleries[y];
            }

            for (int i = 1, y = 0; i < table.Length; i += 2, y++)
            {
                table[i] = eaters[y];
            }
        }
    }
}
