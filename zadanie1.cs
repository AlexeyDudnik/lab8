using System;
using System.IO;
using System.Xml.Serialization;
using AnimalLibrary;
class main
{
    static void Main()
    {
        Animal cow = new Cow { Name = "Машка", Country = "Россия", HideFromOtherAnimals = false };
        XmlSerializer serializer = new XmlSerializer(typeof(Cow));
        using (FileStream fs = new FileStream("animaldes.xml", FileMode.Create))
        {
            serializer.Serialize(fs, cow);
        }
        Console.WriteLine("XML файл с животным создан.");
        using (FileStream fs = new FileStream("animaldes.xml", FileMode.Open))
        {
            Animal deserializedAnimal = (Animal)serializer.Deserialize(fs);
            Console.WriteLine($"Имя: {deserializedAnimal.Name}, Страна: {deserializedAnimal.Country}, Любимая еда: {deserializedAnimal.GetFavouriteFood()}, Классификация: {deserializedAnimal.GetClassificationAnimal()}");
        }
    }
}
