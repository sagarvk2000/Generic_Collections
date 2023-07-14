using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Coll
{
    public class Product
    {
        public string name { get; set; }
        public int id { get; set; }
        public long price { get; set; }

        public string Printd()
        {
            return $"{name},{id},{price}";
        }
        static void Main(string[] args)
        {//using list in generic collections

            //List<Product> p2 = new List<Product>();
            // p2.Add(new Product { id = 1, name = "mobile", price = 25000 });
            // p2.Add(new Product { id = 2, name = "tab", price = 5000 });
            // p2.Add(new Product { id = 3, name = "phone", price = 35000 });

            //// p2.AddRange(p2);
            // p2.Insert(0, new Product { id = 4, name = "Laptop", price = 6000 });
            // p2.Remove(p2[2]);
            // foreach (Product p in p2)
            // {
            //     Console.WriteLine(p.name,p.id,p.price);
            // }

            //using generic stack
            //Stack<Product> p4 = new Stack<Product>();
            //p4.Push(new Product{ id = 88, name = "mouse", price = 900 });
            //p4.Push(new Product { id = 8, name = "monitor", price = 500 });
            //p4.Push(new Product { id = 98, name = "box", price = 400 });

            //p4.Pop();

            //foreach (Product p5 in p4)
            //{
            //    Console.WriteLine($"{p5.id},{ p5.name},{ p5.price}");
            //}

            Queue<Product> q = new Queue<Product>();
            q.Enqueue(new Product { id=2,name="x",price=600});
            q.Enqueue(new Product { id = 7, name = "z", price = 6600 });
            q.Enqueue(new Product { id = 6, name = "y", price = 7800 });

            q.Dequeue();

            foreach (var item in q)
            {
                Console.WriteLine($"{item.id},{item.name},{item.price}");
            }

            //List<int> p1 =new List<int>();
            //p1.Add(4);
            //p1.Add(5);
            //p1.Insert(2, 54);
            //p1.Remove(4);
            // p1.AddRange(p1);
            //foreach (var item in p1)
            //{
            //    Console.WriteLine("\n"+item);
            //}

            //Stack<int> s = new Stack<int>();
            //s.Push(10);
            //s.Push(20);
            //s.Push(30); 

            //s.Pop();
            //s.Peek();

            //foreach (var item in s)
            //{
            //    Console.WriteLine(item);
            //}

            //using queue in generic
            Queue<int> q2 = new Queue<int>();    
            q2.Enqueue(1);
            q2.Enqueue(2);
            q2.Enqueue(3);

            q2.Dequeue();

            foreach (var item in q2)
            {
                Console.WriteLine(item);
            }

            //List<string> s1 = new List<string>();
            //s1.Add("sagar");
            //s1.Add("pankaj");
            //s1.Add("pratik");
            //s1.Insert(3, "nilesh");
            //s1.Remove("pankaj");
            ////s1.AddRange(s1);
            //foreach (string item in s1)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack<string> s3 = new Stack<string>();

            //s3.Push("Sagar");
            //s3.Push("pankaj");
            //s3.Push("pratik");

            //s3.Pop();

            //foreach (var item in s3)
            //{
            //    Console.WriteLine(item);
            //}

            Queue<string> q1 = new Queue<string>();

            q1.Enqueue("s");
            q1.Enqueue("a");
            q1.Enqueue("b");

            q1.Dequeue();

            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }

        }


    }
}
