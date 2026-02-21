using System;

public class BOOK
{
    private string title;
    private string author;
    private int pages;
    private bool open;

    public BOOK()
    {
        title = "La Aventura de Ser Inventor";
        author = "Eduardo Torrijos";
        pages = 128;
        open = true;
    }
    public void ShowInfo()
    {
        Console.WriteLine("Titulo: " + title);
        Console.WriteLine("Autor: " + author);
        Console.WriteLine("Paginas: " + pages);

        if (open==true)
        {
            Console.WriteLine("El libro esta: Abierto");
        }
        else
        {
            Console.WriteLine("El libro esta: Cerrado");
        }

       
    }


    public static void Main()
    {
        BOOK book = new BOOK();

        book.ShowInfo();

    }
}
