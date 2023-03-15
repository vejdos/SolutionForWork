namespace Exercise
{
    public abstract class Figure
    {
        private string name;
        public Figure(string Name)
        {
            name = Name;
        }
        public abstract double Area();
    }
}