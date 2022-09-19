namespace Avaliacao3bim.ViewModels;

public class LojaViewModel
{
    public int Id { get; set; }
    public string  Piso { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string Definicao {get; set; }
    public string Email {get; set; }  



    public LojaViewModel(int id, string piso, string nome, string descricao, string definicao, string email){
        Id = id;
        Piso = piso;
        Nome = nome;
        Descricao = descricao;
        Definicao = definicao;
        Email = email;
    }
}