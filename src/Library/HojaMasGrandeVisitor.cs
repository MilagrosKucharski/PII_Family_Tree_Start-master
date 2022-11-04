namespace Library
{
    public class HojaMasGrandeVisitor :IVisitor
    {
        public int Resultado { get; private set; }
        
        public void Visit(Person person)
        {
            if(person.Children.Count == 0 && person.age > Resultado)
            {
                Resultado = person.age;
            }
            

            foreach (Person p in person.Children)
            {
                p.Accept(this);
            }
        }
    }
}