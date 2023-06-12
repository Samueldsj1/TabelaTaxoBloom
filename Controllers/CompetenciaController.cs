using Microsoft.AspNetCore.Mvc;
using WebAppBloom.Models;
using WebAppBloom.Viewmodels;

namespace WebAppBloom.Controllers;
public class CompetenciaController:Controller{
 public  IActionResult Index(){
 Competencia competencia = new Competencia();
 competencia.ColunaBloom = "Memorizar";
 competencia.LinhaBloom = "Listar";
 ViewData["titulo"]= "Compreender o funcionamento";
 ViewData["tablebloom"]= competencia;
    return View();
 }
 public IActionResult RelatorioComp(){
   var competencia = new Competencia(){
      ColunaBloom = "Teste Column",
      LinhaBloom = "Teste Row"
   };
   var viewModel = new DetalhesCompViewModel(){
      Competencia = competencia,
      TituloPagina = "Pag Teste"
   };
   return View(viewModel);
 }   
}