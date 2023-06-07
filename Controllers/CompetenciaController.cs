using Microsoft.AspNetCore.Mvc;
using WebAppBloom.Models;
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
}