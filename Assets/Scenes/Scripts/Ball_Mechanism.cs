using UnityEngine;
using UnityEngine.InputSystem;

public class Ball_Mechanism : MonoBehaviour
{
    private Camera mainCamera;
    private Ball_Control playerInputs;
    [SerializeField] private float distanceFromCamera = 10f;

    private void Awake()
    {
        playerInputs = new Ball_Control();
    }
    private void OnEnable()
    {
        playerInputs.Player.Enable();
    }

    private void OnDisable()
    {
        playerInputs.Player.Disable();
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

        if (mainCamera == null)
        {
            mainCamera = Camera.main;

            if (mainCamera == null) return;
        }

        Vector2 screenPosition = new Vector2();

        screenPosition = playerInputs.Player.MousePosition.ReadValue<Vector2>();

        Debug.Log("Mouse x position = " + screenPosition.x + "\nMouse y position = " + screenPosition.y);

        Vector3 MousePosition = new Vector3(screenPosition.x, screenPosition.y, distanceFromCamera);

        Vector3 worldPosition = mainCamera.ScreenToWorldPoint(MousePosition);

        transform.position = worldPosition;
    }
}