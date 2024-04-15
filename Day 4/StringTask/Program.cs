// Q1. Create 2 string variable and accept data from user.
// Using equals and == check data entered by user is same or not.
// Print gethashcode for both string .variable
// Also use referenceEquals and observe out put.

class Program{

    static void Main(string [] args){
    string str1;
    string str2;

    str1=Console.ReadLine();
    str2=Console.ReadLine();

    Console.WriteLine(str1.Equals(str2));
    Console.WriteLine(str1==str2);
    Console.WriteLine(str1.GetHashCode());
    Console.WriteLine(str2.GetHashCode());
    Console.WriteLine(Object.ReferenceEquals(str1,str2));
    Console.ReadLine();
    }


}