namespace PolymorphismDemo;

class Calculator1
{
    public void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public void Add(float x, float y)
    {
        Console.WriteLine(x + y);
    }
}

class Calculator2 : Calculator1
{
    public void Add(string s1, string s2)
    {
        Console.WriteLine(s1 +" "+ s2);
    }
}
