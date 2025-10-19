namespace Web_API_Produtos.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty; //Evita que o campo seja nulo
        public string Descricao { get; set; } = string.Empty;
        public int QuantidadeEstoque { get; set; }
        public string CodigoDeBarras { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
    }
}
