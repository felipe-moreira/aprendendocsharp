using System;
using Entidades;
using System.Collections.Generic;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            List <BaseAnimal> animais = new List<BaseAnimal>();
            animais.Add(new Leao());
            animais.Add(new Tigre());

            for (int i = 0;i<animais.Count; i++)
                animais[i].EmitirSom();

        }
    }
}
