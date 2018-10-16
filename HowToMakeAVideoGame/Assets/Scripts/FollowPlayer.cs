using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    //Transform is the name of the component that controls all of the position, rotation, and scale metrics for Player and other objects
    //However, just writing this line isn't enough! You have to tell the script WHICH OBJECT it should pull Transform data from
    //Do this in Unity! Ensure the FollowPlayer component is active on the Main Camera (click and drag if not)
    //Then drag the Player name in the Hierarchy pane to the "Player" box in the FollowScript component
    //Now the "player" variable below refers to the Player object in the game
    public Transform player;
    //Vector3 stores 3 floats, which makes it good for storing POSITIONAL DATA
    //Use this variable to adjust the camera's position from / interaction with the player during gameplay
    public Vector3 offset;

	// Use this for initialization
	//void Start () {
		
	//}
	
	// Update is called once per frame
	void Update ()
    {
        //If you're working with numbers and want to see numbers Unity is pulling, use code similar to the one below
        //Shows the Player object's postion in the Console
        //Debug.Log(player.position);

        //lower case transform refers to the Transform data on the current object that the script has been dragged onto (e.g. the main camera)
        //recall that "player" is a public variable you created above and then hooked to the Player object in Unity by dragging
        //Note that you could use transform.position to move the camera (or any current object) anywhere in the world
        transform.position = player.position + offset;
	}
}
