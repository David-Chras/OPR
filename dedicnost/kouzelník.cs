namespace Dedicnost
{
     class Kouzelnik : Postava
    {
        private int mana;
        private int manamax = 100;

        public int Mana
        {
            get { return mana; }
            private set { mana = value; }
        }


        public int ManaMax
        {
            get { return manamax; }
            private set { manamax = value; }
        }


        public Kouzelnik(int id, string jmeno, int mana, int manamax = 100) : base(jmeno, id)
        {
            Mana = mana;
            ManaMax = manamax;
        }

        public override void Utoc()
        {
            if (mana >= 10)
            {
                mana -= 10;
                Console.WriteLine("OHNIVÁ GULA!");
            }
            else
            {
                Console.WriteLine("Nemám dost many na kouzlení!");
                ;
            }
        }

        public void Meditace()
        {
            while (manamax > mana)
            {
                if (Mana + 10 > manamax)
                {
                    mana = manamax;
                }
                else
                {
                    mana += 10;
                }
            
                Thread.Sleep(2000);
                Console.WriteLine($"{Jmeno}: Medituji: {Mana}");
            }
            Console.WriteLine("Probouzím se");
        }

        
    }
}