using UnityEngine;
//WHENEVER YOU ADD TEXT OR OTHER UI ELEMENTS, ADD UNITYENGINE.UI
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    //References the Text component on the Text object
    public Text score;

	// Use this for initialization
	void Start () {
        score = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        //scoreText (or publicobjectText) allows you to change the actual text, size, color, and do all the things the Text component can do
        //Make sure you convert the player position to a string!
        score.text = player.position.z.ToString("0");
	}
}
