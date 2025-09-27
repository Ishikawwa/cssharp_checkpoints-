using System.Drawing;

namespace Dictionary_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> cats = new Dictionary<string, int>(); // Словарь с ключом по String и со значением Int

            cats["Ginger"] = 1; // Cat - ключ | 1 - значение
            cats["Black"] = 1;
            cats["Wavy"] = 1;

            cats["Ginger"]++;
            cats["Ginger"]++;

            cats["Wavy"]++;

            List<string> colors = cats.Keys.ToList();

            for (int i = 0; i < colors.Count(); i++)
            {
                string color = colors[i];
                int catCount = cats[color];
                Console.WriteLine($"We have {catCount} {color} cats"); 
            }

            foreach(KeyValuePair<string, int> cat in cats)
            {
                Console.WriteLine($"We have {cat.Value} {cat.Key} cats");
            }

        }
    }
}
