internal class Program
{
    private static void Main(string[] args)
    {
        penjumlahan penjumlahan = new penjumlahan();
        penjumlahan.JumlahTigaAngka<long>(13, 02, 20);
    }
}

class penjumlahan
{
    public void JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    { 
        dynamic total = (dynamic)angka1 + (dynamic)angka2 + (dynamic)angka3;
        Console.WriteLine("Total adalah = " + total );
    }
}
