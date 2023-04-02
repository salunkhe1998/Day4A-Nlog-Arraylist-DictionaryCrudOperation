using NlogDemo3;
using System.Collections.Generic;

namespace NlogDemo3
{
    public class Program
    {
            public static void Main(string[] args)
            {
                Console.WriteLine("Welcome to NLog Configuration,Arraylist and Dictionary CRUD operation!");
                Console.WriteLine("Select any one Option for Opreration");
                Console.WriteLine("\n 1. For Nlog Config Example. \n 2. CRUD operation on ArrayList.");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Adding.Sum(10, 5);
                        break;
                    case 2:
                        ArraylistCRUD.ArraylistOperation();
                        break;

                }
            }
        }
    }