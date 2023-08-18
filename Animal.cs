using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AppExercioHerancaDois.Dominio
{
    internal class Animal
    {
        private string nome;
        private string raça;

        public Animal()
        {
        }

        public string Nome { get => nome; set => nome = value; }
        public string Raça { get => raça; set => raça = value; }

        public void AnimalMetodo() 
        {
        
        } 
        public string AnimalNome() 
        {
            string nome = Nome;
            return nome;
        }
        public string Caminha() 
        {
            string caminha = "esse animal caminha";
            return caminha;
            
        }
        

    }

}
