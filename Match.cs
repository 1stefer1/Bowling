using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiuiu.iipb_22_2.MilyayevVD.Bowling
{
    
    public class Match
    {
        private List<Game> games; //лист для всех игр
        public Match()
        {
            this.games = new List<Game>();
        }
        public void AddGame(Game game) // Добавление новой игры к матчу
        {
            games.Add(game);
        }
        public int CalculateTotalScore() //общий счет всех игр
        {
            int totalScore = 0;
            foreach (var game in games)
            {
                totalScore += game.CalculateScore();
            }
            return totalScore;
        }

    }
}
