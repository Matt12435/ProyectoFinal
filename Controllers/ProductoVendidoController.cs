﻿using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Controllers.DTOS;

namespace ProyectoFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ProductoVendidoController : ControllerBase
    {
        //  GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   GET   


        [HttpGet(Name = "TraerProductosVendidos")]
        public List<ProductoVendido> TraerProductosVendidos_conIdUsuario(long idUsuario)
        {
            return ProductoVendidoHandler.TraerProductosVendidos_conIdUsuario(idUsuario);
        }
    }
}
