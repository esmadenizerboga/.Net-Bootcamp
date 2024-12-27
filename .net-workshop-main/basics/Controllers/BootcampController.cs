using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class BootcampController : Controller{

    public IActionResult Index(){

        var bootcamp = new Bootcamp();
        bootcamp.Id = 1;
        bootcamp.Title = "Aspnet Core Workshop";
        bootcamp.Description = "Workshop 35 klişi ile pazar günü başladı.";
        bootcamp.Image = "1.png";
        return View(bootcamp);
    }
    public IActionResult Details(int id){

        var bootcamp = Repository.GetById(id);
        return View(bootcamp);
    }
    public IActionResult List(){
        return View(Repository.Bootcamps);
    }
}