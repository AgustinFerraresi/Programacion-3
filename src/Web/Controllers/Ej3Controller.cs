using Microsoft.AspNetCore.Mvc;

namespace Web;

[ApiController]
[Route("[controller]")] //decorador 
public class Ej3Controller : ControllerBase //controller
{

    //metodo  (puede haber mas de un metodo por controller)
    [HttpGet]//decorador  
    public string Get(string nombre, int edad)
    {
        return $"tu nombre es {nombre} y tenes {edad}";
    }
    //
}
