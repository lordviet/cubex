using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{

    bool gamehasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        Debug.Log("LEVEL WON");
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gamehasEnded == false)

        {
            gamehasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
            //The void Restart is a reference to this line over here 
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}