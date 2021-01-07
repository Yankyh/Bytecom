using Bytecom.Tecnologia.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bytecom.Tecnologia
{
    class Registro
    {

        public static int ProximoId(String tabela)
        {
            Conexao conexao = new Conexao();

            foreach (DataRow row in conexao.ExecutaConsulta("SELECT MAX(ID) + 1 id FROM " + tabela).Rows)
            {
                if (row["id"] != DBNull.Value)
                {
                    return _ = (Convert.ToInt32(row["id"]));
                }

            }

            return 1;
        }
        public static int Gravar(List<Campo> campo, Form form, String tabela)
        {
            Conexao conexao = new Conexao();
            int id = 0;
            string insert = "INSERT INTO " + tabela + " (";

            //FIELDS
            foreach (Control item in form.Controls)
            {
                if (campo.Contains(campo.Find(x => x.NomeFisico.ToUpper() == item.Name.ToUpper())))
                {
                    insert = insert + campo.Find(x => x.NomeFisico.ToUpper() == item.Name.ToUpper()).NomeFisico + ", ";
                }

            }

            insert = insert.TrimEnd(' ').TrimEnd(',') + ") VALUES (";

            //VALUES
            foreach (Control item in form.Controls)
            {
                Campo campoAtual = campo.Find(x => x.NomeFisico.ToUpper() == item.Name.ToUpper());
                if (campo.Contains(campoAtual))
                {
                    String valor = "";

                    if (item.GetType().ToString() == "System.Windows.Forms.TextBox" || item.GetType().ToString() == "System.Windows.Forms.RichTextBox")
                    {
                        valor = item.Text;
                    }
                    else
                    {
                        if(item.GetType().ToString() == "System.Windows.Forms.ComboBox")
                        {
                            ComboBox comboBox = item as ComboBox;
                            valor = comboBox.SelectedValue.ToString();
                        }
                        else
                        {
                            if(item.GetType().ToString() == "System.Windows.Forms.DateTimePicker")
                            {
                                DateTimePicker dateTimePicker = item as DateTimePicker;
                                valor = dateTimePicker.Value.ToString("yyyy-MM-dd hh:mm:ss");
                            }
                        }

                    }

                    if (String.IsNullOrWhiteSpace(item.Text))
                    {
                        insert = insert + " null, ";
                    }
                    else
                    {
                        if ((campoAtual.Tipo == "String") || (campoAtual.Tipo == "Datetime"))
                        {
                            insert = insert + "'" + valor + "', ";
                        }
                        else
                        {
                            insert = insert + valor + ",";
                        }
                    }

                }
            }

            insert = insert.TrimEnd(' ').TrimEnd(',') + ")";
            MessageBox.Show(insert);
            conexao.ExecutarDML(insert);

            return id;
        }

        public static void Atualizar(List<Campo> campo, Form form, String tabela, int id)
        {
            Conexao conexao = new Conexao();

            string update = "UPDATE " + tabela + " SET ";

            //FIELDS
            foreach (Control item in form.Controls)
            {
                Campo campoAtual = campo.Find(x => (x.NomeFisico.ToUpper() == item.Name.ToUpper()) && x.NomeFisico.ToUpper() != "ID");

                if (campo.Contains(campoAtual))
                {
                    update = update + campoAtual.NomeFisico + " = ";

                    String valor = "";

                    if (item.GetType().ToString() == "System.Windows.Forms.TextBox" || item.GetType().ToString() == "System.Windows.Forms.RichTextBox")
                    {
                        valor = item.Text;
                    }
                    else
                    {
                        if (item.GetType().ToString() == "System.Windows.Forms.ComboBox")
                        {
                            ComboBox comboBox = item as ComboBox;
                            valor = comboBox.SelectedValue.ToString();
                        }
                        else
                        {
                            if (item.GetType().ToString() == "System.Windows.Forms.DateTimePicker")
                            {
                                DateTimePicker dateTimePicker = item as DateTimePicker;
                                valor = dateTimePicker.Value.ToString("yyyy-MM-dd hh:mm:ss");
                            }
                        }

                    }


                    if (String.IsNullOrWhiteSpace(item.Text))
                    {
                        update = update + " null, ";
                    }
                    else
                    {
                        if ((campoAtual.Tipo == "String") || (campoAtual.Tipo == "Datetime"))
                        {
                            update = update + "'" + valor + "', ";
                        }
                        else
                        {
                            update = update + valor + ", ";
                        }
                    }

                }
            }
            update = update.TrimEnd(' ').TrimEnd(',') + "WHERE ID = " + id;
            conexao.ExecutarDML(update);
        }

        public static void Executar(String comando)
        {
            Conexao conexao = new Conexao();
            conexao.ExecutarDML(comando);
        }
        public static void Selecionar(List<Campo> campo, Form form, String tabela, int id)
        {
            Conexao conexao = new Conexao();

            string select = "SELECT * FROM " + tabela + " WHERE ID = " + id;

            foreach (DataRow row in conexao.ExecutaConsulta(select).Rows)
            {
                if (row["id"] != DBNull.Value)
                {
                    foreach (Control item in form.Controls)
                    {
                        Campo campoAtual = campo.Find(x => (x.NomeFisico.ToUpper() == item.Name.ToUpper()));

                        if (campo.Contains(campoAtual))
                        {
                            if (item.GetType().ToString() == "System.Windows.Forms.ComboBox")
                            {
                                ComboBox comboBox = item as ComboBox;
                                comboBox.SelectedValue = row[campoAtual.NomeFisico].ToString();
                            }
                            else
                            {
                                item.Text = row[campoAtual.NomeFisico].ToString();
                            }

                        }
                    }

                }
            }
        }

        public static void SelecionarSubTabela(DataGridView dataGridView, String tabela, String campoFk, int id = 0)
        {
            Conexao conexao = new Conexao();

            string select = "SELECT * FROM " + tabela + " WHERE " + campoFk + " = " + id;

            DataTable dataTable = conexao.ExecutaConsulta(select);

            BindingSource bs = new BindingSource();

            bs.DataSource = dataTable;
            dataGridView.DataSource = bs;
            dataGridView.Refresh();
        }

        public static void SelecionarGrid(DataGridView dataGridView, String tabela)
        {
            string select = "SELECT * FROM " + tabela;

            Conexao conexao = new Conexao();

            DataTable dataTable = conexao.ExecutaConsulta(select);

            BindingSource bs = new BindingSource();

            bs.DataSource = dataTable;
            dataGridView.DataSource = bs;
            dataGridView.Refresh();
        }

        public static void Deletar(String tabela, int id)
        {
            DialogResult confirmar =  MessageBox.Show("Deseja Continuar?", "Excluir registro", MessageBoxButtons.YesNo);

            if (confirmar.ToString().ToUpper() == "YES")
            {
                Conexao conexao = new Conexao();
                string delete = "DELETE FROM " + tabela + " WHERE ID = " + id;

                conexao.ExecutarDML(delete);
            }

        }

        public static void SelecionarComboBox(ComboBox comboBox, String tabela, String where, String traducao)
        {
            string select = "SELECT ID, " + traducao + " FROM " + tabela + " " + where;

            Conexao conexao = new Conexao();

            DataTable dataTable = conexao.ExecutaConsulta(select);
            
            comboBox.DisplayMember = traducao;
            comboBox.ValueMember = "ID";
            comboBox.DataSource = dataTable;
        }

        public static DataTable SelecionarPersonalizado(String select)
        {
            Conexao conexao = new Conexao();

            DataTable dataTable = conexao.ExecutaConsulta(select);

            return dataTable;
        }
    }
}

