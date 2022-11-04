namespace Library
{
    public class VisitarSumaEdad : IVisitor
    {
        public int Resultado { get; private set; }
        public void  Visit (Person person)
        {
            Resultado += person.Age;
            foreach (Person i in person.Children)
            {
                i.Accept(this);
            }

        }
    }
}