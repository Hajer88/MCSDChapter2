using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCSDChapter2
{
    //Point and rectangle course exercise
    enum PointColor
    {
        Red,
        Blue,
        Gold
    }
    class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public PointColor colors { get; set; }
        public Point()
        {

        }
        public Point(int x, int y,PointColor colors)
        {
            this.x = x;
            this.y = y;
            this.colors = colors;
        }

    }
    //Test Heap and Stack Memories
    public class Book
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Pages { get; set; }

        public string Display()
        {
            return String.Format("{0}, {1}, pp. {2}", Title, Description
                , Pages);
        }
       
    }
    class Program
    {
        //static method for book
        public static void DoSomething2(int s, Book b)
        {
            s = 1111111;
            b.Pages = 120;
        }
        static void Main(string[] args)
        {
            int score = 20;
            int score2 = score;
            //init syntax book
            Book b = new Book
            {
                Title="this is the book title",
                Description="This is a book description",
                Pages=90,
            };
            Console.WriteLine(b.Display());
            Book b2 = b;
            Console.WriteLine(b2.Display());
            b2.Pages = 1111;
            DoSomething2(score,b);
            //Exercise course
            Point p = new Point();
            p.x = 10;
            p.y = 10;
            
            Point p2 = new Point(10, 10,PointColor.Gold);
            //Traditional syntax
            Rectangle r2 = new Rectangle();
            r2.bottom = p;
            //Init syntax
            Rectangle r = new Rectangle
            {
                topLeft = new Point { x = 10, y = 10 },
                bottom = new Point { x=20,y=20},

            };
            
             
            Moyenne m = new Moyenne();
            m.a = 5;
            m.b = 6;
            m.DoSomething();


        }
    }
    class Rectangle
    {
        public Point topLeft = new Point();
        public Point bottom = new Point();
      
    }

    //Test structs
    public struct Moyenne
    {
        public int a;
        public int b;
        //public Moyenne()
        //{

        //}
        public void DoSomething()
        {
            Console.WriteLine(a + b);
            Console.ReadKey();
        }
    }
}
