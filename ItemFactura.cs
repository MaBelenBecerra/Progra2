public class ItemFactura
{
    public string NombreProducto;
    public double PrecioUnitario;
    public int Cantidad;

    public ItemFactura(string nombreProducto, double precioUnitario, int cantidad)
    {
        NombreProducto = nombreProducto;
        PrecioUnitario = precioUnitario;
        Cantidad = cantidad;
    }
    
}
