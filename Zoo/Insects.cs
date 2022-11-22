using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Insects : IAnimal
    {
        public string Name { get; set; }

        public double Weight { get; set; }

        public string Ration { get; set; }

        public Insects(string name/*, string ration, double weight*/)
        {
            //Name = name;
            //Ration = ration;
            //Weight = weight;
        }

        public void Info()
        {
            Console.WriteLine($"Название:{this.Name} Вес: {Weight} Что ест: {Ration}");
        }
    }
}
