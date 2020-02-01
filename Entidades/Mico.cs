using System;

namespace Entidades
{
    public class Mico:BaseAnimal
    {
        //sobrescrever emitir som de BaseAnimal
         public override void EmitirSom(){
            Console.WriteLine("SomMico");
        }
        
    }
}
