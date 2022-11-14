//----------------------SESIÓN 1---------------------

//Ejercicio 1
/*
string nombre = "Ezequiel Lorenz";
Console.WriteLine(nombre);

//Ejercicio 2

DateTime FechaHoy = DateTime.Now;
Console.WriteLine(FechaHoy.ToString());*/

//----------------------SESIÓN 2---------------------

//Ejercicio 1
Console.WriteLine("Ingresa tu nombre");
string nombre = Console.ReadLine();
Console.WriteLine("Ingresa tu apelido");
string apellido = Console.ReadLine();
Console.WriteLine("Ingresa tu edad");
string edad = Console.ReadLine();
bool programar = false;
while(programar == false)
{
    Console.WriteLine("Sabes programar? S por si - N por no");
    string sabeProgramar = Console.ReadLine();

    if (sabeProgramar == "S" || sabeProgramar == "s")
    {
        programar = true;
    }
    else if (sabeProgramar == "N" || sabeProgramar == "n")
    {
        programar = false;
    }
    else
    {
        Console.WriteLine("Ingrese un valor correcto");
        programar = false;
    }
}


string mensaje = "Hola,tu nombre completo es: " + nombre + " " + apellido + " Tu edad es de: " +
    " Sabes programar: " + Convert.ToString(programar);
Console.WriteLine(mensaje);

//Ejercicio 2

    int puerta;
    int ruedas;
    string marca;
    bool ITV;

    decimal peso;
    decimal largo;
    string material;
    string color;


//Ejercicio 3
int numero = 20;
char letra = 'a';
bool condicion;
if (numero >= 18)
    condicion = true;
if(letra == 'a')
    condicion = true;
if (numero >= 10 && letra == 'a')
{
    condicion = true;
}
if (numero >= 10 || letra == 'a')
{
    condicion = true;
}