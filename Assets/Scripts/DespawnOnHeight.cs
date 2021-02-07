using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class DespawnOnHeight : MonoBehaviour {
    public GameObject characterController;

    //Initialization
    void Start() {

    }

    void Update () {
        if(gameObject.transform.position.y < 0)
        {
            Destroy(GameObject.Find("WhisperSource"));
            LevelTracker.presentLevel = 1;
            SceneManager.LoadScene("GameOver");
        }
    }
}