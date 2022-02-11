namespace Sistema {

    public class Pessoa {

        private string Nome;
        private string Sobrenome;
        private int Idade;
        private long Telefone;

        public Pessoa(string nome, string sobrenome, int idade) {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        public Pessoa(string nome, string sobrenome, int idade, long telefone) : this(nome, sobrenome, idade) {
            Telefone = telefone;
        }        

        public override string ToString() {
            string aux = $"Nome: {Nome} {Sobrenome}\n"
                     + $"Idade: {Idade} anos\n";

            if ( Telefone > 0 ) aux += $"Telefone: {Telefone}\n";                 

            return aux;
        }

    }
}
