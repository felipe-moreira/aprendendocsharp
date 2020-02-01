
using System;

namespace Entidades
{
    public class Aguia:BaseAnimal
    {
        //sobrescrever emitir som de BaseAnimal
         public override void EmitirSom(){
            Console.WriteLine("SomAguia;");
        }
        
    }
}
