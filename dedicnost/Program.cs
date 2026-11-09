namespace Dedicnost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Testovací prostředí

           Postava [] legie = new Postava[1000];

           legie[0] = new Bojovnik(1,"Conan", "meč");
           legie[1] = new Bojovnik(1,"Aragorn", "sekera");
           legie[2] = new Bojovnik(2,"Lubomír", "meč");

            Boss Malakor= new Boss("Malakor", 24, 1000);
           Bojovnik barbar = new Bojovnik(1,"Conan", "meč");
           Kouzelnik lubomír = new Kouzelnik(2, "Lubomír", 9);
           FinalBoss finalBoss = new FinalBoss("ElGrando", 25, 2000, 120);

           Bojovnik Bajaja = new Bojovnik(3, "Bajaja", "meč");
           
           finalBoss.VypisInformace();
           finalBoss.PrepniBojovyRezim();
           finalBoss.Utoc();
           finalBoss.VypisInformace();

           Console.WriteLine($"Síla útoků: {finalBoss.VypocitejPoskozeni(50)}");
           
           Malakor.Utoc();
           Malakor.PredstavSe();
           barbar.PredstavSe();
           barbar.Utoc();
           barbar.ZvedniStit();
           
           lubomír.PredstavSe();
           lubomír.Utoc();

           Console.WriteLine(barbar.Jmeno);

           barbar.Jmeno = "Lotus";

           Console.WriteLine(barbar.Jmeno);

           Console.WriteLine(lubomír.Mana);

           lubomír.Meditace();

           //Postava postava = new Postava("Test", 1);

           List<Postava> postavy = new List<Postava>();
           postavy.Add(barbar);
           postavy.Add(lubomír);
           postavy.Add(Malakor);
           postavy.Add(finalBoss);
           postavy.Add(Bajaja);
           foreach (Postava postava in postavy) postava.Utoc();
        }
    }
}
