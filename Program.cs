﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class Editoriales // Hace parte de la información del libro y el admi ingresa los datos de la editorial 
{

    public int id {get; set;} // identificador de la editorial 
    public string? nombre {get; set;} // información de la editorial 
    public string? correo {get; set;} // información de la editorial, este atriburo se agrego para la entrega dos 
   
}

public class Generos  // Hace parte de la información del libro y el admi ingresa los datos del genero del libro  
{

    public int id {get; set;}// identificador del genero
    public string? nombre {get; set;} // información del genero
    public string? descripción {get; set;} // información del genero, este atriburo se agrego para la entrega dos 
}

public class Autores  // Hace parte de la información del libro y el admi ingresa los datos del Autor del libro 
{

    public int id {get; set;}// identificador del autor 
    public string? nombre {get; set;} // información del autor
    
    public string? apellido {get; set;} // información del autor
    
}

public class Roles  // Hace parte de la información del Usuario y el admi asigna el rol 
{

    public int id {get; set;} // identificador del rol del usuario 
    public string? nombre {get; set;} // información del rol
    public string? descripción {get; set;} // información del rol, este atriburo se agrego para la entrega dos 
    
}

public class Prestamos  // contiene la información del prestamo y el admi ingresa los datos 
{

    public int id {get; set;} // identificador del prestamo 

    public string? codigo {get; set;} // identificador del DUDDDDDDAAAA
    public DateTime fecha_prestamo {get; set;} // fecha en la que se realizo el prestamo 
    public DateTime fecha_devolucion {get; set;} // fecha en la que se debe entregar el libro 
    public Usuarios? id_usuarios {get; set;} // identificador de usuarios 

}

public class Libros  // contiene la información del libro y el admi ingresa los datos 

{

    public int id {get; set;} // identificador del libro 
    public string? titulo {get; set;} // Nombre del libro 
    public int cantidad {get; set;} // cantidad de libros que hay disponibles
    public Boolean estado {get; set;} // si el libro se encuentra o no disponible 
    public DateTime año_publicacion {get; set;} // fecha en la que se publico el libro DUDA SI PONER DATETIME 
    public Editoriales? id_editores {get; set;}  // identificador de la editorial 

}


public class Prestamos_Libros  // entidad que relaciona la entidad prestamos y la entidad libros, además tiene la fecha en la que se entrega el libro 
{

    public int id {get; set;} // identificador del prestamo del libro  
    public DateTime fecha_devolucion {get; set;} // fecha de entrega del libro 
     public int id_libros {get; set;}
    public Libros? _id_libros {get; set;} // identificador del libro 
    public Prestamos? id_prestamos {get; set;}  // identificador del prestamo 
    
}

public class Libros_Autores  // entidad que relaciona la entidad libros y la entidad autores
{

    public int id {get; set;} // identificador del autor del libro 
    public Libros? id_libros {get; set;} // identificador del libro 
    public Autores? id_Autores {get; set;}  // identificador del prestamo 
    
}

public class Libros_Generos  // entidad que relaciona la entidad libros y la entidad generos
{

    public int id {get; set;} // identificador del genero del libro 
    public Libros? _id_libros {get; set;} // identificador del libro 
    public Generos? _id_generos {get; set;}  // identificador del genero 
    
}

public class Usuarios   // contiene la información del usuario y el admi ingresa los datos 

{

    public int id {get; set;} // identificador del usuario 
    public string? nombre {get; set;} // información del usuario 
    public string? apellido {get; set;} // información del usuario 
    public string? correo {get; set;} // información de contacto del usuario 
    public string? telefono {get; set;} // información de contacto del usuario 
    public int id_roles {get; set;}
    public Roles? _id_roles {get; set;} // identificar del rol 
    
}








