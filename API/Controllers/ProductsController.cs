using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    //public IActionResult Index()
    //{
    //    return View();
    //}

    [HttpGet]
    public string GetProduct()
    {
        return "this will be a list of products!";
    }


    [HttpGet("{id}")]
    public string GetProduct(int id)
    {
        return $"this will return a product with id: {id}!";
    }

}