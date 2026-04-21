using System;

class Animal
{
    
        //public string respira
        public string ruido;
        
        static void respirar()
        {
            Console.WriteLine("los animales respiran");
        }
        public void accion()
        {
            Console.WriteLine( "y " + ruido);
        }
        
        static void Main ()
        {
            Animal Pez = new Animal();
            Animal Perro = new Animal();
            Animal Gato = new Animal();
            
            Pez.ruido="los peces nadan";
            Perro.ruido="los perros ladran";
            Gato.ruido="los gatos maullan";
            
            
            Animal.respirar();
            Pez.accion();
            Perro.accion();
            Gato.accion();
        }
}


