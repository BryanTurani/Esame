using AssociazioneSportiva.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AssociazioneSportiva.DataAccess
{
    public class SocietàSqlRepository : IRepository<Società>
    {
        private const string string_connection = @"Data Source=TRISRV10\SQLEXPRESS;Initial Catalog=AssociazioneSportiva_MBA;Integrated Security=True";

        public bool Delete(Società model)
        {
            using (var conn = new SqlConnection(string_connection))
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("DELETE FROM Società WHERE IdSocietà = @id");
                    cmd.Parameters.AddWithValue("@id", model.IdSocietà);

                    var result = cmd.ExecuteNonQuery();

                    return result == 1;
                }
            }
        }

        public Società Find(int id)
        {
            using (var conn = new SqlConnection(string_connection))
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Società WHERE IdSocietà = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Società
                            {
                                IdSocietà = (int)reader[nameof(Società.IdSocietà)],
                                Nome = (string)reader[nameof(Società.Nome)],
                                PartitaIva = (int)reader[nameof(Società.PartitaIva)],
                                CodFiscaleSoc = (string)reader[nameof(Società.CodFiscaleSoc)],
                                Indirizzo = (string)reader[nameof(Società.Indirizzo)],
                                NumCivico = (int)reader[nameof(Società.NumCivico)],
                                Città = (string)reader[nameof(Società.Città)],
                                Paese = (string)reader[nameof(Società.Paese)],
                                TipoSocietà = (List<TipoSocietà>)reader[nameof(Società.TipoSocietà)],
                                Email = (string)reader[nameof(Società.Email)],
                                EmailCertificata = (string)reader[nameof(Società.EmailCertificata)]
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public List<Società> FindAll()
        {
            using (var conn = new SqlConnection(string_connection))
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Società";

                    using (var reader = cmd.ExecuteReader())
                    {
                        var list = new List<Società>();

                        while (reader.Read())
                        {
                            var soc = new Società
                            {
                                IdSocietà = (int)reader[nameof(Società.IdSocietà)],
                                Nome = (string)reader[nameof(Società.Nome)],
                                PartitaIva = (int)reader[nameof(Società.PartitaIva)],
                                CodFiscaleSoc = (string)reader[nameof(Società.CodFiscaleSoc)],
                                Indirizzo = (string)reader[nameof(Società.Indirizzo)],
                                NumCivico = (int)reader[nameof(Società.NumCivico)],
                                Città = (string)reader[nameof(Società.Città)],
                                Paese = (string)reader[nameof(Società.Paese)],
                                TipoSocietà = (List<TipoSocietà>)reader[nameof(Società.TipoSocietà)],
                                Email = (string)reader[nameof(Società.Email)],
                                EmailCertificata = (string)reader[nameof(Società.EmailCertificata)]
                            };

                            list.Add(soc);
                        }

                        return list;
                    }
                }
            }
        }

        public void Insert(Società model)
        {
            using (var conn = new SqlConnection(string_connection))
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO Società([Nome], [PartIva], [CodFiscaleSoc], [Indirizzo], [NumeroCivico], [Città], [Paese], [TipoSocietà], [Email], [EmailCertificata] VALUES (@Nome,@PartIva,@CodFisc,@Indirizzo,@NumeroCivico,@Città,@Paese,@TipoSocietà,@Email,@EmailCertificata)";
                    cmd.Parameters.AddWithValue("@Nome", model.Nome);
                    cmd.Parameters.AddWithValue("@PartIva", model.PartitaIva);
                    cmd.Parameters.AddWithValue("@CodFisc", model.CodFiscaleSoc);
                    cmd.Parameters.AddWithValue("@Indirizzo", model.Indirizzo);
                    cmd.Parameters.AddWithValue("@NumeroCivico", model.NumCivico);
                    cmd.Parameters.AddWithValue("@Città", model.Città);
                    cmd.Parameters.AddWithValue("@Paese", model.Paese);
                    cmd.Parameters.AddWithValue("@TipoSocietà", model.TipoSocietà);
                    cmd.Parameters.AddWithValue("@Email", model.Email);
                    cmd.Parameters.AddWithValue("@EmailCertificata", model.EmailCertificata);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(Società model)
        {
            using (var conn = new SqlConnection(string_connection))
            {
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Società SET [Nome] = @Nome, [PartIva] = @PartIva, [CodFiscaleSoc] = @CodFiscaleSoc, [Indirizzo] = @Indirizzo, [NumeroCivico] = @NumeroCivico, [Città] = @Città, [Paese] = @Paese, [TipoSocietà] = @TipoSocietà, [Email] = @Email, [EmailCertificata] = @EmailCertificata WHERE IdSocietà = @id";
                    cmd.Parameters.AddWithValue("Nome", model.Nome);
                    cmd.Parameters.AddWithValue("PartIva", model.PartitaIva);
                    cmd.Parameters.AddWithValue("CodFisc", model.CodFiscaleSoc);
                    cmd.Parameters.AddWithValue("Indirizzo", model.Indirizzo);
                    cmd.Parameters.AddWithValue("NumeroCivico", model.NumCivico);
                    cmd.Parameters.AddWithValue("Città", model.Città);
                    cmd.Parameters.AddWithValue("Paese", model.Paese);
                    cmd.Parameters.AddWithValue("TipoSocietà", model.TipoSocietà);
                    cmd.Parameters.AddWithValue("Email", model.Email);
                    cmd.Parameters.AddWithValue("EmailCertificata", model.EmailCertificata);
                    cmd.Parameters.AddWithValue("id", model.IdSocietà);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
