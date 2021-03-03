namespace AppConsultaCep.Library.Models
{
    public class Endereco
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string unidade { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }

        public override string ToString()
        {
            return "CEP: " + this.cep +
                "\nLogradouro: " + this.cep +
                "\nComplemento: " + this.cep +
                "\nBairro: " + this.cep +
                "\nLocalidade: " + this.cep +
                "\nUF: " + this.cep +
                "\nUnidade: " + this.cep +
                "\nIBGE: " + this.cep +
                "\nGIA: " + this.cep;
        }
    }
}