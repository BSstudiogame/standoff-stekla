using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOnTheBridge : MonoBehaviour
{
    [SerializeField] GameObject _glassBrokenPrefab;
    [SerializeField] GameObject _canvasShop;
    private bool Auts = false;
    private bool _chooseRespawn = false;
    private float _timeForRespawn = 0.0f;
    public Vector3 teleportCoordinates;
    public GameObject player;
    public GameObject panel;

    void FixedUpdate()
    {
        if (Auts)
        {
            if(_timeForRespawn >= 1.5f)
            {
                Respawn();
            }

            _timeForRespawn += Time.deltaTime;
          
        }


        if (Input.GetKey(KeyCode.P))
        {
            MenuLoad();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("FalseGlass"))
        {
            GameObject brokenGlass = Instantiate(_glassBrokenPrefab, other.transform.position, Quaternion.Euler(90, 0, 0));
            brokenGlass.transform.localScale = other.transform.localScale;
            other.gameObject.SetActive(false); 
            StartCoroutine(ReactivateGlass(other.gameObject, 2f)); 
            Auts = true;
            panel.SetActive(true);
        }
    }

    private IEnumerator ReactivateGlass(GameObject glass, float delay)
    {
        yield return new WaitForSeconds(delay); 
        glass.SetActive(true); 
    }

    public void Respawn()
    {
        player.transform.position = teleportCoordinates;
        Auts = false;
        panel.SetActive(false);
        _timeForRespawn = 0.0f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DeathZone"))
        {
            player.transform.position = teleportCoordinates;
        }
        else if (other.gameObject.CompareTag("Level2"))
        {
            if (PlayerPrefs.GetInt("main") > 3)
            {
                Debug.Log("not");
            }
            else
            {
                PlayerPrefs.SetInt("main", 3);
            }
        }
        else if (other.gameObject.CompareTag("Level3"))
        {
            if (PlayerPrefs.GetInt("main") > 6)
            {
                Debug.Log("not");
            }
            else
            {
                PlayerPrefs.SetInt("main", 6);
            }
        }
        else if (other.gameObject.CompareTag("Level4"))
        {
            if (PlayerPrefs.GetInt("main") > 9)
            {
                Debug.Log("not");
            }
            else
            {
                PlayerPrefs.SetInt("main", 9);
            }
        }
        else if (other.gameObject.CompareTag("level5"))
        {
            if (PlayerPrefs.GetInt("main") > 12)
            {
                Debug.Log("not");
            }
            else
            {
                PlayerPrefs.SetInt("main", 12);
            }
        }
        else if (other.gameObject.CompareTag("Level6"))
        {
            if (PlayerPrefs.GetInt("main") > 15)
            {
                Debug.Log("not");
            }
            else
            {
                PlayerPrefs.SetInt("main", 15);
            }
        }
        else if (other.gameObject.CompareTag("Level7"))
        {
            if (PlayerPrefs.GetInt("main") > 18)
            {
                Debug.Log("not");
            }
            else
            {
                PlayerPrefs.SetInt("main", 18);
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Shop"))
        {
            _canvasShop.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Shop"))
        {
            _canvasShop.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    public void MenuLoad()
    {
        SceneManager.LoadScene(0);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}