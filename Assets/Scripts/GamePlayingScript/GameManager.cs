using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private int _temptime = 0;

    public static bool inGame;

    void Start()
    {
        inGame = false;
        _temptime = System.DateTime.Now.Second;
        Time.timeScale = 0;
    }

    void Update()
    {
        GameDelay();
    }

    public void GameDelay()
    {
        switch (System.DateTime.Now.Second - _temptime)
        {
            case 1:
                Debug.Log("ready");
                break;
            case 2:
                Debug.Log("ready2");
                break;
            case 3:
                inGame = true;
                Debug.Log("Start");
                Time.timeScale = 1;
                break;
        }
    }
}
