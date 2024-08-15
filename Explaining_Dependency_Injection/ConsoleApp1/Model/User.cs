namespace ConsoleApp1.Model
{
    public class User
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public User(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
