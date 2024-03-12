/*
    Tienda con linea de productos de categorias:
    Electronica, ropa, libros

    Cada producto tiene nombre, precio, identificador unico y stock(cant)
    en el inventario

    Los clientes tienen su nombre, direccion y un carrito con su lista de productos

    Se necesita un sistema de descuentos que se aplique a
    diferentes categorias de productos

    El sistema debe generar una factura por cada compra
*/
using System.Text;
using System;


Categoria electronica = new Categoria("Electrónica", 0.1);
Categoria ropa = new Categoria("Ropa", 0.05);
Categoria libros = new Categoria("Libros", 0.15);

Cliente cliente = new Cliente("Juan", "Calle Principal");

Producto producto1 = new Producto("Smartphone", 500, 1, 10, electronica);
Producto producto2 = new Producto("Camiseta", 20, 2, 20, ropa);
Producto producto3 = new Producto("Libro", 15, 3, 15, libros);

cliente.AgregarAlCarrito(producto1);

cliente.AgregarAlCarrito(producto2);
cliente.AgregarAlCarrito(producto3);

cliente.QuitarDelCarrito(producto1);

//cliente.ImprimirFactura();  
Console.WriteLine(producto1.get_stock());

/*

A todos los requerimientos agregar
Para la tienda:
- Comprar productos por lotes (Grupos/Paquetes)
- La tienda vende por paquete o por unidad

Para el cliente
- La compra puede guardarse y continuar en otra fecha
- Debe informar si los productos estan o no disponibles


usar herencia
puede necesitar carrito

*/