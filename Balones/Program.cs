Console.WriteLine("Hello, World!");

Balones balon = new Balones();

balon.id = 1;
balon.peso = 5;
/*balon.FechaCreacion = DateTime.now;*/
balon.Marca = new Marcas() { Id = 1, Nombre = "adidas" };
balon.deporte = new Deportes() { Id = 1, Deporte = "Baloncesto" };
balon.estadoBalon = new EstadosBalon() {Id = 1, Estado = "En perfectas condiciones"};

Console.WriteLine(balon.id);
Console.WriteLine(balon.Marca.Nombre);
Console.WriteLine(balon.deporte.Deporte);
Console.WriteLine(balon.estadoBalon.Estado);

public class EstadosBalon
{
    public int Id;
    public string? Estado;
}
public class Deportes
{
    public int Id;
    public string? Deporte;

}
public class Balones
{
    public int id;
    public decimal peso;
    /*public DateTime FechaCreacion;*/
    public Marcas? Marca;
    public Deportes? deporte;
    public EstadosBalon? estadoBalon;

}
public class Marcas
{
    public int Id;
    public string? Nombre;

}
