using C__Generic_Collections_Datastructure.Helpers.Helpers;
namespace C__Generic_Collections_Datastructure.Domain.Models
{
    public class Book : Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public Book(string name, double price, string authorName, int pageCount, int countBook)
        {
            Name = name;
            Price = price;
            AuthorName = authorName;
            PageCount = pageCount;
            Count = countBook;
        }
        public override void Sell()
        {
            if (Count == 0)
            {
                CountZeroException.ProductCountIsZero();
            }
            else
            {
                Count--;
                TotalInCome += Price;
            }
        }
        public override void ShowInfo()
        {
            if (Count > 0)
                Console.WriteLine($"Book Name:{Name}\nPrice: {Price}\nAuthor Name: {AuthorName}\nPage Count: {PageCount}\nCount={Count}");
            else Console.WriteLine($"Book Name:{Name}\nPrice: {Price}\nAuthor Name: {AuthorName}\nPage Count: {PageCount}\nCount={Count}");
        }
        public static void Income()
        {
            Console.WriteLine($"Income:{TotalInCome}");
        }
    }
}
