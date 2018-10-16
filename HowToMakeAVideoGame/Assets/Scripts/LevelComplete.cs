 using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

	// Use this for initialization
	//void Start () {
		
	//}
	
	// Update is called once per frame
	///void Update () {
		
	//}

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
