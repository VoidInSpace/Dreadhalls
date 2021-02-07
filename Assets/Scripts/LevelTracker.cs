using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LevelTracker : MonoBehaviour {
    public Text levelText;
    public static int presentLevel = 1;
    // Start is called before the first frame update
    void Start()
    {
        levelText.text = "Level" + presentLevel.ToString().PadLeft(2);
    }
}