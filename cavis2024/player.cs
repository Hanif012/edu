using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Control control;

    private void Awake()
    {
        control = FindObjectOfType<Control>();
    }

    private void Update()
    {
        // Get input from Control.cs
        float horizontalInput = control.GetHorizontalInput();
        float verticalInput = control.GetVerticalInput();

        // Use the input to control the player
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        transform.Translate(movement * Time.deltaTime);
    }
}