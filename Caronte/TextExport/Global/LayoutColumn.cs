using System;
using System.Collections.Generic;
using System.Text;

namespace infraestrutura.TextExport
{
    public class LayoutColumn
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Format { get; set; }
        public string Fill { get; set; }
        public string Size { get; set; }
        public int Position { get; set; }

        public string Range { get; set; }


        public string  Get(string valor)
        {



            if (Type.ToLower() == "alfa")
            {                
                valor = valor.Substring(0,    valor.Length >= 100 ?  Convert.ToInt32(Size) : valor.Length );
            }

            if (Type.ToLower() == "inteiro")
            {
               valor = Convert.ToInt32(valor).ToString(this.Format);
            }

            if (Type.ToLower() == "data")
            {
                if (valor.Trim().Length >= 10)
                { 
                   valor = Convert.ToDateTime(valor).ToString(this.Format);
                }
            }

            return valor;
            
        }

        

    }
}
