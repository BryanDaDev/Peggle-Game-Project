using UnityEngine;
using UnityEngine.InputSystem;

public class Aim : MonoBehaviour
{
    private Camera mainCamera;
    private Ball_Control playerInputs;

    private void Awake()
    {
        playerInputs = new Ball_Control();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera = Camera.main;
        if (mainCamera == null)
        {
            Debug.LogError("Main Camera not found :(");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 screenPosition = playerInputs.Player.MousePosition.ReadValue<Vector2>();


    }
}