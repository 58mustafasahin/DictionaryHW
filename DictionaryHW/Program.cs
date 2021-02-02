using System;

namespace DictionaryHW
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> sehirler = new MyDictionary<int, string>();
            sehirler.Add(24, "Erzincan");
            sehirler.Add(35, "İzmir");
            sehirler.Add(58, "Sivas");
            sehirler.Add(26, "Eskişehir");
            sehirler.Add(16, "Bursa");

        }
    }
}
