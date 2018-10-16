using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    //Creating a public variable in a component script adds it to the edit pane in Unity as a variable 
    public float forwardForce = 2000;
    public float sidewaysForce = 500;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    //clear below comment to start the game with the player moving (for cinematics or what have you)
    //    rb.AddForce(0, 100, 500);
	}
	
    //GENERAL STEPS TO BUILDING A GAME:
    //1 - BUILD MAIN ASSETS (E.G. usually a main player like a block, or a few blocks, or a block and a tree etc.)
    //2 - PLAYER MOVEMENT (scripted below) - one of the first things you want to do in a game!
    //3 - ADD ELEMENTS TO INTERACT WITH
    //4 - DESIGN LEVEL
    //5 - ADD UI (E.G. TEXT, POLISH)


	// Update is called once per frame, us FixedUpdate if your method includes physics code
	void FixedUpdate ()
    {
        //Add a constant forward force to player not controlled by player input
        //Time.deltaTime is a counter that moves down the faster your computer is. So if you have a fast computer it will slow the force down
        //If you have a fast computer it will slow down the computer less
        rb.AddForce(0,0, forwardForce * Time.deltaTime);

        //PLAYER INPUTS - ALWAYS START WITH SOME SORT OF IF STATEMENT
        //If d is being pressed
        if(Input.GetKey("d"))
        {
            //Only execute if condition is met
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            //Only execute if condition is met
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1)
        {
            //Only execute if condition is met
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
