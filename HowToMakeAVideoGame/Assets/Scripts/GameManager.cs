using UnityEngine;
using UnityEngine.SceneManagement;//reload or start a new scene

public class GameManager : MonoBehaviour {

    public float restartDelay = 1;
    public GameObject completeLevelUI;

    // Use this for initialization
    //void Start () {

    //}

    // Update is called once per frame
    //void Update () {

    //}

    bool gameHasEnded = false;//switch to ensure game ends once

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame ()//ensure this is public
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);//invoke delays the launch of the Restart Method
        }
   }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//load the scene that's currently active = RELOAD
    }
}
