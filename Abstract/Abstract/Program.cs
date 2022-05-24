using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        public Program()
        {

        }
        ~Program()
        {

        }
        static void Main(string[] args)
        {

            Console.WriteLine("hello this is the demo");

            int num1 = 10;
            int num2 = 10;
            int num3 = num1 + num2;
            Console.WriteLine(num3);
            opps obj = new opps();
            Console.WriteLine(obj.sum(12, 39));
            Console.WriteLine(obj.sum(23.9, 39.3));
            //Program b=new Program();
            obj.JustOverRide();
            //==========================
            Console.WriteLine("this is the user class ...");


            user user = new user("Anirudh Singh", 22);
            user.Perform_abstractions("rahul singh");
            user.userinfo();
            user.GetUserDetails();

            Console.ReadKey();
        }
    }
}
