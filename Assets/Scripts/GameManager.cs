using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;

    public float restartDelay = 1.5f;

    public GameObject completeLevelUI;
    public GameObject player;
    public GameObject ground;

    // When selected Normal game type.
    // Get level selected when clicked on any difficulty in Normal game type.
    public void StartNormalGame(int levelSelected)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + levelSelected);
    }

    // When selected Infinity game type.
    public void StartInfinityGame()
    {
        SceneManager.LoadScene("LevelInfinity");
    }

    // Show the compelete level screen when finished any level.
    public void CompleteLevel()
    {
        player.SetActive(false);
        ground.SetActive(false);
        completeLevelUI.SetActive(true);
    }

    // 
    public void EndGamge()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;

            // Delay before call Restart function.
            Invoke("Restart", restartDelay);
        }
    }

    //
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Quit game.
    public void QuitGame()
    {
        Application.Quit();
    }

    // Save volume value.
    public void Volume()
    {
        Debug.Log(this);
       // PlayerPrefs.SetFloat("volume", vol);
    }
}
