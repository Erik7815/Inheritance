namespace Iheritancetoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car v1 = new Car();
            v1.Speed = 120;
            v1.Name = "BMW";

            Bicycle v2 = new Bicycle();
            v2.Name = "Trek";
            v2.Speed = 20;

            v1.Describe();
            v2.Describe();
        }
    }
}
