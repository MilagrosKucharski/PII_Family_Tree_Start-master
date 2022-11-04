namespace Library
{
    public class VisitarHojaMasGrande : IVisitor
    {
        public int Resultado { get; private set; }
        public void  Visit (Person person)
        {
            if (person.Children.Count == 0 && person.Age>Resultado)
            {
                Resultado = person.Age;
            }
            
            foreach (Person i in person.Children)
            {
                i.Accept(this);
            }

        }
    }
}