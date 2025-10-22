using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_API_Produtos.Data;
using Web_API_Produtos.Models;

namespace Web_API_Produtos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ProdutoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<ProdutoModel> BuscarProdutos()
        {
            var produtos = _context.Produtos.ToList();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        //forma opcional de fazer o que está ocorrendo acima [Route("id")]
        public ActionResult<List<ProdutoModel>> BuscarProdutoPorId(int id)
        {
            var produto = _context.Produtos.Find(id);
            if (produto == null)
            {
                return NotFound("Produto não encontrado!");
            }
            return Ok(produto);
        }

        [HttpPost]
        public ActionResult<ProdutoModel> CadastrarProduto(ProdutoModel produtoModel)
        {
            if (produtoModel == null)
            {
                return BadRequest("Ocorreu um erro no cadastro!");
            }

            _context.Produtos.Add(produtoModel);
            _context.SaveChanges();

            //status code = 201 (algo foi criado no DB), busco o id e passo o id de onde vou estar buscando o objeto, depois coloca o produto model completo
            return CreatedAtAction(nameof(BuscarProdutoPorId), new { id = produtoModel.Id }, produtoModel);
        }

        [HttpPut("{id}")]
        //ou colocar o httpput normal e depois [Route("{id}")]
        public ActionResult<ProdutoModel> EditarProduto(ProdutoModel produtoModel, int id)
        {
            var produto = _context.Produtos.Find(id);
            if (produto == null)
            {
                return NotFound("Produto não encontrado!");
            }

            produto.Nome = produtoModel.Nome;
            produto.Descricao = produtoModel.Descricao;
            produto.QuantidadeEstoque = produtoModel.QuantidadeEstoque;
            produto.CodigoDeBarras = produtoModel.CodigoDeBarras;
            produto.Marca = produtoModel.Marca;

            _context.Produtos.Update(produto);
            _context.SaveChanges();

            return Ok("Produto editado com sucesso!");
        }

        [HttpDelete("{id}")]
        //ou oôr o httpput normal e depois [ROUTE("{id}")]
        public ActionResult<ProdutoModel> DeletarProduto(int id)
        {
            var produto = _context.Produtos.Find(id);

            if(produto == null)
            {
                return NotFound("Produto não encontrado!");
            }

            _context.Produtos.Remove(produto);
            _context.SaveChanges();

            return Ok("Produto removido com sucesso!");
        }

    }
}
