using System;
using System.Collections.Generic;
using System.Text;


namespace EmpresaConsola
{

    


//agregamos un nuevo enum para saber si la tarea esta realizada, se esta realizando o esta pendiente
 public enum Cargo
 {
    // Pendiente =0,
    // Haciendo=2,
    // Concluida=3
    Auxiliar=0,
    Administrativo=1,
    Ingeniero=2,
    Especialista=3,
    Investigador=4,

 }


    public class Empleados
    {
       private string? nombre; 

       private string? apellido; 

       private DateTime fechaDeN;
       private char estadoCivil;
       private char genero;  

       private DateTime fechaDeI;


       private double sueldoBasico;

     


        // private int edad; 
        // private string nombreDeTareas;
        
        // EstadoTarea estado;

    //   public persona(string nom, string ap){
    //    nombre=nom;
    //    apellido=ap;



    //   }




        private Cargo cargos;

        public string? Nombre {get; set; }
        //    public string Nombre {
        //      get {return nombre;} 
        //      set {nombre =value;}
        //      }
        public string? Apellido {get; set; }
        public DateTime FechaDeN { get; set; }
        public char EstadoCivil { get; set; }
        public char Genero { get; set; }
        public DateTime FechaDeI { get; set; }
        public double SueldoBasico { get; set; }
        public Cargo Cargos { get; set; }

        // public Cargo Cargos { get; set; }




        public int calcularEdad(DateTime FechaDeN){

             int edad = DateTime.Now.Year - FechaDeN.Year;
            return edad;
         }


         public int calcularAntiguedad(DateTime FechaDeI){
         

         int antiguedad=DateTime.Now.Year - FechaDeI.Year;


         return antiguedad;




         }


         public double calcularSalario(double sueldoBasico, DateTime FechaDeI, Cargo Cargos, char estadoCivil){
       double sueldoTotal=0;

          if (calcularAntiguedad(FechaDeI) <20)
          {
            sueldoTotal= sueldoBasico + (sueldoBasico*0.01*(calcularAntiguedad(FechaDeI)));
          }else
          {
            sueldoTotal= sueldoBasico + (sueldoBasico*0.25);
          }
          if (Cargos == Cargo.Ingeniero || Cargos== Cargo.Especialista )
          {
            sueldoTotal= sueldoTotal *1.5;
          }

          if (estadoCivil =='c' || estadoCivil=='C')
          {
            sueldoTotal= sueldoTotal +15000;
          }


          return sueldoTotal;


         }
      

         public int calcularJubilacion(char genero, DateTime FechaN){
           int jubilacion=0;
          
           
           if (genero == 'f' || genero=='F') 
           {
           jubilacion = 60 -  calcularEdad(FechaN); 

             return jubilacion;

           }else 
           {
            jubilacion= 65 -  calcularEdad(FechaN);

            return jubilacion;
           }
            

        }


        // public int Importancia { get => importancia; set => importancia = value; }
        // public string NombreDeTareas { get => nombreDeTareas; set => nombreDeTareas = value; }




        // public string Nombre1 { get => Nombre; set => Nombre = value; }
        // public EnumCargo Estado { get => estado; set => estado = value; }
    }
}