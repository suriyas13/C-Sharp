using System;
namespace suriya;
class A{
    string s;
    int n,m;
    int[,] a=new int[10,10];
    public void getarray(int n,int m)
    {
        int i,val,j;
        for(i=0;i<n;i++){
            for(j=0;j<m;j++){
                val=Convert.ToInt32(Console.ReadLine());
                a[i,j]=val;
            }
        }
    }
    public void printarray(int n,int m){
        Console.WriteLine("The array Elements are:");
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                Console.Write(" "+a[i,j]);
            }
        
        Console.WriteLine();
        }
    }

}
class jag{
    int n,m;
    int[][] arr=new int[2];
    arr[0]=new int[3];
    arr[1]=new string[2];
    public getjagarray(int n,int m){
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
                val=Convert.ToInt32(Console.ReadLine());
                a[i,j]=val;
            }
        }
    }
}
class B{
    public static void Main(string[] args)
    {
        A obj= new A();
        Console.WriteLine("Enter the size of array row:");
        int n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the size of array column:");
        int m=Convert.ToInt32(Console.ReadLine());
        obj.getarray(n,m);
        obj.printarray(n,m);

    }
}