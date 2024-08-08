// See https://aka.ms/new-console-template for more information

using EncapsulationPractice;

public class Program
{
    public static void Main(string[] args)
    {
        // user get input
        Console.WriteLine("Lutfen Kapi Sayisini Giriniz: ");
        int doorNumber = Convert.ToInt32(Console.ReadLine());

        // create car object
        Araba araba = new Araba();
        //door property value
        araba.DoorNumber = doorNumber;
        


    }
}