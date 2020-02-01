using System;

namespace Entidades
{
    public class Urso:BaseAnimal
    {
        //sobrescrever emitir som de BaseAnimal
         public override void EmitirSom(){
            Console.WriteLine("SomUrso;");
        }
        
    }
}
