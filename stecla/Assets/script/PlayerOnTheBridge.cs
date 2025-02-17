using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOnTheBridge : MonoBehaviour
{
    [SerializeField] GameObject _glassBrokenPrefab; // ������ ��������� ������

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("FalseGlass"))
        {
            // ������� ������ � ������������� ��������� (X = 90, Y = 0, Z = 0)
            GameObject brokenGlass = Instantiate(_glassBrokenPrefab, other.transform.position, Quaternion.Euler(90, 0, 0));

            // �������� ������� ������������� ������
            brokenGlass.transform.localScale = other.transform.localScale;

            // ������� ������ ������
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
}

