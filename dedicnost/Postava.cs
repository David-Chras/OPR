namespace Dedicnost
{
    public class Postava
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

        public virtual void Utoc()
        {
            Console.WriteLine("Postava útočí klackem");
        }
        public void PredstavSe()
        {
            Console.WriteLine($"Jmenuji se {jmeno}");
        }
    }
}