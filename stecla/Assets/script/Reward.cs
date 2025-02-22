using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class RewardAdsManager : MonoBehaviour
{
    public YandexGame sdk;
    private int _money;
    public KeyCode keyToPress;

    void Update()
    {
        _money = PlayerPrefs.GetInt("balance");

        if (Input.GetKeyDown(keyToPress))
        {
            sdk._RewardedShow(1);
        }

        if (Input.GetMouseButtonDown(1))
        {

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    public void AdButton()
    {
        sdk._RewardedShow(1);
    }

    public void AdButtonCul()
    {
        _money += 200;
        PlayerPrefs.SetInt("balance", _money);
    }

}
