using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOnTheBridge : MonoBehaviour
{
    [SerializeField] GameObject _glassBrokenPrefab;
    [SerializeField] GameObject _canvasShop;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("FalseGlass"))
        {
            GameObject brokenGlass = Instantiate(_glassBrokenPrefab, other.transform.position, Quaternion.Euler(90, 0, 0));
            brokenGlass.transform.localScale = other.transform.localScale;
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DeathZone"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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

}

