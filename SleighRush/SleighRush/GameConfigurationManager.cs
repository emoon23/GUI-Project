using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace SleighRush
{
    class GameConfigurationManager
    {
        public List<User> users;

        public GameConfigurationManager()
        {
            users = new List<User> { };
        }

        public void parseConfigurationFile()
        {
            users.Clear();

            string previousUsers = ConfigurationManager.AppSettings["Previous User Scores"];
            List<string> combinedUsers = previousUsers.Split(';').ToList<string>();

            foreach (string userAndScore in combinedUsers)
            {
                string workingString = userAndScore;
                int index = workingString.IndexOf(':');
                if (index == -1)
                {
                    return;
                }

                string userName = workingString.Substring(0, index);
                string scoreString = workingString.Substring(index + 1, (workingString.Length - index - 1)); //erase the name portion and the colon separating name from score
                int score = -1;
                if (!Int32.TryParse(scoreString, out score))
                {
                    return;
                }

                User tempUser = new User(userName);
                tempUser.Score = score;
                users.Add(tempUser);
            }
        }

        public void saveScores()
        {
            string userAndScoreString = "";

            foreach (User user in users)
            {
                userAndScoreString += user.Name + ":" + user.Score + ";";
            }

            if (userAndScoreString.Length > 1)
            {
                userAndScoreString = userAndScoreString.Substring(0, userAndScoreString.Length - 1); //need to erase the last ;, otherwise it screws up the parsing
            }

            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Remove("Previous User Scores");
            config.AppSettings.Settings.Add("Previous User Scores", userAndScoreString);
            config.Save(ConfigurationSaveMode.Minimal);
        }

        public void saveUserScore(User user) {
            string userAndScoreString = ConfigurationManager.AppSettings["Previous User Scores"];
            userAndScoreString += ";" + user.Name + ":" + user.Score;
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Remove("Previous User Scores");
            config.AppSettings.Settings.Add("Previous User Scores", userAndScoreString);
            config.Save(ConfigurationSaveMode.Minimal);
        }
        
    }
}
