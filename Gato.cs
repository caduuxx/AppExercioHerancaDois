using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AppExercioHerancaDois.Dominio
{
    internal class Gato:Animal
    {
        public string Mia() 
        {
            string mia = "esse animal mia";
            return mia;
        }
    }
}
