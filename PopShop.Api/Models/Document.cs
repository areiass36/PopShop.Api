namespace PopShop.Api.Models;

public class Document
{
    /*public User User { get; set; }*/
    public DocumentType Type { get; set; }
    public string Value { get; set; } = string.Empty;
}

public enum DocumentType
{
    Undefined = 0,
    CPF = 1,
    CNPJ = 2
}

