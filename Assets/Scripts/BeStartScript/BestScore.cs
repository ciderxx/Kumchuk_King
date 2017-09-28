using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour {

    public Text _bestScore;

    private int _finalScore;

	// Use this for initialization
	void Start () {
        _bestScore.text = _finalScore.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void bestScore()
    {
        _finalScore = PlayerPrefs.GetInt("LastScore");
        PlayerPrefs.Save();
    }
}
