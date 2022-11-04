namespace Library
{
    public abstract class Visitor
    {
        public int SumaEdades
        {
            get
            {
                return this.Sumado;
            }
        }
        protected int Sumado {get;}
        public abstract void  Visit (Person person)
    }
}