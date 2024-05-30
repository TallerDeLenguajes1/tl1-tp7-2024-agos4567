using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;


  namespace EspacioCalculadora
  {
    public class Calculadora
    {
        //Al definir Resultado de esta manera, es una forma segura y controlada de acceder al valor de dato sin permitir que sea modificado desde fuera de la clase, respetando el principio de encapsulación en la programación orientada a objetos.
          private double dato;

      
        public double Resultado { get => dato;}
        //Cuando se defina una propiedad con solo el get, estás indicando que la propiedad es de solo lectura. Esto significa que puedes obtener (leer) el valor del atributo, pero no puedes modificarlo directamente a través de la propiedad.

         public void suma (double sumando){
           dato+=sumando;

         }
         
         public void resta (double sustraendo){
            dato -=sustraendo;
         }

          public void multiplicacion (double multiplicacion){

            dato *=multiplicacion;
          }

          public void dividir (double divisor){


            string entrada;
            bool valido=false;
              
              if (divisor ==0)
              {
                do
                {
                    Console.WriteLine("el divisor debe ser distinto de cero, ingrese otro divisor");
                    entrada=Console.ReadLine();
                    valido=double.TryParse(entrada,out divisor);
                    
                } while (divisor ==0 || !valido);
              }

               dato /=divisor;

          }


         public void Limpiar(double dato){
            dato=0;
         }


         
    }
  }