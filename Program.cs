using System;

namespace ComandosDowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean condicao = true;
            int valor;

            do{
            Console.WriteLine("DIGITE UM VALOR, 0 PARA SAIR");
            valor = int.Parse(Console.ReadLine());

                if(valor ==0){
                   Console.WriteLine(" Você saiu da aplicação ");
                   condicao = false;
                }
                 else{
                 Console.WriteLine("o valor informado é: "+ valor);

                } 
            }while(condicao == true);

        }    
    }
}