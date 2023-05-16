using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public static class Connection
    {
        public static SqlConnection conn = new SqlConnection(connectionString);
        public static string connectionString = "Data Source=LAB-F08-06;Initial Catalog=VerduraoDoJoaoDB;User ID=sa;Password=senai@123";
        public static void Connect()
        {
            CreateConnection();
        }
        public static void Connect(string server, string dataBase, string user, string password)
        {
            connectionString = $"Data Source={server};Initial Catalog={dataBase};User ID={user};Password={password}";
            CreateConnection();
        }
        private static void CreateConnection()
        {
            conn = new SqlConnection(connectionString);
            if (!IsConnected())
            {
                conn.Open();
            }
        }
        public static bool IsConnected()
        {
            if (conn.State == ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Close()
        {
            if (IsConnected())
            {
                conn.Close();
            }
        }
        private static bool ExistTable(string tableName)
        {
            string query = $"SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = 'dbo' AND table_name = '{tableName}'";
            SqlCommand cmd = new SqlCommand(query, conn);

            int count = (int)cmd.ExecuteScalar();

            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void CreateTable(string tableName)
        {
            Connect();
            if (!ExistTable(tableName))
            {
                string query = $"CREATE TABLE {tableName}( id INT IDENTITY(1,1) PRIMARY KEY);";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            Close();
        }
        private static void UpdateTable(string tableName,Dictionary<string,object> dict)
        {
            CreateTable(tableName);

            string query = $"ALTER TABLE {tableName} ";
            Connect();//abre a conexão para o uso do método ExistColumns
            var MissingColumnsNames = ExistColumns(dict.Keys.ToArray(), tableName);
            Close();//fecha a conexão usada por ExistColumns
            //se não foi adicionado nada, ou seja, não tem coluna nova retorna
            if (MissingColumnsNames.Count == 0) return;
            foreach (var columnName in MissingColumnsNames)
            {
                query += "ADD " + columnName + " VARCHAR(MAX), ";
            }
            query = query.TrimEnd(',', ' ') + ";";
        
            Connect();//abre a conexão para o envio do comando com as novas colunas
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.ExecuteNonQuery();
            Close(); // fecha a conexão da atualização das colunas da tabela
        }
        private static List<string> ExistColumns(string[] columnNames, string tableName)
        {
            List<string> missingColumnNames = new List<string>();
            string query = $"SELECT column_name FROM information_schema.columns WHERE table_name = '{tableName}' AND column_name NOT IN ('{string.Join("', '", columnNames)}')";
            SqlCommand cmd = new SqlCommand(query, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string columnName = reader.GetString(0);

                    if (!columnNames.Contains(columnName))
                    {
                        missingColumnNames.Add(columnName);

                    }
                }
            }
            return missingColumnNames;
        }
        public static void AddValues(string tableName,Dictionary<string,object> dict)
        {
            UpdateTable(tableName,dict); //atualiza a tabela com novas colunas se forem necessárias para inclusão dos dados
            string query = $"INSERT INTO {tableName} (";

            foreach (var item in dict)
            {
                query += $" {item.Key.ToString().Replace(" ", "_")},";
            }
            //removendo a ultima virgula
            query = query.Remove(query.Length - 1);
            //fechando a parenteses
            query += ")";
            query += " VALUES (";
            foreach (var item in dict)
            {
                query += $" '{item.Value}',";
            }
            //removendo a ultima virgula
            query = query.Remove(query.Length - 1);
            query += ");";
            Connect();
            SqlCommand cmd = new SqlCommand(query, conn);


            cmd.ExecuteNonQuery();
            Close();
        }
        public static void UpdateDB(Dictionary<string, Dictionary<string,object>> db)
        {
            foreach(var item in db)
            {
                CreateTable(item.Key);
                UpdateTable(item.Key, item.Value);
                AddValues(item.Key, item.Value);
            }
        }
        public static Dictionary<string, Dictionary<string, object>> GetDB(string dataBaseName)
        {
            Dictionary<string, Dictionary<string, object>> db = new();
            List<string> tableNames = GetTablesNames(dataBaseName);
            foreach (string tableName in tableNames)
            {
                db.Add(tableName,GetTable(tableName));
            }
            return db;
        }
        private static Dictionary<string, object> GetTable(string tableName)
        {
            string query = $"SELECT * FROM {tableName};";

            Dictionary<string, object> dict = new Dictionary<string, object>();

            SqlCommand cmd = new SqlCommand(query, conn);
            Connect();
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dict.Add(reader.GetName(i), reader.GetValue(i));
                    }
                }
            }
            finally
            {
                reader.Close();
            }
            Close();
            return dict;
        }
        public static List<string> GetTablesNames(string dataBaseName)
        {
            Connect();
            List<string> tableNames = new List<string>();
            string query = $"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG='{dataBaseName}';";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    tableNames.Add(reader[0].ToString());
                }
            }
            finally
            {
                reader.Close();
            }
            Close();
            return tableNames;
        }
    }
}