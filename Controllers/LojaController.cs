using Microsoft.AspNetCore.Mvc;
using Avaliacao3bim.ViewModels;
namespace Avaliacao3bim.Controllers;

public class LojaController : Controller
{
   private static List<LojaViewModel> lojas = new List<LojaViewModel>();
    
    public IActionResult Index(){
        return View();
   }
   public IActionResult Cadastrar(){
     return View();
   }
   public IActionResult Salvar([FromForm] int id, [FromForm] string piso, [FromForm] string nome, [FromForm] string descricao, [FromForm] string definicao, [FromForm] string email){
    
    foreach (LojaViewModel var in lojas)
        {
            if (var.Nome == nome || var.Id == id)
            {
                return View("Fail");
            }
        }
        lojas.Add(new LojaViewModel(id, piso, nome, descricao, definicao, email));
        return View("Cadastrar");
   }
   
   public IActionResult Show(){
        return View(lojas);
   }
   public IActionResult DetalhesLoja(int id){
        return View(lojas[id-1]);
   }
   public IActionResult Delete(int id){
     lojas.Remove(lojas[id-1]);
     
     return View(lojas[id-1]);
   }
}