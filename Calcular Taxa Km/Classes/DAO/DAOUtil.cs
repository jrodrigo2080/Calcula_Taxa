using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular_Taxa_Km.Classes.DAO
{
    class DAOUtil
    {

        string sql;
        DAOConnection conexao = new DAOConnection();
        FbCommand comando;

        //Metodo Para criar o Log
        public void Log(string msg)
        {
            var caminho = @"c:\MvarandasTecnologia\MenewPdv\logs\taxa\log-" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            StreamWriter file = new StreamWriter(caminho, true, Encoding.Default);
            file.WriteLine(DateTime.Now + " > " + msg);
            file.Dispose();
        }

        //Metodo para carregar dados na tabela
        public void CarregarDados(string script, DataGridView tabela)
        {
            sql = script;
            conexao.Conectar();
            comando = new FbCommand(sql, conexao.conexao);
            try
            {
                FbDataAdapter adapter = new FbDataAdapter(comando);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tabela.DataSource = dt;
                Log("Carregando a tabela.....");

            }
            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }
        //metodo para salvar novas taxas
        public void SalvarTaxa(float ate,float atekm,float valor)
        {

        }


    }
}
