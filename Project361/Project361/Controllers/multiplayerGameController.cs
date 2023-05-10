using Microsoft.AspNetCore.Mvc;
using System;
using MySql.Data.MySqlClient;

namespace Project361.Controllers
{
    public class multiplayerGameControler : Controller
    {
        private MySqlConnection connection;

        [HttpPost]
        public Player[] Post(Player[] players)
        {
            string connectionString = "Your Connection String Here";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                for (int i = 0; i < players.Length; i++)
                {
                    string query = string.Format("INSERT into players (name, score) values('{0}', {1});", players[i].Nickname, players[i].Score);
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return players;
        }

        [HttpGet]
        public Player[] getPlayers(int gameId)
        {
            Player[] players = new Player[100];
            string connectionString = "Your Connection String Here";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = string.Format("SELECT * from players where gameId = {0};", gameId);
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    players[i].Nickname = reader["player_name"].ToString();
                    players[i].Score = int.Parse(reader["score"].ToString());
                    i++;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return players;
        }

        [HttpGet]
        public Card[] getDeck()
        {
            Card[] deck = new Card[100];
            string connectionString = "Your Connection String Here";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "SELECT * from card;";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    deck[i].CardId = int.Parse(reader["id"].ToString());
                    deck[i].CardValue = int.Parse(reader["rank"].ToString());
                    deck[i].CardSuite = int.Parse(reader["suite"].ToString());
                    i++;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return deck;
        }

        [HttpPut]
        public Player[] updatePlayers(Player[] players)
        {
            string connectionString = "Your Connection String Here";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                for (int i = 0; i < players.Length; i++)
                {
                    string query = string.Format("UPDATE players SET score = {0} WHERE id = {1};", players[i].Score, players[i].PlayerId);
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return players;
        }
    }
}
