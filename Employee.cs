using System;
namespace Actividades;

public class Employee
{
public string Name;
public string Category;
public int ID;
public float Salary;

public Employee() { }
//Profe, esto del contructor vacio me lo explico la IA que lo necistaba para poder poner lo datos del empleado 
//usando el metodo GetInfo y GetSalary, pero no se si es correcto o no, si no lo es, por favor me lo explica, gracias.

public Employee(string name, string category, int id, float salary)//Constructor para parametros los datos del empleado
{
    this.Name = name;
    this.Category = category;
    this.ID = id;
    this.Salary = salary;
}

public void GetInfo()//Para obterner info del empleado
{
    Console.WriteLine("Cual es tu nombre?");
    Name = Console.ReadLine();

    Console.WriteLine("Cual es tu categoria?");
    Category = Console.ReadLine();

    Console.WriteLine("Cual es tu ID?");
    ID = int.Parse(Console.ReadLine());
}

public float GetSalary() //Para obtener el salario del empleado
{
    Console.WriteLine("Cual es tu salario?");
    Salary = float.Parse(Console.ReadLine());
    return Salary;
}

public void ShowInfo()
{
    Console.WriteLine("Nombre: " + Name + 
                      " | Categoria: " + Category + 
                      " | ID: " + ID + 
                      " | Salario: " + Salary);
}

static void Main(string[] args)
{
    Console.WriteLine("Cuantos empleados quieres ingresar?");
    int n = int.Parse(Console.ReadLine());

    Employee[] employees = new Employee[n];
    float suma = 0;

    for(int i = 0; i < n; i++)
    {
        employees[i] = new Employee();
        employees[i].GetInfo();
        suma += employees[i].GetSalary();
    }

    float promedio = suma / employees.Length;

    Console.WriteLine("\nPromedio de salarios: " + promedio);
    Console.WriteLine("\nEmpleados que ganan menos que el promedio:");

    for(int i = 0; i < employees.Length; i++)
    {
        if(employees[i].Salary < promedio)
        {
            employees[i].ShowInfo();
        }
    }
}
}