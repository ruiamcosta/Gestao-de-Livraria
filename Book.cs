namespace Gestao_de_Livraria;

public class Book
{
    public int Id { get; set; }
    
    public string Author { get; set; } = string.Empty;

    public Genre BookGenre{ get; set; }

    public double Price { get; set; }
    
    public int StockQuantity { get; set; }

}
