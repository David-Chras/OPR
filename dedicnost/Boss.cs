/// <summary>
/// Představuje silného nepřítele (Bosse) v počítačové hře.
/// Boss má jméno, počet životů a několik fází souboje.
/// Dokáže útočit, zastrašovat protivníka a měnit
/// své chování podle aktuální fáze.
/// </summary>
namespace Dedicnost
{
    public class Boss : Postava
    {

        /// <summary>
        /// Aktuální počet životů bosse.
        /// </summary>
        public int Zivoty { get;set; }

        public int AktualniZivoty { get; protected set; }


        /// <summary>
        /// Aktuální fáze souboje.
        /// Výchozí hodnota je 1.
        /// </summary>
        public int Faze{ get;private set;} = 1;


        /// <summary>
        /// Vytvoří nového bosse se zadaným jménem
        /// a počtem životů.
        /// </summary>
        /// <param name="jmeno">Jméno bosse.</param>
        /// <param name="id">Jednoznačný identifikátor postavy.</param>
        /// <param name="zivoty">Počáteční počet životů.</param>
        public Boss(string jmeno, int id, int zivoty) : base(jmeno, id)
        {
            Zivoty = zivoty;
            AktualniZivoty = zivoty;
        }


        /// <summary>
        /// Provede útok podle aktuální fáze bosse.
        /// </summary>
        /// <remarks>
        /// Fáze 1: Boss útočí mečem.
        /// Fáze 2: Boss používá ohnivý útok.
        /// Fáze 3: Boss používá smrtící kouzlo.
        /// </remarks>
        public override void Utoc()
        {
            switch (Faze)
            {
                case 1:
                    Console.WriteLine("Boss útočí mečem!");
                    break;

                case 2:
                    Console.WriteLine("Boss používá ohnivý útok!");
                    break;

                case 3:
                    Console.WriteLine("Boss používá smrtící kouzlo!");
                    break;

                default:
                    base.Utoc();
                break;
            }
        }


        /// <summary>
        /// Změní fázi bosse podle zbývajících životů.
        /// </summary>
        /// <remarks>
        /// Více než 50 % životů: fáze 1.
        /// 21–50 % životů: fáze 2.
        /// 20 % životů a méně: fáze 3.
        /// </remarks>
        
        public void ZmenFazi()
        {
            float zivotyProcenta = (float)AktualniZivoty / Zivoty * 100;
            if (zivotyProcenta > 50)
                {
                    Faze = 1;
                }
                else if (zivotyProcenta <= 50 && zivotyProcenta >= 21)
                {
                    Faze = 2;
                }
                else
                {
                    Faze = 3;
                }   
        }


        /// <summary>
        /// Vypíše zastrašující hlášku bosse.
        /// </summary>
        public void Hlaska()
        {
            Console.WriteLine("Boss zastrašuje protivníka!");
        }


        /// <summary>
        /// Vypočítá poškození útoku podle aktuální fáze.
        /// </summary>
        /// <param name="zakladniPoskozeni">
        /// Základní hodnota poškození útoku.
        /// </param>
        /// <returns>
        /// Celkové poškození po zohlednění fáze bosse.
        /// </returns>
        // SEM DOPLŇ METODU
        
    }
}