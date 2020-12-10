﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytecom.Tecnologia.DAO
{
    class Conexao
    {

        // Objeto Connection para obter acesso ao SQL Server
        public static SqlConnection sqlconnection = new SqlConnection();
        // Objeto SqlCommand para executar os com
        public static SqlCommand comando = new SqlCommand();
        // Objeto SqlParameter para adicionar os parâmetros
        public static SqlParameter parametro = new SqlParameter();


        public static SqlConnection Conectar()
        {
            try
            {
                // Obtemos os dados da conexão existentes no WebConfig
                string dadosConexao = "Data Source=LOCALHOST;Initial Catalog=Bytecom;User ID=sa;Password=33226655";
                // Instanciando o objeto SqlConnection
                sqlconnection = new SqlConnection(dadosConexao);
                //Verifica se a conexão esta fechada.
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    //Abre a conexão.
                    sqlconnection.Open();
                }
                //Retorna o sqlconnection.
                return sqlconnection;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public void Open()
        {
            sqlconnection.Open();
        }

        public void Close()
        {
            sqlconnection.Close();
        }

        public void AdicionarParametro(string nome,
        SqlDbType tipo, int tamanho, object valor)
        {
            // Cria a instância do Parâmetro e adiciona os valores
            parametro = new SqlParameter();
            parametro.ParameterName = nome;
            parametro.SqlDbType = tipo;
            parametro.Size = tamanho;
            parametro.Value = valor;
            // Adiciona ao comando SQL o parâmetro
            comando.Parameters.Add(parametro);
        }


        public void AdicionarParametro(string nome, SqlDbType tipo, object valor)
        {
            // Cria a instância do Parâmetro e adiciona os valores
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nome;
            parametro.SqlDbType = tipo;
            parametro.Value = valor;
            // Adiciona ao comando SQL o parâmetro
            comando.Parameters.Add(parametro);
        }

        public void RemoverParametro(string pNome)
        {
            // Verifica se existe o parâmetro
            if (comando.Parameters.Contains(pNome))
                // Se exite remove o mesmo
                comando.Parameters.Remove(pNome);
        }

        public void LimparParametros()
        {
            comando.Parameters.Clear();
        }

        public DataTable ExecutaConsulta(string sql)
        {
            try
            {
                // Pega conexão com a base SQL Server
                comando.Connection = Conectar();
                // Adiciona a instrução SQL
                comando.CommandText = sql;
                //Executa a query sql.
                comando.ExecuteScalar();
                // Ler os dados e passa para um DataTable
                IDataReader dtreader = comando.ExecuteReader();
                DataTable dtresult = new DataTable();
                dtresult.Load(dtreader);
                // Fecha a conexão
                sqlconnection.Close();
                // Retorna o DataTable com os dados da consulta
                return dtresult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #region Executa uma instrução SQL: INSERT, UPDATE e DELETE
        public int ExecutarDML(string sql)
        {
            try
            {
                //Instância o sqlcommand com a query sql que será executada e a conexão.
                //comando = new SqlCommand(sql, connection());
                comando.Connection = Conectar();
                comando.CommandText = sql;
                //Executa a query sql.
                int result = comando.ExecuteNonQuery();
                sqlconnection.Close();
                // Retorna a quantidade de linhas afetadas
                return result;
            }
            catch (Exception ex)
            {
                // Retorna uma exceção simples que pode ser tratada por parte do desenvolvedor
                throw ex;
            }
        }
        #endregion
    }
}
