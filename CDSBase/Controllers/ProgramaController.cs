using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;


public partial class ProgramaController : Controller
{
    #region CODIGO INTERNO
    
    public ActionResult Index()
    {
        if (Request.HttpMethod == "POST")
        {

            double[] valor;
            valor = new double[6];
            valor[0] = LeerValor1();
            valor[1] = LeerValor2();
            valor[2] = LeerValor3();
            valor[3] = LeerValor4();
            valor[4] = LeerValor5();
            valor[5] = LeerValor6();

            //Aqui es donde se ejecuta tu programa cuando le das click al botón
            MiPrograma(valor);


        }
        return View();
    }


    /// <summary>
    /// IMPRIME UNA LINEA EN LA PARTE RESULTADOS DEL PROGRAMA
    /// </summary>
    /// <param name="linea"></param>
    [DebuggerStepThrough]
    void ImprimirTexto(object linea)
    {
        ViewBag.Texto1 += linea.ToString();
    }

    [DebuggerStepThrough]
    double LeerValor1()
    {
        double result;
        double.TryParse(Request["numero1"], out result);
        return result;
    }

    [DebuggerStepThrough]
    double LeerValor2()
    {
        double result;
        double.TryParse(Request["numero2"], out result);
        return result;
    }

    [DebuggerStepThrough]
    double LeerValor3()
    {
        double result;
        double.TryParse(Request["numero3"], out result);
        return result;
    }
    [DebuggerStepThrough]
    double LeerValor4()
    {
        double result;
        double.TryParse(Request["numero4"], out result);
        return result;
    }
    [DebuggerStepThrough]
    double LeerValor5()
    {
        double result;
        double.TryParse(Request["numero5"], out result);
        return result;
    }

    [DebuggerStepThrough]
    double LeerValor6()
    {
        double result;
        double.TryParse(Request["numero6"], out result);
        return result;
    }

    [DebuggerStepThrough]
    string LeerValorCadena1()
    {
        //Aquí iría el nombre del control que recibirá la cadena
        // Ejemplo Request["cadena1"]
        return "";
    }

    [DebuggerStepThrough]
    string LeerValorCadena2()
    {
        //Aquí iría el nombre del control que recibirá la cadena
        // Ejemplo Request["cadena2"]
        return "";
    }

    #endregion
        
}
