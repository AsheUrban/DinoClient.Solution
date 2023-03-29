using Microsoft.AspNetCore.Mvc;
using DinoClient.Models;

namespace DinoClient.Controllers;

public class AnimalsController : Controller
{
  public IActionResult Index()
  {
    List<Animal> animals = Animal.GetAnimals();
    return View(animals);
  }
}