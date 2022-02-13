namespace Sistema {

    public class Pessoa {

        // atributos
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public int Idade { get; private set; }
        public long Telefone { get; set; }

        // construtores
        public Pessoa(string Nome, string Sobrenome, int Idade) {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Idade = Idade;
        }

        public Pessoa(string Nome, string Sobrenome, int Idade, long Telefone) : this(Nome, Sobrenome, Idade) {
            this.Telefone = Telefone;
        }

        // getters and setters  

        // métodos



        // equals 
        public override string ToString() {
            string aux = $"Nome: {Nome} {Sobrenome}\n"
                     + $"Idade: {Idade} anos\n";

            if ( Telefone > 0 ) aux += $"Telefone: {Telefone}\n";                 

            return aux;
        }

    }
}
