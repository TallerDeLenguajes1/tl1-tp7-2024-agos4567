using EspacioCalculadora;
using System;
using System.Security.Cryptography;


namespace Myapp
   {
    class Program
    {
        static void Main(string[] args){


            Calculadora cal1= new Calculadora();
            cal1.suma(500);
            // Console.WriteLine(cal1.Resultado);

          double num;
          bool valido=false;

          string entrada;

          int opcion;
          int op=0;

              

        do
        {
            op=1;
            
                 do
                 {
                     Console.WriteLine("Ingrese el primer numero: ");
                entrada=Console.ReadLine();

                valido=double.TryParse(entrada, out num);


                Console.WriteLine("Ingresa la operaciona  realizar \n-1suma\n 2-resta\n 3-multiplicacion\n 4-division\n 5 limpiar\n");
                entrada=Console.ReadLine();
                valido=int.TryParse(entrada,out opcion);

                 switch (opcion)
                 {
                    
                   case 1:
                   Console.WriteLine("El resultado de la suma es");
                   cal1.suma(num);
                   Console.WriteLine(cal1.Resultado);
                   break;


                    case 2:
                   Console.WriteLine("El resultado de la resta es");
                   cal1.resta(num);
                   Console.WriteLine(cal1.Resultado);
                   break;

                   case 3:
                  Console.WriteLine("El resultado de la multiplicacion es");
                   cal1.multiplicacion(num);
                   Console.WriteLine(cal1.Resultado);
                   break;

                 case 4:
                 Console.WriteLine("El resultado de la division es");
                   cal1.dividir(num);
                   Console.WriteLine(cal1.Resultado);
                 break;
                

                case 5:
               cal1.Limpiar(num);
               Console.WriteLine(cal1.Resultado);
                break;



                   default:
                   break;
                   
                 }


                     if(!valido){
                            Console.WriteLine("el numero ingresado no es valido");
                        }


                 } while (!valido);


                      

            Console.WriteLine("Desea realizar otra operacion (1.SI/ 0.NO)");
            op=Convert.ToInt32(Console.ReadLine());
        } while (op !=0);



        }
    }
   }