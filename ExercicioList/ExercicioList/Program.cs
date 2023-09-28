internal class Program
{
    private static void Main(string[] args)
    {
        List<string> list = new List<string>();

        list.Add("Maycon");
        list.Add("Leandro");
        list.Add("Maria");
        list.Insert(1, "João");

        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("List count: " + list.Count);

        string s1 = list.Find(x => x[0] == 'M'); // pegar primeiro nome que começam com M
        Console.WriteLine("First 'M': " + s1);

        string s2 = list.FindLast(x => x[0] ==  'M'); // pegar ultimo nome que começam com M
        Console.WriteLine("Last 'M': " + s2);

        int pos1 = list.FindIndex(x => x[0] == 'M');
        Console.WriteLine("First position 'A': " + pos1);

        int pos2 = list.FindLastIndex(x => x[0] == 'M');
        Console.WriteLine("First position 'A': " + pos2);

        List<string> list2 = list.FindAll(x => x.Length == 5);
        Console.WriteLine("---------------");
        foreach (String obj in list2)
        {
            Console.WriteLine(obj);
        }

        list.Remove("João");
        Console.WriteLine("---------------");
        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }

        list.RemoveAll(x => x[0] == 'M'); // RemoveAt(3) remove uma posição.
        Console.WriteLine("---------------");
        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }

    }
}