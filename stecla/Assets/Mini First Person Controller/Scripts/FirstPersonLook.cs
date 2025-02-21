using UnityEngine;

public class FirstPersonLook : MonoBehaviour
{
    [SerializeField]
    Transform character;
    public float sensitivity = 2;
    public float smoothing = 1.5f;
    public Joystick joystickCamera;

    Vector2 velocity;
    Vector2 frameVelocity;

    void Reset()
    {
        character = GetComponentInParent<FirstPersonMovement>().transform;
    }

    void Start()
    {
        // Lock the cursor to the center of the screen if not on Android
        if (!GameManager.Instance.isAndroid)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    void Update()
    {
        Vector2 inputDelta;

        if (GameManager.Instance.isAndroid)
        {
            // Use joystick input for Android
            inputDelta = new Vector2(joystickCamera.Horizontal, joystickCamera.Vertical);
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            // Use mouse input for non-Android platforms
            inputDelta = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        }

        // Calculate frame velocity and apply smoothing
        Vector2 rawFrameVelocity = Vector2.Scale(inputDelta, Vector2.one * sensitivity);
        frameVelocity = Vector2.Lerp(frameVelocity, rawFrameVelocity, 1 / smoothing);
        velocity += frameVelocity;

        // Clamp vertical rotation to avoid flipping
        velocity.y = Mathf.Clamp(velocity.y, -90, 90);

        // Apply rotation to the camera and character
        transform.localRotation = Quaternion.AngleAxis(-velocity.y, Vector3.right);
        character.localRotation = Quaternion.AngleAxis(velocity.x, Vector3.up);
    }
}