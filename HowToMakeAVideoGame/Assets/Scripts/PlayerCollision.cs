using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    // Use this for initialization
    void Start () {
        movement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    //void Update ()
    //{

    //}

    private void OnCollisionEnter(Collision collisioninfo)
    {
        //collider gives you info that would be in the Box Collider pane. It has all sorts of info! Including name
        //So this will currently show us the name of what the Player collided with, since this script is sitting on the Player object
        //Debug.Log(collisioninfo.collider.name);

        if (collisioninfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; //Disable player movement upon hitting object
            FindObjectOfType<GameManager>().EndGame();//If we hit obstacles, stop movement and run End Game script
        }
    }
}
