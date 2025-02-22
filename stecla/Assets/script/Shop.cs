using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] GameObject _komanndo;
    [SerializeField] GameObject _scorpion;
    [SerializeField] GameObject _fang;
    [SerializeField] GameObject _butterfly;
    [SerializeField] GameObject _karambit;

    [SerializeField] GameObject _animkomanndo;
    [SerializeField] GameObject _animscorpion;
    [SerializeField] GameObject _animfang;
    [SerializeField] GameObject _animbutterfly;
    [SerializeField] GameObject _animkarambit;

    public Text b1;
    public Text b2;
    public Text b3;
    public Text b4;

    private int _money;


    void Start()
    {

        //starting is knife
        if (PlayerPrefs.GetInt("knife") == 1)
       {
            _komanndo.SetActive(false);
            _scorpion.SetActive(true);
            _fang.SetActive(false);
            _butterfly.SetActive(false);
            _karambit.SetActive(false);

            _animkomanndo.SetActive(false);
            _animscorpion.SetActive(true);
            _animfang.SetActive(false);
            _animbutterfly.SetActive(false);
            _animkarambit.SetActive(false);
       }
        if (PlayerPrefs.GetInt("knife") == 2)
        {
            _komanndo.SetActive(true);
            _scorpion.SetActive(false);
            _fang.SetActive(false);
            _butterfly.SetActive(false);
            _karambit.SetActive(false);

            _animkomanndo.SetActive(true);
            _animscorpion.SetActive(false);
            _animfang.SetActive(false);
            _animbutterfly.SetActive(false);
            _animkarambit.SetActive(false);
        }

        if (PlayerPrefs.GetInt("knife") == 3)
        {
            _komanndo.SetActive(false);
            _scorpion.SetActive(false);
            _fang.SetActive(true);
            _butterfly.SetActive(false);
            _karambit.SetActive(false);

            _animkomanndo.SetActive(false);
            _animscorpion.SetActive(false);
            _animfang.SetActive(true);
            _animbutterfly.SetActive(false);
            _animkarambit.SetActive(false);
        }
        if (PlayerPrefs.GetInt("knife") == 4)
        {
            _komanndo.SetActive(false);
            _scorpion.SetActive(false);
            _fang.SetActive(false);
            _butterfly.SetActive(true);
            _karambit.SetActive(false);

            _animkomanndo.SetActive(false);
            _animscorpion.SetActive(false);
            _animfang.SetActive(false);
            _animbutterfly.SetActive(true);
            _animkarambit.SetActive(false);
        }

        if (PlayerPrefs.GetInt("knife") == 5)
        {
            _komanndo.SetActive(false);
            _scorpion.SetActive(false);
            _fang.SetActive(false);
            _butterfly.SetActive(false);
            _karambit.SetActive(true);

            _animkomanndo.SetActive(false);
            _animscorpion.SetActive(false);
            _animfang.SetActive(false);
            _animbutterfly.SetActive(false);
            _animkarambit.SetActive(true);
        }


        //save buy knife
        if (PlayerPrefs.HasKey("buyOne"))
        {
            Debug.Log("main уже сделан, " + PlayerPrefs.GetInt("buyOne"));
        }
        else
        {
            PlayerPrefs.SetInt("buyOne", 0);
        }

        if (PlayerPrefs.HasKey("buyTwo"))
        {
            Debug.Log("main уже сделан, " + PlayerPrefs.GetInt("buyTwo"));
        }
        else
        {
            PlayerPrefs.SetInt("buyTwo", 0);
        }

        if (PlayerPrefs.HasKey("buyThree"))
        {
            Debug.Log(":F::F:#, " + PlayerPrefs.GetInt("buyThree"));
        }
        else
        {
            PlayerPrefs.SetInt("buyThree", 0);
        }

        if (PlayerPrefs.HasKey("buyFo"))
        {
            Debug.Log("main уже сделан, " + PlayerPrefs.GetInt("buyFo"));
        }
        else
        {
            PlayerPrefs.SetInt("buyFo", 0);
        }

    }

    void FixedUpdate()
    {
        _money = PlayerPrefs.GetInt("balance");

        b1.text = PlayerPrefs.GetInt("buyOne") == 1 ? "Применить" : "Купить (1000 G)";
        b2.text = PlayerPrefs.GetInt("buyTwo") == 1 ? "Применить" : "Купить (2200 G)";
        b3.text = PlayerPrefs.GetInt("buyThree") == 1 ? "Применить" : "Купить (5000 G)";
        b4.text = PlayerPrefs.GetInt("buyFo") == 1 ? "Применить" : "Купить (10000 G)";
    }


    public void Komanndo()
    {
        if (PlayerPrefs.GetInt("buyOne") == 1)
        {
            _komanndo.SetActive(true);
            _scorpion.SetActive(false);
            _fang.SetActive(false);
            _butterfly.SetActive(false);
            _karambit.SetActive(false);

            _animkomanndo.SetActive(true);
            _animscorpion.SetActive(false);
            _animfang.SetActive(false);
            _animbutterfly.SetActive(false);
            _animkarambit.SetActive(false);
            PlayerPrefs.SetInt("knife", 2);
        }
        else
        {
            if (PlayerPrefs.GetInt("balance") >= 1000)
            {
                _money -= 1000;
                PlayerPrefs.SetInt("balance", _money);
                PlayerPrefs.SetInt("buyOne", 1);

                _komanndo.SetActive(true);
                _scorpion.SetActive(false);
                _fang.SetActive(false);
                _butterfly.SetActive(false);
                _karambit.SetActive(false);

                _animkomanndo.SetActive(true);
                _animscorpion.SetActive(false);
                _animfang.SetActive(false);
                _animbutterfly.SetActive(false);
                _animkarambit.SetActive(false);
                PlayerPrefs.SetInt("knife", 2);
            }
        }
    }

    public void Fang()
    {
        if (PlayerPrefs.GetInt("buyTwo") == 1)
        {
            _komanndo.SetActive(false);
            _scorpion.SetActive(false);
            _fang.SetActive(true);
            _butterfly.SetActive(false);
            _karambit.SetActive(false);

            _animkomanndo.SetActive(false);
            _animscorpion.SetActive(false);
            _animfang.SetActive(true);
            _animbutterfly.SetActive(false);
            _animkarambit.SetActive(false);
            PlayerPrefs.SetInt("knife", 3);
        }
        else
        {
            if (PlayerPrefs.GetInt("balance") >= 2200)
            {
                _money -= 2200;
                PlayerPrefs.SetInt("balance", _money);
                PlayerPrefs.SetInt("buyTwo", 1);

                _komanndo.SetActive(false);
                _scorpion.SetActive(false);
                _fang.SetActive(true);
                _butterfly.SetActive(false);
                _karambit.SetActive(false);

                _animkomanndo.SetActive(false);
                _animscorpion.SetActive(false);
                _animfang.SetActive(true);
                _animbutterfly.SetActive(false);
                _animkarambit.SetActive(false);
                PlayerPrefs.SetInt("knife", 3);
            }
        }
    }

    public void Butterfly()
    {
        if (PlayerPrefs.GetInt("buyThree") == 1)
        {
            _komanndo.SetActive(false);
            _scorpion.SetActive(false);
            _fang.SetActive(false);
            _butterfly.SetActive(true);
            _karambit.SetActive(false);

            _animkomanndo.SetActive(false);
            _animscorpion.SetActive(false);
            _animfang.SetActive(false);
            _animbutterfly.SetActive(true);
            _animkarambit.SetActive(false);
            PlayerPrefs.SetInt("knife", 4);
        }

        else
        {
            if (PlayerPrefs.GetInt("balance") >= 5000)
            {
                _money -= 5000;
                PlayerPrefs.SetInt("balance", _money);
                PlayerPrefs.SetInt("buyThree", 1);

                _komanndo.SetActive(false);
                _scorpion.SetActive(false);
                _fang.SetActive(false);
                _butterfly.SetActive(true);
                _karambit.SetActive(false);

                _animkomanndo.SetActive(false);
                _animscorpion.SetActive(false);
                _animfang.SetActive(false);
                _animbutterfly.SetActive(true);
                _animkarambit.SetActive(false);
                PlayerPrefs.SetInt("knife", 4);
            }
        }
    }

    public void Karambit()
    {
        if (PlayerPrefs.GetInt("buyFo") == 1)
        {
            _komanndo.SetActive(false);
            _scorpion.SetActive(false);
            _fang.SetActive(false);
            _butterfly.SetActive(false);
            _karambit.SetActive(true);

            _animkomanndo.SetActive(false);
            _animscorpion.SetActive(false);
            _animfang.SetActive(false);
            _animbutterfly.SetActive(false);
            _animkarambit.SetActive(true);
            PlayerPrefs.SetInt("knife", 5);
        }

        else
        {
            if (PlayerPrefs.GetInt("balance") >= 10000)
            {
                _money -= 10000;
                PlayerPrefs.SetInt("balance", _money);
                PlayerPrefs.SetInt("buyFo", 1);

                _komanndo.SetActive(false);
                _scorpion.SetActive(false);
                _fang.SetActive(false);
                _butterfly.SetActive(false);
                _karambit.SetActive(true);

                _animkomanndo.SetActive(false);
                _animscorpion.SetActive(false);
                _animfang.SetActive(false);
                _animbutterfly.SetActive(false);
                _animkarambit.SetActive(true);
                PlayerPrefs.SetInt("knife", 5);
            }
        }
    }
}
