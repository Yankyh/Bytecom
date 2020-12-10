using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bytecom.Tecnologia;
using Bytecom.Tecnologia.DAO;

namespace Bytecom.Administracao
{
    public partial class Pessoa : Form
    {
        /*+  private int id;
          private String nome;
          private String cpfCnpj;
          private String telefone;
          private String celular;
          private String endereco;
          private String bairro;
          private String complemento;
          private String cidade;
          private String cep;
          private DateTime data_cadastro;
          private DateTime data_atualizacao;
          private DateTime data_ultima_venda;*/
        readonly List<Campo> campo;
        public Pessoa(int id)
        {
            InitializeComponent();
            campo = Campo();
        }

        private List<Campo> Campo()
        {
            List<Campo> campo = new List<Campo>
            {
                new Campo("Código", "ID", "Int", false),
                new Campo("Nome", "NOME", "String", true),
                new Campo("CPF/CNPJ", "CPFCNPJ", "String", true),
                new Campo("Telefone", "TELEFONE", "String", true),
                new Campo("Celular", "CELULAR", "String", false),
                new Campo("Endereço", "ENDERECO", "String", true),
                new Campo("Bairro", "BAIRRO", "String", true),
                new Campo("Complemento", "COMPLEMENTO", "String", false),
                new Campo("Cidade", "CIDADE", "String", true),
                new Campo("Cep", "CEP", "String", true),
                new Campo("Data de cadastro", "DATA_CADASTRO", "Datetime", false),
                new Campo("Data de atualização", "DATA_ATUALIZACAO", "Datetime", false),
                new Campo("Data da última venda", "DATA_ULTIMA_VENDA", "Datetime", false)
            };

            return campo;
        }

        private void GravarOnClick(object sender, EventArgs e)
        {
            if (ValidarPreenchimento())
            {
                Registro.Gravar(campo, this, GetTabela());
            }

        }

        //Criei um método separado, para caso eu queria adicionar campos dependendo da regra de negócio.
        private Boolean ValidarPreenchimento()
        {
            return Validar.ValidarPreenchimento(campo, this);
        }

        private String GetTabela()
        {
            return "PESSOA";
        }
    }
}
