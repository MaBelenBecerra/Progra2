public class Producto
{
    public string Nombre;
    public double Precio;
    public int Identificador;
    public int Stock;
    public Categoria Categoria;

    public Producto(string nombre, double precio, int identificador, int stock, Categoria categoria)
    {
        Nombre = nombre;
        Precio = precio;
        Identificador = identificador;
        Stock = stock;
        Categoria = categoria;
    }

    public void agregar_stock(int n)
    {
        Stock += n;
    }

    public double Descuento()
    {
        return Precio * (1 - Categoria.Descuento);
    }

    public int get_stock(){
        return Stock;
    }
}