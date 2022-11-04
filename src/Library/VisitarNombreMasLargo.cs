namespace Library
{
    public class VisitarNombreMasLargo : IVisitor
    {
        public string Resultado { get; private set; } = "";
        public void  Visit (Person person)
        {
            if (person.Name.Length>Resultado.Length)
            {
                Resultado = person.Name;
            }
            foreach (Person i in person.Children)
            {
                i.Accept(this);
            }

        }
    }
}