using ImportData.Class;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportData
{
    
    class Program
    {
        private static SQLiteConnection connection;
        /// <summary>
        /// Function createDataBase
        /// </summary>
        /// <param name="TableName">name of Table</param>
        private static void createDataBase(string dbName)
        {
            SQLiteConnection.CreateFile(dbName);
            connection = new SQLiteConnection(string.Format("Data Source={0}; Version=3;", dbName));
            connection.Open();
        }
        
        private static void createTable(string TableName)
        {
            string sqlCmd = string.Format("CREATE TABLE IF NOT EXISTS\"{0}\" ('Id' INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,'Word' TEXT,'Type' TEXT,'Description' BLOB)",TableName);
            SQLiteCommand cmd = new SQLiteCommand(sqlCmd, connection);
            cmd.ExecuteNonQuery();
        }
        /// <summary>
        /// Insert Data for Table
        /// </summary>
        /// <param name="TableName">name of Table</param>

        private static void insertTable(string TableName)
        {
            List<Words> dicSource = getListDictionary(@"C:\Users\Deepak\documents\visual studio 2015\Projects\ImportData\ImportData\StaticData\a.txt");
            if(dicSource.Count>0)
            {
                foreach (var item in dicSource)
                {
                    string sql = string.Format("insert into Words (Id,Word,Type,Description) values ({0},'{1}','{2}','{3}')", item.id, item.Word, item.Type, item.Description);
                    SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                }
            }
           
        }
        private static List<Words> getListDictionary(string filePath)
        {
            List<Words> dicSource = new List<Words>();
            var content = File.ReadAllLines(filePath);
            content = content.Where(x => !string.IsNullOrEmpty(x)).ToArray();//remove all empty rows
            int id = 1;
            string word, type, description;
            foreach (var value in content)
            {
                List<int> index = getAllIndexOf(' ', value);
                int indexOfLeftParentheses = value.IndexOf('(');
                if(index.Count>1)
                {
                    word = value.Replace(value.Substring(index[0], value.Length - index[0]), string.Empty);
                    type = value.Remove(0, indexOfLeftParentheses - 1); //remove word
                    int indexOfRightParenthesis = type.IndexOf(')');
                    description = type.Remove(0, indexOfRightParenthesis + 1);
                    type = type.Replace(description, string.Empty);

                    Words wordValue = new Words();
                    wordValue.id = id;
                    wordValue.Word = word.Replace("'","''");
                    wordValue.Type = type.Replace("'", "''");
                    wordValue.Description = description.Replace("'", "''");
                    dicSource.Add(wordValue);
                    id++;
                     
                }
            }

            return dicSource;
        }



        private static List<int> getAllIndexOf(char character, string value)
        {
            List<int> result = new List<int>();
            for(int i=0;i<value.Length;i++)
            {
                if (value[i] == character)
                    result.Add(i);
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Auto generate SQL Database V1.01");
            Console.WriteLine("Auhtor: Kaiser");
            createDataBase("MyDB.db");
            createTable("Words");
            Console.WriteLine("Create DB and Table Successful");
            insertTable("Words");
            Console.ReadLine();
            
        }
    }
}
