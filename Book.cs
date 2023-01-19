using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp__looping
{
    class Book
    {
        List<int> price = new List<int>();
        int bill = 0;
        public  void AddBookPrice(int p)
        {
            price.Add(p);
            
        }
        public int TotalBill()
        {
            foreach (int p in price) 
            {
                bill = p + bill;
            }
            return bill;  
        }
        public char Badge(int bill)
        {
            switch (bill)
            {
                case var l when l > 500:
                    return 'A';

                case var l when l > 200:
                    return 'B';

                case var l when l > 100:
                    return 'C';
                default:
                    return 'D';
            }
        }
            public void Badge(char A)
            {
                switch (A)
                {
                    case'A':
                        Console.WriteLine("platinum user");
                        break;
                    case 'B':
                        Console.WriteLine("Golden user");
                        break;
                    case 'C':
                        Console.WriteLine("Silver user");
                        break;
                    default:
                        Console.WriteLine("Normal user");
                        break;
                }

            } 

    }
}
