using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	/*void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	} */

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}


