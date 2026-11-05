namespace Dedicnost
{
    /// <summary>
    /// Představuje bojovníka v počítačové hře.
    /// Bojovník používá vlastní zbraň, může útočit a bránit se.
    /// </summary>
    class Bojovnik : Postava
    {
        /// <summary>
        /// Obsahuje zvolenou zbraň bojovníka.
        /// </summary>
        private string zbran;

        /// <summary>
        /// Vytvoří nového bojovníka.
        /// </summary>
        /// <param name="id">Jednoznačný identifikátor</param>
        /// <param name="jmeno">Zvolené jméno bojovníka ve hře</param>
        /// <param name="zbran">Zvolená zbraň bojovníka</param>

        public Bojovnik(int id, string jmeno, string zbran) : base(jmeno, id)
        {
            this.zbran = zbran;
        }

        public void ZvedniStit()
        {
            Console.WriteLine("Bojovník zvedá štít a brání se...");
        }

        public override void Utoc()
        {
            Console.WriteLine("Útočím " + zbran);
        }
    }
}