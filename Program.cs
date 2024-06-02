using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using EmpresaConsola;




namespace Empresas
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<Tarea> ListaDeDatos=new List<Tarea>(); //COLECCION

Empleados[] empleado = new Empleados[3];
DateTime[] antiguedad = new DateTime[3];
DateTime[] edad = new DateTime[3];
 int[] edadTotal = new int[3];
 int[] antiguedadTotal = new int[3];
 double[] sueldoTotal=new double[3];
 int[] jubilacion = new int[3];
 double[] montoTotal=new double[3];


            
            string salida="";
            bool valido=false;
            string? nom="";
            string? ape="";
            string? texto="";
            char genero=' ';
            char estadoC=' ';

  
    for (int i = 0; i < 3; i++)
    {
    
             empleado[i] = new Empleados();
              valido =false;
             
                 while (!valido)
                 {
                     Console.WriteLine("Ingrese el nombre del empleado:");

                     nom=Console.ReadLine();
                    
                    if (nom== null)
                    {
                          Console.WriteLine("Nombre invalido");
                    }else
                    {
                         valido=true;
                 }
                      }

                       empleado[i].Nombre=nom;
                     valido =false;
         
                    while (!valido){


                    Console.WriteLine("Ingrese el apellido del empleado:");

                    ape=Console.ReadLine();
                    
                    if (ape== null)  {
                                      
                     Console.WriteLine("Apellido invalido");                       
                     }else {   
                        valido=true;                                 
                      }                                         
                                                           
                  

                    }
                    
                     
                    
                    empleado[i].Apellido=ape;
           
                    valido =false;
                    // // Option 1.
                    // // The Console.ReadLine() function returns a string.
                    // string strDob = Console.ReadLine();
                    // DateTime? dob1 = strDob.();

                        DateTime Dob;
                       Console.WriteLine("Ingrese su fecha de nacimiento DD/MM/YYYY:");

                        //accepts date in MM/dd/yyyy format
                        Dob = DateTime.Parse(Console.ReadLine());

                         empleado[i].FechaDeN=Dob;



                     DateTime Dob2;
                       Console.WriteLine("Ingrese su fecha de ingreso DD/MM/YYYY:");

                        //accepts date in MM/dd/yyyy format
                        Dob2 = DateTime.Parse(Console.ReadLine());

                         empleado[i].FechaDeI=Dob2;

                    while (!valido)
                    {
                          Console.WriteLine("Ingrese el género del empleado (f/femenino) - (m/masculino) - (o/otro)");
                    texto = Console.ReadLine();
                        valido = char.TryParse(texto, out genero);




                        if (genero =='F' || genero=='M' || genero=='f' || genero=='m'|| genero=='o' || genero=='O')
                        {
                           empleado[i].Genero=genero;
               

                        }else
                        {
                            Console.WriteLine("error al ingresar el genero");
                        }
                      
                    }
                          valido=false;
       
                          while (!valido)
                    {
                    Console.WriteLine("Ingrese el estado civil c:casado / v:viudo / d:divorciado / s:soltero ");
                    texto = Console.ReadLine();
                        valido = char.TryParse(texto, out estadoC);

                        
                        
                        if (estadoC=='c' || estadoC =='C' || estadoC=='v' || estadoC== 'V' || estadoC== 'd' || estadoC=='D' || estadoC=='s' || estadoC=='S')
                        {
                           empleado[i].EstadoCivil=estadoC;
                        }else
                        {
                            Console.WriteLine("error el ingresar el estado");
                        }

                    }
                          
                    
                      valido=false;
                        


            Console.WriteLine("Ingrese el sueldo basico:");

              double sueldoB=Convert.ToDouble(Console.ReadLine());
                            
                 empleado[i].SueldoBasico=sueldoB;
         

                Console.WriteLine("Ingrese el estado: ((1=Auxiliar) - (2=Administrativo) -  (3=Ingeniero) - (4=Especilista) - (5=Especialista))");

               int state=Convert.ToInt32(Console.ReadLine());

              switch (state)
              {
                case 1: 
                   empleado[i].Cargos= Cargo.Auxiliar;
            
                
                break;


                case 2:
                   empleado[i].Cargos= Cargo.Administrativo;
            
                
                break;


                case 3:
                   empleado[i].Cargos= Cargo.Ingeniero;
            
                
                break;

                case 4:
                   empleado[i].Cargos= Cargo.Especialista;
                
                break;

                case 5:
                   empleado[i].Cargos= Cargo.Investigador;
                
                break;
                default:
                 Console.WriteLine("Cargo no valido");
                break;
              }
              
    }



double montoTotalAcumulado = 0;

    for (int i = 0; i < 3; i++)
    {
        
              edadTotal[i] = empleado[i].calcularEdad(empleado[i].FechaDeN);
               antiguedadTotal[i]=empleado[i].calcularAntiguedad(empleado[i].FechaDeI);
               sueldoTotal[i]=empleado[i].calcularSalario(empleado[i].SueldoBasico, empleado[i].FechaDeI, empleado[i].Cargos, empleado[i].Genero);
                jubilacion[i]=empleado[i].calcularJubilacion(empleado[i].Genero ,empleado[i].FechaDeN);
        
                 Console.WriteLine(empleado[i].Nombre + " - " + empleado[i].Apellido );
                 Console.WriteLine(empleado[i].FechaDeN);
                  Console.WriteLine("Su sueldo basico es " + empleado[i].SueldoBasico);
                  Console.WriteLine(empleado[i].Genero);
                  Console.WriteLine(empleado[i].EstadoCivil);
                  Console.WriteLine(empleado[i].Cargos);
                 Console.WriteLine("Su edad es : " + edadTotal[i]);
                 Console.WriteLine("Su antiguedad es : " + antiguedadTotal[i]);
                 Console.WriteLine("El sueldo total es :" + sueldoTotal[i]);
                 Console.WriteLine("Falta para su jubilacion : " +  jubilacion[i]);
                 montoTotal[i]+=sueldoTotal[i];
                 montoTotalAcumulado+=montoTotal[i];
        
               Console.WriteLine("- - - - - - - - - - -"); 
    
    }



                //  Console.WriteLine("EMPLEADO MAS PROXIMO ES:");
             
 
    int empleadoConMayorAntiguedad = 0;
    for (int j = 1; j < 3; j++)
    {
        

        if (antiguedadTotal[j] >= antiguedadTotal[empleadoConMayorAntiguedad])
        {
        
            empleadoConMayorAntiguedad = j; // Actualizamos el índice del empleado con mayor antigüedad
        }
    
    }
          Console.WriteLine("El empleado más próximo es:");
        Console.WriteLine(empleado[empleadoConMayorAntiguedad].Nombre + " - " + empleado[empleadoConMayorAntiguedad].Apellido);
        Console.WriteLine(empleado[empleadoConMayorAntiguedad].FechaDeN);
        Console.WriteLine("Su sueldo básico es " + empleado[empleadoConMayorAntiguedad].SueldoBasico);
        // Otros detalles del empleado...

        Console.WriteLine("Su edad es: " + edadTotal[empleadoConMayorAntiguedad]);
        Console.WriteLine("Su antigüedad es: " + antiguedadTotal[empleadoConMayorAntiguedad]);

        Console.WriteLine("El monto TOTAL ACUMULADO es "+ montoTotalAcumulado);

        }
    }
}


