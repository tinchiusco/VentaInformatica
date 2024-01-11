using System;
using VentaInformatica;

class Program 
{
    static void Main(string[] args) {

        Usuario usuarioVacio = new();
        Usuario usuarioCargado = new(4,"Juan","Perez","juape","prueba123","jp007@gmail.com");

        Producto productoVacio = new();
        Producto productoCargado = new(1,"GForce GTX 2080", 180000,250000,5,1);

        ProductoVendido productoVendidoVacio = new();
        ProductoVendido productoVendidoCargado = new(1, 1, 5, 1);

        Venta ventaVacia = new();
        Venta ventaCargada = new(1,"Sin garantia", 1);

        Console.WriteLine("Resumen de usuario cargado \nID: {0}\nNombre: {1}\nApellido: {2}\nNombre de Usuario: {3}\nMail: {4}\n---------------------------------------------------------"
            , usuarioCargado.Id, usuarioCargado.Nombre, usuarioCargado.Apellido, usuarioCargado.NombreUsuario,usuarioCargado.Mail);

        Console.WriteLine("Resumen producto cargado \nId producto: {0}\nDescripcion: {1}\nCosto: {2}\nPrecio de venta: {3}\nStock: {4}\nId de Usuario: {5}\n---------------------------------------------------------",
            productoCargado.Id,productoCargado.Descripcion,productoCargado.Costo,productoCargado.PrecioVenta,productoCargado.Stock,productoCargado.IdUsuario);

        Console.WriteLine("Resumen producto vendido \nId producto vendido: {0}\nId de producto: {1}\nStock: {2}\nId de venta: {3}\n---------------------------------------------------------",
            productoVendidoCargado.Id, productoVendidoCargado.IdProducto,productoVendidoCargado.Stock, productoVendidoCargado.IdVenta);

        Console.WriteLine("Resumen venta \nId: {0}\nComentarios: {1}\nId Usuario: {2}\n---------------------------------------------------------",
            ventaCargada.Id,ventaCargada.Comentarios,ventaCargada.IdUsuario);

        Console.WriteLine("Comprobacion de objetos vacios: ");

        if (usuarioVacio != null) Console.WriteLine("Existe un usuario vacio");
        
        if (productoVacio != null) Console.WriteLine("Existe un producto vacio");

        if (productoVendidoVacio != null) Console.WriteLine("Existe un producto vendido vacio");

        if (ventaVacia != null) Console.WriteLine("Existe una venta vacia");

        Console.ReadKey();
    }
}
