using Zoo;

Bird vorona = new Bird("Ворона", "Насекомые", 1000, "КАР!");
Fish wuka = new Fish("Шука", "Мальки", 400, "Зеленый");
Insects gusenica = new Insects("Гусенница", "Листья", 50);



vorona.Info();
wuka.Info();
gusenica.Info();

List <string> animals = new List<string>();
animals.Add(vorona.Name);
animals.Add(wuka.Name);
animals.Add(gusenica.Name);
for(int i = 0; i<animals.Count; i++)
{
    Console.WriteLine(animals[i]);
}