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

        string s1 = list.Find(x => x[0] == 'M');
        Console.WriteLine("First 'M': " + s1);
    }
}