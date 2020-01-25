using System;

namespace Entidades
{
    public class Leao:BaseAnimal
    {
        //sobrescrever emitir som de BaseAnimal
         public override void EmitirSom(){
            Console.WriteLine("ARrrrrr;");
        }
        
    }
}
