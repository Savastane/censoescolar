using infraestrutura.TextExport;
using infraestrutura.TextExport.INEP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Caronte.TextExport.Factory
{
    public enum  LayoutEnum { IdentificacaoEscola }

    public class FactoryLayout
    {
        static public FileTextInterface GetLayout(dynamic dados)
        {
            using (StreamReader JsonStream = new StreamReader("../../../layout/LayoutINEP.json"))
            {

                // Load Layout 
                var IdentificacaoEscolaLayoutJson = JsonStream.ReadToEnd();


                if (dados[0].Registro == "00")
                {
                    return Newtonsoft.Json.JsonConvert.DeserializeObject<IdentificacaoEscolaLayout>(IdentificacaoEscolaLayoutJson);
                }
                else 
                {
                    return null;
                }


            }

        }

    }
}
