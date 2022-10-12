using System;
using TMPro;
using UnityEngine.SceneManagement;

namespace TicTacToe
{
    public class WinScreen : Screen 
    {
        public TMP_Text Text;

        public void SetWinner(SignType value) 
        {
            switch(value) 
            {
                case SignType.Cross:
                    Text.text = "RED is WIN";
                    break;
                case SignType.Ring: 
                    Text.text = "BLUE is WIN";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(value), value, null);
            }
        }

        public void OnRestartClick() 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}