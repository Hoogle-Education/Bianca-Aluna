
namespace Drafts {

    public class Program {
        public static void Main( ) {

            Console.Write("Coloque n: ");
            int n = int.Parse(Console.ReadLine());

            int[] fib = new int[n+1];

            fib[0] = 1;
            fib[1] = 1;
    
            // 1 1 2 3 5 8 13 21

            for (int i = 2; i <= n; i++) {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            foreach(int value in fib){
                Console.WriteLine($"value = {value}");
            }

            Console.ReadLine();
        }
    }
}

