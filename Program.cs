using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

class Program
{
    static void Main(string[] args)
    {
        Nokia nokia = new Nokia("11-9999-9999", "g11", "12345678", 128);

        Console.WriteLine(nokia);

        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Linkedìn");


        Iphone iphone = new Iphone ("11-8888-8888", "15", "12345698", 256);

        Console.WriteLine(iphone);

        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
        
    }
}
