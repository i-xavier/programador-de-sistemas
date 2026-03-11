using classeheranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeheranca
{
    //Classe base (superclasse)

    internal class Animal
    {
        // Propriedade da classe Animal
        public string Nome {get; set; }

        // Método que será sobrecarregado nas classes derivadas
        public virtual void EmitirSom()
        {
            
            Console.WriteLine("O animal emite um som.");

        }
    }

    // Classe derivada (subclasse)

    internal class Cachorro : Animal 
    {
        // Sobrescrevendo o método EmitirSom
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} late: Au Au!");
        }

    }

    //Outra classe derivada
    internal class Gato : Animal
    {
        // Sobrescrevendo o método EmitirSom
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} mia: Miau!");
        }
    
    }
}


internal class Prgram
{
    static void Main(string[] args)
    {
        //Criando instâncias das classes derivadas
        Animal meuGato = new Gato { Nome = "Cérebero"};
        Animal meuCachorro = new Cachorro {Nome = "Pink"};

        // Chamando o método EmitirSom para cada animal
        
        /*meuGato.EmitirSom();
        meuCachorro.EmitirSom();*/


        //Utilizando Polimorfismo: Array de animais
        Animal[] animais = {meuCachorro, meuGato};

        foreach (var animal in animais)
        {
            animal.EmitirSom();
        }

    }
}