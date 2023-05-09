using Microsoft.AspNetCore.Mvc;
using System;
using MySql.Data.MySqlClient;


namespace Project361.Controllers
{
	/// <summary>
	/// multiplayerGameController uses HTTP requests to send data from the database to the front end
	/// How to connect to the database: https://www.codeproject.com/Articles/43438/Connect-C-to-MySQL
	/// </summary>
	public class multiplayerGameControler : Controller
	{
        /*
		 * Adds an array of players to the database
		 * <param=players>Array of players</param>
		 * <return>Array of players</return>
		 */
        [HttpPost]
		public void Post(Player players[])
		{
			string connectionString = "";
            connection = new MySqlConnection(connectionString);
			try
			{
                connection.Open();
                for (int i = 0; i < players[].Length; i++)
				{
                    string query = string.Format("INSERT into players (name, score) values({0}, {1});", players[i].nickname, players[i].score);
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
				connection.Close();
            } catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return players;
        }

		/*
		 * Gets all players with a unique game id from the database.
		 * <Param="gameId">Game Id</param>
		 * <return>Array of players with said game id from the database</return>
		 */
		[HttpGet]
		public Player[] getPlayers(int gameId)
		{
			Player[] players = new Player();
            string connectionString = "";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = string.Format("SELECT * from players where gameId = {0};", gameId);
                MySqlCommand command = new MySqlCommand(query, connection);
				SqlDataReader reader = command.ExecuteReader(); //https://stackoverflow.com/questions/14171794/how-to-retrieve-data-from-a-sql-server-database-in-c
				int i = 0;
				while(reader.Read())
				{
					players[i].nickname = reader[player_name].ToString();
					players[i].score = reader[score];
				}
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return players;
        }

		/*
		 * Gets the deck from the database
		 * <return>array of cards repesenting the deck</return>
		 */
		[HttpGet]
		public Card[] getDeck()
		{
            Card[] deck = new Card();
            string connectionString = "";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "SELECT * from card;";
                MySqlCommand command = new MySqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader(); //https://stackoverflow.com/questions/14171794/how-to-retrieve-data-from-a-sql-server-database-in-c
                int i = 0;
                while (reader.Read())
                {
                    deck[i].cardId = reader[id];
                    deck[i].cardValue = reader[rank];
                    deck[i].cardSuite = reader[suite];
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return deck;
        }

        /*
         * Updates score of the player in the database
         * <param=players>Player array</param>
         * <return>Array of players</return>
         */
        [HttpPut]
        public Player[] updatePlayers(Player[] players)
        {
            string connectionString = "";
            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                for (int i = 0; i < players[].Length; i++)
                {
                    string query = string.Format("UPDATE players where id = {0} set score = {1};", players[i].playerId, players[i]).score);
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
