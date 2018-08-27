using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        // "0" to round the number.
        scoreText.text = player.position.z.ToString("0");
    }
}
