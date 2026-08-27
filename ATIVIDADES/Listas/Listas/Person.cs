// Person.cs

// Aqui, criamos uma clase de tipo de dado
// abstrato

using System.Dynamic;

public class Person
{
    public string Name {get; set;}
    public int Age {get; set;}
    public CountryEnum Nationality {get; set;}
}

// Enum = Enumerador
// Difere de Classe. É uma lista de valores
public enum CountryEnum
{
    
    BR, US, AR, PY
}