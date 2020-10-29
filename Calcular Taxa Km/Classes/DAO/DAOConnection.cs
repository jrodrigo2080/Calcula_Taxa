using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calcular_Taxa_Km.Classes.DAO
{
    class DAOConnection
    {
        
        DAOUtil util = new DAOUtil();
        public FbConnection conexao = new FbConnection("User= SYSDBA;Password= masterkey;Database=C:\\MvarandasTecnologia\\Database\\NETUNO.FDB");
        public void Conectar()
        {
            
            try
            {
                if (conexao.State == System.Data.ConnectionState.Closed) 
                 
                    conexao.Open();
                
            }catch(Exception e)
            {
                util.Log("Erro ao conectar ao banco de dados: "+e.Message);
            }

        }

       

    }
}
