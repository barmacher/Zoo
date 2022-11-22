using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Bird : IAnimal
    {
        public string Name { get; set; }

        public double Weight { get; set; }

        public string Ration { get; set; }
        public string Sound { get; set; }

        public Bird(string name, string ration, double weight, string sound)
        {
            Name = name;
            Ration = ration;
            Weight = weight;
            Sound = sound;

        }

    

        public void Info()
        {
            Console.WriteLine($"Название:{Name} Вес: {Weight} Что ест: {Ration} Звук {Sound}");

        }
    }
}
