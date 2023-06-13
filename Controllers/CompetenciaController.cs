using Microsoft.AspNetCore.Mvc;
using WebAppBloom.Models;
using WebAppBloom.Viewmodels;
using WebAppBloom.Contexts;

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
   private readonly AppDbContext _context;
   //declara uma variável privada do tipo AppDbContext chamada _context. 
   //O modificador readonly indica que o valor dessa variável só pode ser atribuído durante a inicialização ou em um construtor.

 public CompetenciaController(AppDbContext context){
 //criando um construtor para injetar uma dependencia.
 _context = context;

 
 }
 
 public IActionResult RelatorioComp(){
   // var competencia = new Competencia(){
   //    ColunaBloom = "Teste Column",
   //    LinhaBloom = "Teste Row"
   // };
   // var viewModel = new DetalhesCompViewModel(){
   //    Competencia = competencia,
   //    TituloPagina = "Pag Teste"
   // };
      var competencias = _context.Competencias.ToList();

   return View();
 }   
}