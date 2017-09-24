using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour {

    public static bool _gameOver;

    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        if (HungerBar._gameOver)
        {
            GameOver();
        }
        else
            return;

        Debug.Log(_gameOver);
	}

    public void GameOver()
    {
        GameManager.inGame = false;
        _gameOver = true;
        Invoke("GameOverNextScene",5.0f);
    }

    private void GameOverNextScene()
    {
        SceneManager.LoadScene(5);
    }
}
