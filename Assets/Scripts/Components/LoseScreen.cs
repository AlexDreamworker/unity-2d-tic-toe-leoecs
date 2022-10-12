using UnityEngine.SceneManagement;

namespace TicTacToe
{
    public class LoseScreen : Screen
    {
        public void OnRestartClick() 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
