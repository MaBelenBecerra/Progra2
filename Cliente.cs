public class Cliente
{
    protected string Nombre;
    protected string Direccion;
    protected List<Producto> Carrito;
    protected List<ItemFactura> factura;

    public Cliente(string nombre, string direccion)
    {
        Nombre = nombre;
        Direccion = direccion;
        Carrito = new List<Producto>();
        factura = new List<ItemFactura>();
    }

    public void AgregarAlCarrito(Producto producto)
    {
        Carrito.Add(producto);
        añadir_a_factura(producto);
        producto.Stock(-1);
    }

    public void QuitarDelCarrito(Producto producto)
    {
        Carrito.Remove(producto);
        producto.Stock(1);
    }

    public void añadir_a_factura(Producto producto)
    {
        //if 
        // producto in carrito  cantidad+1
        //else 
        factura.Add(new ItemFactura (producto.Nombre, producto.Descuento(), 1));
        
    }
    public void quitar_de_factura(Producto producto)
    {
        //if 
        // producto in carrito  cantidad-1
        //else 
        factura.Remove(new ItemFactura (producto.Nombre, producto.Descuento(), 1));
        
    }
    public void ImprimirFactura()
    {
        double total = 0;
        foreach (var item in factura)
        {
            Console.WriteLine($"Producto: {item.NombreProducto}, Precio Unitario: {item.PrecioUnitario}, Cantidad: {item.Cantidad}\n");
            total+= item.PrecioUnitario;
        }
        Console.WriteLine($"Total: {total}");
    }
}