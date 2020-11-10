using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using Caronte.TextExport.Factory;
using infraestrutura.TextExport;
using infraestrutura.TextExport.INEP;
using Newtonsoft.Json;

namespace Caronte

{
    class Program
    {
        static void Main(string[] args)
        {


            var dados = Program.getMockupDados();

            /// recebe os dados
            /// verifica o tipo para araregar o layout adequado
            /// salva o arquivo

            FactoryLayout
                .GetLayout(dados)                
                .Save(@"D:\arquivo1.txt");
                 
            



        }



          


            
        


        static dynamic getMockupDados()
        {
            string Json2 = @" [" +
                           @"  {'Registro':'00', 'Codigo': 12345678, 'Situacao': 1  , 'Nome': 'Savastane Andrade' , 'Zona': 1, 'DataInicio' :'2012-04-23T18:25:43.511Z', 'DataTermino' : '2012-04-23T19:25:43.511Z'  }, " +
                           @"  {'Registro':'00', 'Codigo': 23456780, 'Situacao': 2  , 'Nome': 'Andrade Mensdonça' , 'Zona': 2, 'DataInicio' :'2021-04-23T18:00:43.511Z', 'DataTermino' : '2020-04-23T20:35:43.511Z'  } " +                           
                           @" ]";

            
            return JsonConvert.DeserializeObject(Json2);
        
        }
    }
   
}
