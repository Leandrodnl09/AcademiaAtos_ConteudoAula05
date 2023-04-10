namespace AcademiaAtos_ConteudoAula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Estruturas de repetição,  for - whilw - do-while;
            for(int i = 0; i <= 10; i ++) 
            {
                Console.WriteLine(i);
            }

            // Algoritmo que mostre todos os números de 20 a 5.
            for (int i = 20; i >= 5; i--)
            {
                Console.WriteLine(i);
            }

            // Algoritmo que mostra os numeros entre inicio e fim que o osuario ira digitar;
            Console.Write("Digite o valor de início: ");
            int inicio = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de fim: ");
            int fim = int.Parse(Console.ReadLine());

            Console.WriteLine("Números entre " + inicio + " e " + fim + ":");

            if(inicio > fim)
            {
                for (int i = inicio; i <= fim; i++)
                {
                    Console.Write(i + ", ");
                }
            }
            if (inicio < fim)
            {
                for (int i = inicio; i <= fim; i--)
                {
                    Console.Write(i + ", ");
                }
            }

            Console.WriteLine("Digite um valor inteiro para x:");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 100; i += x)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("Digite um valor inteiro para x:");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 100; i++)
            {
                if(1 % x == 0)
                Console.WriteLine(i);
            }

        }
    }
}