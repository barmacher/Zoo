using Zoo;

//Bird vorona = new Bird("Ворона");
//Fish wuka = new Fish("Щука");
//Insects gusenica = new Insects("Гусенница");


//vorona.Info();
//wuka.Info();
//gusenica.Info();


string[] names = { "Misha", "Sanya", "Ksusha",
      "Chort", "Pidor", "Vasya", "Kesha" };
List<string> animals = new List<string>();
Random rand = new Random();

for (int i = 0; i<names.Length; i++)
{
    Fish fish = new Fish(names[rand.Next(0, names.Length)]);
    animals.Add(fish.Name);
}

//animals.Add(vorona.Name);
//animals.Add(wuka.Name);
//animals.Add(gusenica.Name);
for(int i = 0; i<animals.Count; i++)
{
    Console.WriteLine(animals[i]);
}
