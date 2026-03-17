namespace ASPNET_FIRST.Models
{
    public class Person
    {
        public Person(double hello, decimal world, string lll)
        {
            this.hello = hello;
            this.world = world;
            this.lll = lll;
        }
        public double hello { get; set; }
        public decimal world { get; set; }
        public string lll { get; set; }
    }
}
