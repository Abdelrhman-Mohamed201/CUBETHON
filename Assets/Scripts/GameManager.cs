using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 1.5f;
    public GameObject completeLevelUI;
    public GameObject player;
    public GameObject ground;

    public void CompleteLevel()
    {
        player.SetActive(false);
        ground.SetActive(false);
        completeLevelUI.SetActive(true);
    }

    public void EndGamge()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER!");

            // Delay before call Restart function.
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
