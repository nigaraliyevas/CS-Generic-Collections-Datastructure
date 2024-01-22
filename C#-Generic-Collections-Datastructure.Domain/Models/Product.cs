namespace C__Generic_Collections_Datastructure.Domain.Models
{
    public abstract class Product
    {
        public int Id { get;}
        protected static int _id;
        public string Name { get; set; }
        public  double Price { get; set; }
        protected int Count { get; set; }
        public int Stock { get; set; }
        protected static double TotalInCome { get; set; }
        public abstract void Sell();
        public abstract void ShowInfo();
        public Product()
        {
            Id = ++_id;
        }
    }
}
