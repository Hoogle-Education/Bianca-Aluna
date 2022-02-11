namespace Sistema {

    public class Escola {
        public static int Main(string[] args) {

            Pessoa joao = new("Joao", "da Silva", 17);
            Pessoa maria = new("Maria", "Joaquina", 25, 98888887);

            joao.Nome = "Marcelo";

            Console.WriteLine(joao.ToString() );
            Console.WriteLine(maria);

            return 0;
        }
    }

}