using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMoreira.Domain
{
    public class Veiculo
    {
        public int VeiculoId {get; set;}
        public int MarcaId {get; set;}
        public int ModeloId {get; set;}
        public int Ano {get; set;}
        public string Cor {get; set;}
        public string Observacoes {get; set;}
        
    }
}