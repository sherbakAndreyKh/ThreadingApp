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

        public EaterModel()
        {
         
        }

        public EaterModel ( string Name)
        {
            this.Name = Name;
        }

    }
}
