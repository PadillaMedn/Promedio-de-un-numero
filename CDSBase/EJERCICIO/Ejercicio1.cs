


/*
 * 
    TEXTO EXPLICATIVO PARA EL JOVEN
  
  */

//Aqui se declara la estructura que contiene tu programa
public partial class ProgramaController
{
    //Tu programa
    void MiPrograma(double[] valor)
    {
        //ESCRIBE AQUI TU CODIGO, DESPUES DEL { QUE INDICA EL INICIO 
        
        double pro = 0;
        double porc = 0;
        double media = 0;
        double suma = 0;
        for (int i = 0; i <=valor.Length-1; i++)
        {

            suma =suma+ valor[i];

            pro = suma / 6;

            media = suma / 6;


            porc = (pro + suma) / 100;
            if (valor[i] >pro)
            {
                double mayores = valor[i];
                ImprimirTexto(mayores);
            }


            

        }

       ImprimirTexto($" El promedio es: {pro} , La media es: {media} , porcentaje es {porc}");

       
       

        

        //FINAL DE TU PROGRAMA, INDICADO POR EL CORCHETE CERRADO }
    }
}



/*
 * 
  NOTAS ACERCA DEL USO DEL DEPURADOR
  
     * 
     * // NOTAS IMPORTANTES :
// Los caracteres // indican comentarios
// Un ; indica el final de una instrucción* 
 * 
 */
