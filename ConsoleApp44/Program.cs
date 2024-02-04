class dikdortgen
{

    public float Alan(float en, float boy)
    {
        return en * boy;
    }

    public float Cevre(float en, float boy)
    {
        return ((en + boy) * 2);
    }

}

Program.cs:

 class Program
{
    static void Main(string[] args)
    {
        dikdortgen dd = new dikdortgen();
        Console.Write("Kısa kenarı Girin : ");
        float kk = Convert.ToSingle(Console.ReadLine());
        Console.Write("Uzun kenarı Girin : ");
        float uk = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Dikdörtgenin alanı : {0}", dd.Alan(kk, uk));
        Console.WriteLine("Dikdörtgenin çevresi : {0}", dd.Cevre(kk, uk));
        Console.ReadKey();
    }
}




 class Program
{
    static void Main(string[] args)
    {
        dikdortgen dd = new dikdortgen();
        Console.Write("Kısa kenarı Girin : ");
        float kk = Convert.ToSingle(Console.ReadLine());
        Console.Write("Uzun kenarı Girin : ");
        float uk = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Dikdörtgenin alanı : {0}", dd.Alan(kk, uk));
        Console.WriteLine("Dikdörtgenin çevresi : {0}", dd.Cevre(kk, uk));
        Console.ReadKey();
    }
}

