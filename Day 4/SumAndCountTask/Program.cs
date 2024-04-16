// Write a method which will return sum of digit and using out variable let it send count of digit also.
// Eg. input 123  return(6) in out variable (3)

class SumAndDigit{
    public static int SumAndDigits(int n,out int length){
        int count=0;
        int sum=0;
        while(n>0){
            int digit=n%10;
            sum=sum+digit;
            n/=10;
            count++;
        }
        length=count;
        return sum;
    }
}
public class Program{
    static void Main(string[] args){
        int length=0;
       int sum= SumAndDigit.SumAndDigits(123,out length);
        Console.WriteLine(string.Format("Sum={0} Digits={1}",sum,length));
    }
}
