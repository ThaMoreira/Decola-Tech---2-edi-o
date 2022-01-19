
namespace Interface
{
    interface IAnimal
    {
        void Nome(string nome);
        void Dono(string nomeDono);
    }

    class Animal: IAnimal
    {
        public string Nome { get; set; }
        public string NomeDono { get; set; }

        void IAnimal.Nome(string nome)
        {
            this.Nome = nome;
        }

        void IAnimal.Dono(string nomeDono)
        {
            this.NomeDono = nomeDono;
        }

    }
}
