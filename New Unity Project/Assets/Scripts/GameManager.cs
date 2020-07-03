using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject winLevelUI;
    public GameObject scoreUI;

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;

            Debug.Log("GAME OVER");
            //restart game - function defined below
            Invoke("Restart", restartDelay);
        }  
    }
    
    public void WinGame()
    {
        winLevelUI.SetActive(true);
        Invoke("Restart", restartDelay);
    }
}
