using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogoAPI.Migrations
{
    public partial class PopularProduto : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
            "values ('Suco de laranja', 'Suco natural', 4.0, 'suco-laranja.jpg', 10, getdate(), 1)");

            mb.Sql("insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
            "values ('Coca Cola', 'Refrigerante de cola 350ml', 6.0, 'coca-cola.jpg', 15, getdate(), 1)");

            mb.Sql("insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
            "values ('Biscoito', 'Biscoito de chocolate 200g', 4.50, 'biscoito-chocolate.jpg', 5, getdate(), 2)");

            mb.Sql("insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
            "values ('Sorvete', 'Sorvete de creme com passas 300ml', 25.0, 'sorvete-creme-passas.jpg', 5, getdate(), 3)");

            mb.Sql("insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
            "values ('Pudim', 'Pudim 150g', 4.0, 'pudim.jpg', 10, getdate(), 3)");

            mb.Sql("insert into Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
            "values ('Brigadeiro', 'Brigadeiro', 2.0, 'brigadeiro.jpg', 50, getdate(), 3)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("delete from Produtos");
        }
    }
}
