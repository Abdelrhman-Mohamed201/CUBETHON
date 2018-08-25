using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelDetect : MonoBehaviour {

    public Text levelText;

	// Use this for initialization
	void Start () {
        string currentlevel = SceneManager.GetActiveScene().buildIndex.ToString();
        levelText.text = "Level " + currentlevel;
    }
}
