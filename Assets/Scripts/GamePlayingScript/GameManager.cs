using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject _ReadyImage;
    public GameObject _StartImage;

    private int _temptime = 0;

    public static bool inGame;

    private void Awake()
    {
        inGame = false;
        GameOverManager._gameOver = false;
    }
    private void Start()
    {
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
                _ReadyImage.SetActive(true);
                break;
            case 2:
                _ReadyImage.SetActive(true);
                break;
            case 3:
                _ReadyImage.SetActive(false);
                _StartImage.SetActive(true);
                inGame = true;
                Time.timeScale = 1;
                break;
            case 4:
                _StartImage.SetActive(false);
                break;
        }
    }
}
