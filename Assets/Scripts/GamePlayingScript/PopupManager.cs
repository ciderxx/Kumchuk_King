using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupManager : MonoBehaviour {

    public GameObject _Setting;

    private bool isPause;

    public void Setting()
    {
        isPause = true;
        _Setting.SetActive(!_Setting.active);

        if (isPause)
        {
            Time.timeScale = 0;
        }
    }

    public void isGameStart()
    {
        isPause = false;
        _Setting.SetActive(!_Setting.active);

        if (!isPause)
        {
            Time.timeScale = 1;
        }
    }
}
