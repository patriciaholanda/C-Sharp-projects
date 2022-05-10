using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogoAPI.Migrations
{
    public partial class PopularCategoria : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into Categorias(Nome, ImagemUrl) values ('Bebidas', 'bebidas.jpg')");
            mb.Sql("insert into Categorias(Nome, ImagemUrl) values ('Lanches', 'lanches.jpg')");
            mb.Sql("insert into Categorias(Nome, ImagemUrl) values ('Sobremesas', 'sobremesas.jpg')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("delete from Categorias");
        }
    }
}
