using UnityEngine;
using UnityEngine.UI;

public class SimpleButtonKeyListener : MonoBehaviour
{
    public KeyCode keyToPress = KeyCode.Space; 
    public Button buttonToActivate;
    public Button buttonToActivate2;
    public Button buttonToActivate3;
    public Button buttonToActivate4;
    public Button buttonToActivate5;

    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
                buttonToActivate.onClick.Invoke();
        }

        if (Input.GetKeyDown(keyToPress))
        {
            buttonToActivate2.onClick.Invoke();
        }

        if (Input.GetKeyDown(keyToPress))
        {
            buttonToActivate3.onClick.Invoke();
        }

        if (Input.GetKeyDown(keyToPress))
        {
            buttonToActivate4.onClick.Invoke();
        }

        if (Input.GetKeyDown(keyToPress))
        {
            buttonToActivate5.onClick.Invoke();
        }
    }
}