using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caronte.Model
{
    public class IdentificacaoEscolaModel
    {

        public string Regitro { get; set; }
        public long Codigo { get; set; }
        public long Situacao { get; set; }
        public long Zona { get; set; }
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }

        public string Bairro { get; set; }



        public void LoadMockup()
        { 
        
        }
        
    }
}
