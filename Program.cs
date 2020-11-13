using System;

namespace TestQuestion
public class test1  
{  
  public static void Main(string) args)
   {
     Console.WriteLine(SumTriple(9,9));
     Console.WriteLine(SumTriple(17,11));
     Console.WriteLine(SumTriple(-8,9));
   }
    public static int SumTriple(int a, int b)
   
   {
    return a == b ? (a + b) * 1 : a + b;
  }
}