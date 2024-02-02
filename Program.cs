using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;

namespace ejercicio1Fecha
{

    class Program
    {

        static void Main(string[] args)
        {
            //CREACION
            DateTime fechaHoy = DateTime.Now;

            //Para sacar todo los formatos de la cultura española que contengan la palabra "Pattern"
            DateTimeFormatInfo infoFormatoCulturaEspecifica = CultureInfo.GetCultureInfo("es-SP").DateTimeFormat;
            Type tipo = infoFormatoCulturaEspecifica.GetType();
            PropertyInfo[] propiedadesFormatos = tipo.GetProperties();
            foreach (var propiedad in propiedadesFormatos)
            {
                if (propiedad.Name.Contains("Pattern"))
                {
                    string formato = propiedad.GetValue(infoFormatoCulturaEspecifica, null).ToString();
                    Console.WriteLine(propiedad.Name + ": " + formato + " " +
                                      fechaHoy.ToString(formato));
                }
            }
            //Imprimir la fecha que hemos puesto al principio con un formato concreto
            Console.WriteLine(" ");
            Console.WriteLine("Formato fecha-tiempo: " + fechaHoy.ToString("s"));


        }  
    }
}