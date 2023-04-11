var num = 0;
var maior = 0;
var menor = 10000;

do
{
    Console.WriteLine("Informe um numero(0 para sair):");
    num= int.Parse(Console.ReadLine());
   if (num > maior)
       maior = num; 
   else if (num < menor)
       menor = num;


   if (num == 0)
    {
        Console.WriteLine($"O maior numero é {maior}");
        Console.WriteLine($"O menor numero é {menor}");
        
    }
   
} while(num != 0);
    