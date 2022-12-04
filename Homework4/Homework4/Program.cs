using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Mcoplexnum();
            Mbool(5);
            Nsadeyoxsamurekkeb(3);
            Nmsum(4, 2);
            DoorWardrobe(100, 200, 300, 54, 833, 90);
        }
        static int Mcoplexnum()
        {
            int []m = {1,2,3,43,12,57,10 };
            int result = 1;
            for (int i = 0; i < m.Length; i++)
            {
                int n=m [i];
              
                if ( n%2==0)
                {
                    result *= n;
                }
            }
            Console.WriteLine(result);
            return result;
        }
        static bool Mbool(int m)
        {
            if (m%2==0)
            {
                Console.WriteLine("m is complex");
            }
            
            else
            {
                Console.WriteLine("m is single");
            }
            return false;
        }
          static void Nsadeyoxsamurekkeb(int n)
          {
            if (n%2==0 && n!=2)
            {
                Console.WriteLine("n murekkebdir");
            }
            else
            {
                Console.WriteLine("n sadedir");
            }
          }
        static int Nmsum(int n,int m)
        {
            
            if (n%2==0 && m%2==0)
            {
                Console.WriteLine(n+m);
            }
            else
            {
                Console.WriteLine("hamisi cut eded olamlidir");
            }
            return (n + m);
        }
        static void DoorWardrobe(int wardrobheight,int wardrobelength,int wardrobeweight,int doorheight,int doorlength,int doorweight)
        {
            if (wardrobelength<doorlength || wardrobeweight<doorweight|| wardrobheight<doorheight)
            {
                Console.WriteLine("oke wardrobe entered");
            }
            else
            {
                Console.WriteLine("oh no, dont enter");
            }
        }

    }
}
