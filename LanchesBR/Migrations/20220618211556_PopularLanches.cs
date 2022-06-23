using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesBR.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco)" +
                "VALUES(1, 'Pão, hambúrguer, ovo, presunto, queijo e batata palha', 'Delicioso pão de hambúrger com ovo frito, preseunto e queijo de primeira qualidade acompanhado de batata palha', 1,'https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic.clubedaanamariabraga.com.br%2Fwp-content%2Fuploads%2F2016%2F11%2Fx-salada-classico-1024x576.jpg&imgrefurl=https%3A%2F%2Fanamariabraga.globo.com%2Freceita%2Fxsalada-hamburguer-com-creme-de-queijo-misto-quente-e-milk-shake%2F&tbnid=nlwRaBlqeh_tQM&vet=12ahUKEwivwdaE-Lf4AhVFN7kGHXOIBs4QMygFegUIARDZAQ..i&docid=93FnfZYgyjfNGM&w=1024&h=576&q=cheese%20salada&hl=pt-BR&ved=2ahUKEwivwdaE-Lf4AhVFN7kGHXOIBs4QMygFegUIARDZAQ', 'https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic.clubedaanamariabraga.com.br%2Fwp-content%2Fuploads%2F2016%2F11%2Fx-salada-classico-1024x576.jpg&imgrefurl=https%3A%2F%2Fanamariabraga.globo.com%2Freceita%2Fxsalada-hamburguer-com-creme-de-queijo-misto-quente-e-milk-shake%2F&tbnid=nlwRaBlqeh_tQM&vet=12ahUKEwivwdaE-Lf4AhVFN7kGHXOIBs4QMygFegUIARDZAQ..i&docid=93FnfZYgyjfNGM&w=1024&h=576&q=cheese%20salada&hl=pt-BR&ved=2ahUKEwivwdaE-Lf4AhVFN7kGHXOIBs4QMygFegUIARDZAQ', 0, 'Cheese Salada', 12.50)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco)" +
                "VALUES(2, 'Pão integral, alface, tomate e creme de frango', 'Delicioso pão integral com alface, tomate e nosso espetacular creme de frango', 1,'https://www.google.com/imgres?imgurl=https%3A%2F%2Fimg.cybercook.com.br%2Freceitas%2F971%2Fsanduiche-natural-de-frango-2.jpeg&imgrefurl=https%3A%2F%2Fcybercook.com.br%2Freceitas%2Faves%2Fsanduiche-natural-de-frango-5971&tbnid=7CJeESbzU9nGGM&vet=12ahUKEwjX1ebv-Lf4AhVlMLkGHYcvBz8QMygAegUIARD3AQ..i&docid=tRC7augIWL2_zM&w=1400&h=799&q=sanduiche%20natural&hl=pt-BR&ved=2ahUKEwjX1ebv-Lf4AhVlMLkGHYcvBz8QMygAegUIARD3AQ', 'https://www.google.com/imgres?imgurl=https%3A%2F%2Fimg.cybercook.com.br%2Freceitas%2F971%2Fsanduiche-natural-de-frango-2.jpeg&imgrefurl=https%3A%2F%2Fcybercook.com.br%2Freceitas%2Faves%2Fsanduiche-natural-de-frango-5971&tbnid=7CJeESbzU9nGGM&vet=12ahUKEwjX1ebv-Lf4AhVlMLkGHYcvBz8QMygAegUIARD3AQ..i&docid=tRC7augIWL2_zM&w=1400&h=799&q=sanduiche%20natural&hl=pt-BR&ved=2ahUKEwjX1ebv-Lf4AhVlMLkGHYcvBz8QMygAegUIARD3AQ', 0, 'Sanduiche natural de frango', 10.50)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
