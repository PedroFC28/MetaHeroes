using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroController : ControllerBase
    {
        private readonly ILogger<HeroController> _logger;

        public HeroController(ILogger<HeroController> logger)
        {
            _logger = logger;
        }



        [HttpPost("AddHero"), Authorize]
        public IActionResult ReceberDados([FromBody] Hero hero)
        {
            try
            {
                // GravarDadosEmArquivo(hero);
                InserirDados(hero);
                var response = new { message = "Dados recebidos e inseridos com sucesso!" };
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Ocorreu um erro ao processar os dados.", ex });
            }
        }

        private void InserirDados(Hero hero)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("Server=localhost; port= 3308; Database=mybd; UserId=root; Password=password;"))
                {
                    conn.Open();

                    string sql = "INSERT INTO hero (Name, AlterEgo, Power) VALUES (@Name, @AlterEgo, @Power)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Name", hero.Name);
                    cmd.Parameters.AddWithValue("@AlterEgo", hero.AlterEgo);
                    cmd.Parameters.AddWithValue("@Power", hero.Power);
                    cmd.ExecuteNonQuery();
                    _logger.LogError("Dados inseridos com sucesso.");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao inserir dados na base de dados.");
            }


        }
    }
}