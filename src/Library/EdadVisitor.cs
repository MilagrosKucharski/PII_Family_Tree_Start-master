namespace Library
{
    public class EdadVisitor :IVisitor
    {
        public int Resultado { get; private set; }
        
        public void Visit(Person person)
        {
            Resultado += person.age;
            

            foreach (Person p in person.Children)
            {
                p.Accept(this);
            }
        }
    }
}