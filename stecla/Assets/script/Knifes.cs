using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Knifes : MonoBehaviour
{
    public Text Balance;
    public Text Maining;
    private int MainInt = 1;
    private int BalanceInt;
    private float timer3;

    void Start()
    {
        if (PlayerPrefs.HasKey("main"))
        {
            Debug.Log("main ףזו סהוכאם, " + PlayerPrefs.GetInt("main"));
        }
        else
        {
            PlayerPrefs.SetInt("main", 1);

        }
    }

    void FixedUpdate()
    {
        MainInt = PlayerPrefs.GetInt("main");

        timer3 += Time.deltaTime;
        if (timer3 > 1.5f)
        {
            BalanceInt += MainInt;
            PlayerPrefs.SetInt("balance", BalanceInt);
            timer3 = 0;
        }

        BalanceInt = PlayerPrefs.GetInt("balance");
        Balance.text = "ְֲ״ ׁ׳ֵׂ: " + BalanceInt.ToString() + " G";
        Maining.text = "ְֳָֹּֽֽ: " + MainInt.ToString() + " G/סוך";

     
    }
}
