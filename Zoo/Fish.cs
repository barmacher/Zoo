using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Fish : IAnimal
    {
        public string Color { get; set; }
        public string Name { get; set; }

        public double Weight { get; set; }

        public string Ration { get; set; }

        public Fish(string name/*, string ration, double weight, string color*/)
        {
            Name = name;
            //Ration = ration;
            //Weight = weight;
            //Color = color;
        }

        public void Info()
        {
            Console.WriteLine($"Название:{Name} Вес: {Weight} Что ест: {Ration} Цвет: {Color}");

        }
    }
}
