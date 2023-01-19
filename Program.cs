using c_sharp__looping;
using System;
namespace c_sharp_looping
{
    public class loop
    {
        public static void Main(String[] args)
        {
            Book b = new Book();
            Boolean f = true;
            while (f != false)
            {
                Console.WriteLine("Enter the grades or enter 0 if wants to quite");

                var input = Console.ReadLine();
                var pr = int.Parse(input);
                if (pr == 0)
                {
                    break;
                }

                b.AddBookPrice(pr);
            }
            int re = b.TotalBill();
            Console.WriteLine(re);
            char c=b.Badge(re);
            Console.WriteLine(c);

            b.Badge(c);




            


        }
       
            

    }
        
}
