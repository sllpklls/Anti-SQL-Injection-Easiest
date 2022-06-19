using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AntiSQLInjection
{
    class SQL
    {
        string con = "Data Source=SLLPKLLS\\SQLEXPRESS;Initial Catalog=test;User ID=sa;Password=hoangthaifc01";//biến con sqlconection để kêt nối đến CSDL
        
        public Boolean execute(string ID, string PASS) //hàm thực thi dữ liệu có tham số cmd
        {
            
            using var connection = new SqlConnection(con);
            using var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = $"SELECT * FROM Account WHERE ID = '{encode(ID)}' AND PASSWORDA = '{encode(PASS)}'";
            connection.Open();
            using(var reader = command.ExecuteReader())
            {
                if (reader.HasRows) return true;
                
            }
            return false;
            connection.Close();

        }
        public void Add(string ID, string Pass)
        {
            using var connection = new SqlConnection(con);
            using var command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = $"INSERT INTO account VALUES ('{encode(ID)}','{encode(Pass)}')";
            connection.Open();
            var b = command.ExecuteNonQuery();
            MessageBox.Show("Done!" + b.ToString() + "lines");
            
            connection.Close();
        }
        public static string encode(string pass)
        {
            string s = "'";
            //string pass = "";
            //.WriteLine("Enter Password: ");
            //pass = Console.ReadLine();

            string mahoa = "";
            if (pass != null)
            {
                for (int i = 0; i < pass.Length; i++)
                {
                    if (pass[i] == 'a') mahoa += 'e';
                    if (pass[i] == 'b') mahoa += 'f';
                    if (pass[i] == 'c') mahoa += 'g';
                    if (pass[i] == 'd') mahoa += 'h';
                    if (pass[i] == 'e') mahoa += 'i';
                    if (pass[i] == 'f') mahoa += 'j';
                    if (pass[i] == 'g') mahoa += 'k';
                    if (pass[i] == 'h') mahoa += 'l';
                    if (pass[i] == 'i') mahoa += 'm';
                    if (pass[i] == 'j') mahoa += 'n';
                    if (pass[i] == 'k') mahoa += 'o';
                    if (pass[i] == 'l') mahoa += 'p';
                    if (pass[i] == 'm') mahoa += 'q';
                    if (pass[i] == 'n') mahoa += 'r';
                    if (pass[i] == 'o') mahoa += 's';
                    if (pass[i] == 'p') mahoa += 't';
                    if (pass[i] == 'q') mahoa += 'u';
                    if (pass[i] == 'r') mahoa += 'v';
                    if (pass[i] == 's') mahoa += 'w';
                    if (pass[i] == 't') mahoa += 'x';
                    if (pass[i] == 'u') mahoa += 'y';
                    if (pass[i] == 'v') mahoa += 'z';
                    if (pass[i] == 'w') mahoa += 'a';
                    if (pass[i] == 'x') mahoa += 'b';
                    if (pass[i] == 'y') mahoa += 'c';
                    if (pass[i] == 'z') mahoa += 'd';
                    if (pass[i] == '0') mahoa += '5';
                    if (pass[i] == '1') mahoa += '6';
                    if (pass[i] == '2') mahoa += '7';
                    if (pass[i] == '3') mahoa += '8';
                    if (pass[i] == '4') mahoa += '9';
                    if (pass[i] == '5') mahoa += '0';
                    if (pass[i] == '6') mahoa += '1';
                    if (pass[i] == '7') mahoa += '2';
                    if (pass[i] == '8') mahoa += '3';
                    if (pass[i] == '9') mahoa += '4';
                    if (pass[i] == '-') mahoa += '+';
                    if (pass[i] == '+') mahoa += '-';
                    if (pass[i] == ';') mahoa += ':';
                    if (pass[i] == ':') mahoa += ';';
                    if (pass[i] == ',') mahoa += '.';
                    if (pass[i] == '.') mahoa += ',';
                    if (pass[i] == '<') mahoa += '>';
                    if (pass[i] == '>') mahoa += '<';
                    if (pass[i] == '`') mahoa += '~';
                    if (pass[i] == '~') mahoa += '`';
                    if (pass[i] == '!') mahoa += '@';
                    if (pass[i] == '@') mahoa += '!';
                    if (pass[i] == '#') mahoa += '$';
                    if (pass[i] == '$') mahoa += '#';
                    if (pass[i] == '%') mahoa += '^';
                    if (pass[i] == '^') mahoa += '%';
                    if (pass[i] == '&') mahoa += '*';
                    if (pass[i] == '*') mahoa += '&';
                    if (pass[i] == '(') mahoa += ')';
                    if (pass[i] == ')') mahoa += '(';
                    if (pass[i] == '_') mahoa += '=';
                    if (pass[i] == '=') mahoa += '_';
                    if (pass[i] == '{') mahoa += '}';
                    if (pass[i] == '}') mahoa += '{';
                    if (pass[i] == '\\') mahoa += '|';
                    if (pass[i] == '|') mahoa += '\\';
                    if (pass[i] == '?') mahoa += '/';
                    if (pass[i] == '/') mahoa += '?';
                    if (pass[i] == '"') mahoa += s;
                    if (pass[i] == s[0]) mahoa += '"';
                }
            }
            return mahoa;
        }
        public static string decrypt(string passencode)
        {
            string s = "'";
            //string passencode = "";
            //Console.WriteLine("Enter Mật Khẩu Đã Mã Hóa:");
            //passencode = Console.ReadLine();
            string giaima = "";
            if (passencode != null)
            {
                for (int i = 0; i < passencode.Length; i++)
                {
                    if (passencode[i] == 'a') giaima += 'w';
                    if (passencode[i] == 'b') giaima += 'x';
                    if (passencode[i] == 'c') giaima += 'y';
                    if (passencode[i] == 'd') giaima += 'z';
                    if (passencode[i] == 'e') giaima += 'a';
                    if (passencode[i] == 'f') giaima += 'b';
                    if (passencode[i] == 'g') giaima += 'c';
                    if (passencode[i] == 'h') giaima += 'd';
                    if (passencode[i] == 'i') giaima += 'e';
                    if (passencode[i] == 'j') giaima += 'f';
                    if (passencode[i] == 'k') giaima += 'g';
                    if (passencode[i] == 'l') giaima += 'h';
                    if (passencode[i] == 'm') giaima += 'i';
                    if (passencode[i] == 'n') giaima += 'j';
                    if (passencode[i] == 'o') giaima += 'k';
                    if (passencode[i] == 'p') giaima += 'l';
                    if (passencode[i] == 'q') giaima += 'm';
                    if (passencode[i] == 'r') giaima += 'n';
                    if (passencode[i] == 's') giaima += 'o';
                    if (passencode[i] == 't') giaima += 'p';
                    if (passencode[i] == 'u') giaima += 'q';
                    if (passencode[i] == 'v') giaima += 'r';
                    if (passencode[i] == 'w') giaima += 's';
                    if (passencode[i] == 'x') giaima += 't';
                    if (passencode[i] == 'y') giaima += 'u';
                    if (passencode[i] == 'z') giaima += 'v';
                    if (passencode[i] == '0') giaima += '5';
                    if (passencode[i] == '1') giaima += '6';
                    if (passencode[i] == '2') giaima += '7';
                    if (passencode[i] == '3') giaima += '8';
                    if (passencode[i] == '4') giaima += '9';
                    if (passencode[i] == '5') giaima += '0';
                    if (passencode[i] == '6') giaima += '1';
                    if (passencode[i] == '7') giaima += '2';
                    if (passencode[i] == '8') giaima += '3';
                    if (passencode[i] == '9') giaima += '4';
                    if (passencode[i] == '-') giaima += '+';
                    if (passencode[i] == '+') giaima += '-';
                    if (passencode[i] == ';') giaima += ':';
                    if (passencode[i] == ':') giaima += ';';
                    if (passencode[i] == ',') giaima += '.';
                    if (passencode[i] == '.') giaima += ',';
                    if (passencode[i] == '<') giaima += '>';
                    if (passencode[i] == '>') giaima += '<';
                    if (passencode[i] == '`') giaima += '~';
                    if (passencode[i] == '~') giaima += '`';
                    if (passencode[i] == '!') giaima += '@';
                    if (passencode[i] == '@') giaima += '!';
                    if (passencode[i] == '#') giaima += '$';
                    if (passencode[i] == '$') giaima += '#';
                    if (passencode[i] == '%') giaima += '^';
                    if (passencode[i] == '^') giaima += '%';
                    if (passencode[i] == '&') giaima += '*';
                    if (passencode[i] == '*') giaima += '&';
                    if (passencode[i] == '(') giaima += ')';
                    if (passencode[i] == ')') giaima += '(';
                    if (passencode[i] == '_') giaima += '=';
                    if (passencode[i] == '=') giaima += '_';
                    if (passencode[i] == '{') giaima += '}';
                    if (passencode[i] == '}') giaima += '{';
                    if (passencode[i] == '\\') giaima += '|';
                    if (passencode[i] == '|') giaima += '\\';
                    if (passencode[i] == '?') giaima += '/';
                    if (passencode[i] == '/') giaima += '?';
                    if (passencode[i] == '"') giaima += s;
                    if (passencode[i] == s[0]) giaima += '"';
                }

            }
            return giaima;
        }


    }
}
