
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour


{
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    // Speed at which the player moves.
    public float speed = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void FixedUpdate()

    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement*speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove(InputValue movementValue) {
        // this will set the movement vector that will assist the users move around
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
        

    }

}
