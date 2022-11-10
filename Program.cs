using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBootcampEjerc
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
// Ejercicio 
// Estructura de datos para un cliente

Cliente miCliente = new Cliente
(
    "Esteban Alday",
    525355610,
    "c\ Jose Rivas 33",
    "ealday@email.com",
    true
);
Console.WriteLine(miCliente);

public struct Cliente
{
    public Cliente(String nombre, int telefono, string direccion, string correo, bool nuevo)
    {
        name = nombre;
        phone = telefono;
        address = direccion;
        email = correo;
        isNew = nuevo;
    }

    public string name { get; set; }
    public int phone { get; set; }
    public string address { get; set; }
    public string email { get; set; }
    public bool isNew { get; set; }

    public override string ToString() => $"{name}, {phone}, {address}, {email}, {isNew}";
}