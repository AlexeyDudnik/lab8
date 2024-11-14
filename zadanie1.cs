using System;
using System.IO;
using System.Xml.Serialization;
using AnimalLibrary;
class Program
{
    static void Main()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Cow));
        using (FileStream fs = new FileStream("animaldes.xml", FileMode.Open))
        {
            Animal deserializedAnimal = (Animal)serializer.Deserialize(fs);
            Console.WriteLine($"Имя: {deserializedAnimal.Name}, Страна: {deserializedAnimal.Country}, Любимая еда: {deserializedAnimal.GetFavouriteFood()}, Классификация: {deserializedAnimal.GetClassificationAnimal()}");
        }
    }
}
