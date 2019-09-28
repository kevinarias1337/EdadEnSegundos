using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasificaciondeedad
{
   public class Clasificacion
    {
        private double edad;
        
        public void setEdad(double total)
        {
            this.edad = total;
        }
        public double getEdad()
        {
            return this.edad;
        }
        public double edadTotal()
        {
            return this.getEdad();
        }

    }
}
