using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce; // f character to knows Unity that number is a float.
    public float sidewaysForce;

    void Start()
    {
        //Debug.Log(FindObjectOfType<GameManager>().level);
        rb.drag = 1;
        // forwardForce = 4000f * (SceneManager.GetActiveScene().buildIndex + 1);
        forwardForce = 6000f;
        sidewaysForce = 100f;
    }

    // We marked this as "Fixed" Update because we
    // are using it to mess with physics.
    void FixedUpdate()
    {

        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d") || Input.GetKey("right")) // If the player is pressing the "d" key.
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a") || Input.GetKey("left")) // If the player is pressing the "a" key.
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //if (Input.GetKey("space"))
        //{
        //    rb.AddForce(0, 100f * Time.deltaTime, 0, ForceMode.VelocityChange);
        //}

        if (rb.position.y < -1)
        {
            // To select the GameManager object.
            FindObjectOfType<GameManager>().EndGamge();
        }
    }
}
