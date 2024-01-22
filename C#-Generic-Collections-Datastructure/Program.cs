using C__Generic_Collections_Datastructure.Domain.Models;
Book book1 = new("The Maze Runner", 15.99, "James Dashner", 375, 3);
book1.Sell();
book1.Sell();
book1.ShowInfo();
Console.WriteLine("=======================");
Book book2 = new("The Da Vinci Code", 9.99, "Dan Brown", 597, 1);
book2.Sell();
book2.ShowInfo();
Console.WriteLine("=======================");
Book.Income();



