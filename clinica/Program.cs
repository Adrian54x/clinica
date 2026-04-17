bool val;
Console.WriteLine("--Ingrese los datos del paciente--");
Console.Write("Nombre:");
string nombre = Console.ReadLine();
Console.Write("DPI:");
long dpi;
do
{ 
    val = long.TryParse(Console.ReadLine(), out dpi);
    if(!val)
    {
        Console.WriteLine("Caracteres no validos");
    }
} while (!val);
Console.Write("Telefono:");
int telefono;
Console.Write("Edad:");
int edad;

Cliente c = new Cliente(nombre,dpi,telefono,edad);

class Cliente
{
	private string nombre;
    private long dpi;
    private int telefono;
    private int edad;

    public Cliente(string Nombre,long Dpi, int Telefono, int Edad)
    {
        this.Nombre = Nombre;
        this.Dpi = Dpi;
        this.Telefono = Telefono; 
        this.Edad = Edad;
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"\nNombre:{nombre} \nDPI:{dpi} \nTelefono:{telefono}\nEdad:{edad}");
    }

    public string Nombre
    {
		get { return nombre; }
		set 
        {
            if (value.Length >= 3)
            {
                nombre = value;
            }
            else
            {
                Console.WriteLine("Nombre no valido!");
            }
        }
	}

    public long Dpi

    {
        get { return dpi; }
        set 
        {
            if (value.ToString().Length >= 13)
            {
                dpi = value;
            }
            else
            {
                Console.WriteLine("Dpi no valido!");
            }
        }
    }

    public int Telefono

    {
        get { return telefono; }
        set 
        {
            if (value.ToString().Length == 8)
            {
                telefono = value;
            }
            else
            {
                Console.WriteLine("Telefono no valido!");
            }
        }
    }

    public int Edad

    {
        get { return edad; }
        set 
        {
            if (value > 0)
            {
                edad = value;
            }
            else
            {
                Console.WriteLine("Edad no valida!");
            }
        }
    }
}