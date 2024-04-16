namespace MyApp{

    public class Program{
        static void Main(string [] args){
            MyCalc cal=new MyCalc();
            System.Console.WriteLine("Hello");
            // cal.dojob(); //inaccessible method beacuse of internal access modifier
        }
    }
}