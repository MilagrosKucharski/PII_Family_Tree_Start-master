namespace Library
{
    public class NombreMasLargoVisitor : IVisitor
    {
        public string Resultado {get ; private set;} = "";

        public void Visit(Person person)
        {
            if (person.Name.Length > Resultado.Length)
            {
                Resultado = person.Name;
            }

            foreach (Person p in person.Children)
            {
                p.Accept(this);
            }
        }
    }
}