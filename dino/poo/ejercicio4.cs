public class Producto
{
    //Atributos
    private int id;
    private string nombre;
    private string descripcion;
    private double precio;
    private int stock;
    private string modelo;
    private string marca;
    //constructor vacio
    public Producto()
    {
        id = 0;
        descripcion = "default";
        precio = 0;
        stock = 0;
        nombre = "default";
        modelo = "default";
        marca = "default";
    }
    //constructor con chucherias
    public Producto(int id, string nombre, string descripcion, double precio, int stock, string modelo, string marca)
    {
        this.id = id;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.precio = precio;
        this.stock = stock;
        this.modelo = modelo;
        this.marca = marca;
    }

    public int id
    {
        get { return id; }
        set { id = value; }
    }

    public string nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string descripcion
    {
        get { return descripcion; }
        set { descripcion } = value;
    }
}

public double precio
{
    get { return precio; }
    set { precio = value; }
}

public int stock
{
    get { return stock; }
    set { stock = value; }
}

public string modelo
{
    get { return modelo; }
    set { modelo = value; }
}

public string marca
{
    get { return marca; }
    set { marca = value; }
}

//methodo
public void aumentarStock(int cantidad)
{
    if (cantidad <= 0)
        Console.WriteLine("F! Se cayo el sistema de ceibal!");
    else
        stock += cantidad;
}
//methodo
public void reducirStock(int cantidad)
{
    if (cantidad > stock && cantidad <= 0)
        Console.WriteLine("F! Tu stock esta fuera de la realidad.");
    else
        stock -= cantidad;
}

public double calcularPrecioTotal(int cantidad)
{
    //double
    int cantidad = stock - cantidad[-1];
    double stock = precioTotal - stock;
    return precioTotal;
}

//algo 
public string Descripcion
{
    get { return descripcion; }
    //set { descripcion = value; }
}

}

public class Electrodomestico : Producto
{

    double prosentajesumado = precioTotal + 0.1;

    //private int mesesDeGarantia;

    public int MesesDeGarantia
    {
        get { return mesesDeGarantia; }
    }

    public Electrodomestico(int id, string descripcion, string nombre, double precio, double prosentajesumado, int stock, string modelo, string marca, int mesesDeGarantia) : base(id, descripcion, precio, stock, modelo, marca)
    {
        this.mesesDeGarantia = mesesDeGarantia;
    }
}

public class Electronica : Producto
{
    double porsentajesumado = precioTotal + 0.3;
    private string sistemaOperativo;

    public string SistemaOperativo
    {
        get { return sistemaOperativo; }
    }

    public Electronica(int id, string descripcion, string nombre, double precio, double prosentajesumado, int stock, string modelo, string marca, string sistemaOperativo) : base(id, descripcion, precio, stock, modelo, marca)
    {
        this.sistemaOperativo = sistemaOperativo;
    }
}
