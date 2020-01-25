using System;

namespace Entidades
{
    public class BaseAnimal
    {
    public int Id {get;set;}
    public int QuantidadeDePatas{get;set;}

    public virtual void EmitirSom(){
        Console.WriteLine("Sem Som.");
    }


    }
}
