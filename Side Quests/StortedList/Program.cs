class myClass{
    static void Main(string[] args){
        SortedList<char,char> sl=new SortedList<char, char>();
        string str="vidyanidhi";
        char[] ch=str.ToCharArray();

        foreach(char c in ch){
            try{
                sl.Add(c,c);
            }catch{}
        }
         foreach(KeyValuePair<char,char>  c in sl){
           System.Console.WriteLine(c);
        }
        
    }
}