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
        if(characterController.transform.position.y < -10)
        {
            Destroy(GameObject.Find("WhisperSource"));
            LevelCounter.level = 1;
            SceneManager.LoadScene("End");
        }
    }
}