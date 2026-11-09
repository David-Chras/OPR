namespace Dedicnost
{
    public abstract class Postava
    {
        private string jmeno;
        private int id;

        public int Id
        {
            get { return id; }
        }
        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }
        public Postava(string jmeno, int id)
        {
            this.jmeno = jmeno;
            this.id = id;
        }

        public abstract void Utoc();
        public void PredstavSe()
        {
            Console.WriteLine($"Jmenuji se {jmeno}");
        }
    }
}