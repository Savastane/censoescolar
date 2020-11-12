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
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        
        public string Nome { get; set; }
        public long CEP { get; set; }
        public long Municipio { get; set; }
        public long Distrito { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public long DDD { get; set; }
        public long Telefone { get; set; }
        public long TelefoneContato { get; set; }
        public string Email { get; set; }
        public string CodigoOrgaoEnsino { get; set; }
        public long LocalizacaoZona { get; set; }
        public long LocalizacaoDiferenciada { get; set; }
        public long DependenciaAdministrativa { get; set; }

        // orgao a que a escola publica esta vinculada
        public long SecretariaEducacao { get; set; }
        public long SecretariaMilitar { get; set; }
        public long SecretariaSaude { get; set; }
        public long OrgaoAdministracaoPublica { get; set; }

        // Mantenedora privada
        public long Empresas { get; set; }
        public long Sindicatos { get; set; }
        public long Ongs { get; set; }

        public long SemFinsLucrativos { get; set; }

        //Sesi sesc senai
        public long SistemaS { get; set; }


        public long CateriaEscolaPrivada { get; set; }

        public long ConveniadaPoderPublico { get; set; }

        public string CNPJMantenedoraEscolaPrivada { get; set; }

        public string Autorizacao { get; set; }

        //esfera

        public long Federal { get; set; }
        public long Estadual { get; set; }
        public long Municipal { get; set; }


        public long UnidadeVinculadaEscola{ get; set; }
        public long CodigoEscolaSede { get; set; }
        public long CodigoIES { get; set; }

        
        public void LoadMockup()
        { 
        
        }
        
    }
}
