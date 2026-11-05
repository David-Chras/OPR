namespace Dedicnost
{
public sealed class FinalBoss : Boss
{
    public int Pancir { get; private set; }

    public int PocetUtoku { get; private set; } = 0;

    public bool BojovyRezim { get; private set; } = false;

    public FinalBoss(string jmeno, int id, int zivoty, int pancir) : base(jmeno, id, zivoty)
        {
            Pancir = pancir;
        }
        public override void Utoc()
        {
            PocetUtoku++;

        switch (Faze)
        {
            case 1:
                Console.WriteLine("Útočí mechanicko pěstí!");
                break;

            case 2:
                Console.WriteLine("Útočí plazmovou puškou!");
                break;

            case 3:
                Console.WriteLine("Aktivuje smrtící laser...");
                break;

            default:
                 base.Utoc();
            break;
        }


    }

    public void PrepniBojovyRezim()
    {
        BojovyRezim = !BojovyRezim;

        Console.WriteLine(BojovyRezim ? "Bojový režim aktivován" : "Bojový režim deaktivován");
    }

    public int VypocitejPoskozeni(int zakladniPoskozeni)
    {
        if (zakladniPoskozeni < 0)      
            throw new ArgumentException(nameof(zakladniPoskozeni), "Základní poškození nemůže být záporné.");

        int poskozeni = zakladniPoskozeni * Faze;

        if (BojovyRezim)
        {
            poskozeni *= 2;
        }
       
        return poskozeni;
    }

    public int VypocitejZivotyPoUtok(int poskozeni)
    {
        if (poskozeni < 0)      
            throw new ArgumentException(nameof(poskozeni));

        return poskozeni * (100 - Pancir) / 100;
    }

    public void VypisInformace()
        {
            Console.WriteLine($"Jméno: {Jmeno}");
            Console.WriteLine($"Životy: {AktualniZivoty}/{Zivoty}");
            Console.WriteLine($"Fáze: {Faze}");
            Console.WriteLine($"Pancíř: {Pancir}%");
            Console.WriteLine($"Počet útoků: {PocetUtoku}");
            Console.WriteLine($"Bojový režim: {(BojovyRezim ? "Aktivován" : "Deaktivován")}");
        }
}
}