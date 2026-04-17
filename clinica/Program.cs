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