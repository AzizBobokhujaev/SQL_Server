using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone(1,"IPhone", 512, 5.8, 1000);
            Phone phone1 = new Phone(2,"Samsung", 256, 6.4, 800);
            Phone phone2 = new Phone(3,"Xiaomi", 128, 6.8, 400);
            phone.Print();
            phone1.Print();
            phone2.Print();
        }
    }
    public class Phone
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Memory { get; set; }
        public double Diagonal { get; set; }
        public int Price { get; set; }
        public Phone() { }
        public Phone(int id,string title,int memory,double diagonal,int price)
        {
            Id = id;
            Title = title;
            Memory = memory;
            Diagonal = diagonal;
            Price = price;
        }
        public void Print()
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine($"| Id = {Id} | Title: {Title} | Memory: {Memory} | Diagonal: {Diagonal} | Price: {Price} |");
            Console.WriteLine("----------------------------------------------------------------------");
        }


    }
}
