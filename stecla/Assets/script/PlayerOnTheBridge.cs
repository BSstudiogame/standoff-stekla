using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOnTheBridge : MonoBehaviour
{
    [SerializeField] GameObject _glassBrokenPrefab;
    [SerializeField] GameObject _canvasShop;
    [SerializeField] FirstPersonLook _firstPersonLook;

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
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Shop"))
        {
            _canvasShop.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _firstPersonLook.enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Shop"))
        {
            _canvasShop.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            _firstPersonLook.enabled = true;
        }
    }


}

