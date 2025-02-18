using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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





    public void Komanndo()
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

    public void Fang()
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

    public void Butterfly()
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

    public void Karambit()
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
}
