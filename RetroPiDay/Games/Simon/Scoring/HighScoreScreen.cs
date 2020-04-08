using RetroPiDay.Games.Simon.OMF;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetroPiDay.Games.Simon.Scoring
{
    class HighScoreScreen
    {
        void ShowHighScores()
        {
            var eds = new EDSInteraction("asdf");
            var highScoresString = eds.GetHighScores().Result;
        }
    }
}
