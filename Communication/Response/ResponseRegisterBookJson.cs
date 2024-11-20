using System.Text.Json.Serialization;

namespace Gestao_de_Livraria.Communication.Response;

public class ResponseRegisterBookJson
{
    public int Id { get; set; }

    public string Author { get; set; } = string.Empty;

    public Genre BookGenre { get; set; }

    public double Price { get; set; }

    public int StockQuantity { get; set; }
}
