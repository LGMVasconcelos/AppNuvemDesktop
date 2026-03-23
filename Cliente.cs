using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace AppNuvemDesktop
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string celular { get; set; }
        public DateTime datanasc { get; set; }
        public string genero { get; set; }

        static MySqlConnection con = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_senai_2026;user id=freedb_LuizAdm;password=at7#vD*&hEyM5K2;charset=utf8");
        public static List<Cliente> listaCliente()
        {
            List<Cliente> li = new List<Cliente>();
            string sql = "SELECT * FROM clientes";
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Cliente c = new Cliente();
                    c.id = (int)dr["id"];
                    c.nome = (string)dr["nome"];
                    c.celular = (string)dr["celular"];
                    c.datanasc = (DateTime)dr["datanasc"];
                    c.genero = (string)dr["genero"];
                    li.Add(c);
                }
                dr.Close();
                return li;
            }
            catch (MySqlException erro)
            {
                MessageBox.Show($"Ocorreu um erro no banco de dados ({erro.Message})", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ({ex.Message})", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return li;
        }

        public static void Inserir(Cliente cliente)
        {
            try
            {
                string sql = "INSERT INTO clientes(nome, celular, datanasc, genero) VALUES (@Nome, @Celular, @Datanasc, @Genero);";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("Nome", cliente.nome);
                cmd.Parameters.AddWithValue("Celular", cliente.celular);
                cmd.Parameters.AddWithValue("Datanasc", cliente.datanasc);
                cmd.Parameters.AddWithValue("Genero", cliente.genero);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Cliente {cliente.nome} inserido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException erro)
            {
                MessageBox.Show($"Ocorreu um erro no banco de dados ({erro.Message})", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ({ex.Message})", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        public static void Atualizar(Cliente cliente)
        {
            try
            {
                string sql = "UPDATE clientes SET nome=@Nome, celular=@Celular, datanasc=@Datanasc, genero=@Genero WHERE id = @Id;";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("Id", cliente.id);
                cmd.Parameters.AddWithValue("Nome", cliente.nome);
                cmd.Parameters.AddWithValue("Celular", cliente.celular);
                cmd.Parameters.AddWithValue("Datanasc", cliente.datanasc);
                cmd.Parameters.AddWithValue("Genero", cliente.genero);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Cliente {cliente.nome} atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException erro)
            {
                MessageBox.Show($"Ocorreu um erro no banco de dados ({erro.Message})", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ({ex.Message})", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        public static void Excluir(int id)
        {
            try
            {
                string sql = "DELETE FROM clientes WHERE id=@Id";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("Id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Cliente excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException erro)
            {
                MessageBox.Show($"Ocorreu um erro no banco de dados ({erro.Message})", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ({ex.Message})", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        public static bool RegistroRepetido(string celular, int idCliente)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM clientes WHERE celular=@Celular AND id <> @Id";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("Celular", celular);
                cmd.Parameters.AddWithValue("Id", idCliente);
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                return result > 0;
            }
            catch (MySqlException erro)
            {
                MessageBox.Show($"Ocorreu um erro no banco de dados ({erro.Message})", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ({ex.Message})", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return false;

        }

        public static bool RegistroRepetidoInsert(string celular)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM clientes WHERE celular=@Celular";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("Celular", celular);
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                return result > 0;
            }
            catch (MySqlException erro)
            {
                MessageBox.Show($"Ocorreu um erro no banco de dados ({erro.Message})", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ({ex.Message})", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return false;

        }

        public Cliente Localizar(int id)
        {
            try
            {
                string sql = "SELECT * FROM clientes WHERE id=@Id;";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("Id", id);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Cliente c = new Cliente();
                    c.nome = (string)dr["nome"];
                    c.celular = (string)dr["celular"];
                    c.datanasc = (DateTime)dr["datanasc"];
                    c.genero = (string)dr["genero"];
                    return c;
                }
                dr.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show($"Ocorreu um erro no banco de dados ({erro.Message})", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ({ex.Message})", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public string GeneroDesc
        {
            get
            {
                switch (genero)
                {
                    case "M":
                        return "Masculino";
                    case "F":
                        return "Feminino";
                    default:
                        return "Outro";
                }
            }
        }

        public string CelularFormatado
        {
            get
            {
                if (string.IsNullOrEmpty(celular))
                    return "";

                if (celular.Length == 11)
                    return $"({celular.Substring(0, 2)}) {celular.Substring(2, 5)}-{celular.Substring(7, 4)}";

                if (celular.Length == 10)
                    return $"({celular.Substring(0, 2)}) {celular.Substring(2, 4)}-{celular.Substring(6, 4)}";

                return celular;
            }
        }

        public int Idade
        {
            get
            {
                return DateTime.Now.Year - datanasc.Year;
            }
        }
    }
}
