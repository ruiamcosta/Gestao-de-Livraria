namespace Gestao_de_Livraria.Communication.Request;

public class RequestRegisterBookJson
{
    public string Author { get; set; } = string.Empty;

    public Genre BookGenre{ get; set; } 

    public double Price { get; set; }

    public int StockQuantity { get; set; }
}
