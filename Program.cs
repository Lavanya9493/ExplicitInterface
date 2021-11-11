using System;

interface I1
{
    void InterfaceMethod();
}
interface I2
{
    void InterfaceMethod();
}
class Myclass:I1,I2
{
   void I1.InterfaceMethod()
   {
       Console.WriteLine("I1 InterfaceMethod");
   }
   void I2.InterfaceMethod()
   {
       Console.WriteLine("I2 InterfaceMethod");
   }
}
class Program
{
    public static void Main(string[] args)
    {
        I1 i1=new Myclass();
        I2 i2=new Myclass();
        i1.InterfaceMethod();
        i2.InterfaceMethod();
    }
}

