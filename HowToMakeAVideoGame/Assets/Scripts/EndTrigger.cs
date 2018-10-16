using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;

    // Use this for initialization
    //void Start () {

    //}

    // Update is called once per frame
    //void Update () {

    //}



    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
