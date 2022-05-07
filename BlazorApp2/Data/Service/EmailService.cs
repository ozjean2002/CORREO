using BlazorApp2.Data.model;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Data.service
{
    public class EmailService : IEmailService
    {

        //Conexion Sql Server
        private readonly SqlConnectionConfiguration _configuration;

        public EmailService(SqlConnectionConfiguration configuration)

        {


            _configuration = configuration;


        }
        
        //Obtener todos los datos
        public async Task<IEnumerable<Email>> GetAll()
        {
            using (var conn = new SqlConnection(_configuration.Value))
            {
                const string SelectEmail = @"SELECT emailP, nombreP, apellidoP, direccionP, productoP FROM dbo.tabla";
                var resultEmail = await conn.QueryAsync<Email>(SelectEmail);
                return resultEmail.ToList();
                    
            }
        }
    }







}

