using UnityEngine;

public class S_GameOverMenuButtonScript : MonoBehaviour
{
    public void RestartButton()
    {
        
        GameManager.Instance.SwitchState<PlayingState>();
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameLevel");
    }
    
    public void MainMenuButton()
    {
        GameManager.Instance.SwitchState<PlayingState>();
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
    }
}
