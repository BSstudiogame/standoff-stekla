using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Text Balance;

    void Start()
    {
        if (PlayerPrefs.HasKey("balance"))
        {
            Debug.Log("—чет уже сделан, " + PlayerPrefs.GetInt("balance"));
        }
        else
        {
            PlayerPrefs.SetInt("balance", 0);

        }
    }

  
    void FixedUpdate()
    {
        Balance.text = PlayerPrefs.GetInt("balance").ToString() + " G";
    }


   public void StartingGame()
   {

   }
}
