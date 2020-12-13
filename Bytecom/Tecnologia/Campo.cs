using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytecom.Tecnologia
{
    class Campo
    {
        private String nome;
        private String nomeFisico;
        private String tipo;
        private Boolean obrigatorio;
        private String tabelaFk;

        public Campo(string tabelaFk)
        {
            this.tabelaFk = tabelaFk;
        }

        public Campo(String nome, String nomeFisico, String tipo, Boolean obrigatorio)
        {
            Nome = nome;
            NomeFisico = nomeFisico;
            Tipo = tipo;
            Obrigatorio = obrigatorio;
        }
        public Campo(String nome, String nomeFisico, String tipo, Boolean obrigatorio, String tabelaFk)
        {
            Nome = nome;
            NomeFisico = nomeFisico;
            Tipo = tipo;
            Obrigatorio = obrigatorio;
        }
        public string Nome { get => nome; set => nome = value; }
        public string NomeFisico { get => nomeFisico; set => nomeFisico = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public bool Obrigatorio { get => obrigatorio; set => obrigatorio = value; }
    }
}
