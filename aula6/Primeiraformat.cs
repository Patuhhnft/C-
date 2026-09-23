using System;

class Aula06
{
    static void Main()
    {
        // int n1,n2,n3;

        // n1=10; n2=20; n3=30;

        // // Console.Write("N1={0}, N2={1}, N3={2}",n1,n2,n3);
        // Console.Write("\nN1=\t{0} \nN2=\t{1} \nN3=\t{2}",n1,n2,n3);

        double ValorCompra = 5.50;
        double ValorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        ValorVenda = ValorCompra + (ValorCompra * lucro);

        Console.WriteLine("Produto........:{0,15}", produto);
        Console.WriteLine("Val.Compra........:{0,15:c}", ValorCompra);
        Console.WriteLine("Lucro........:{0,15:p}", lucro);
        Console.WriteLine("Val.Venda........:{0,15:c}", ValorVenda);
    }
}