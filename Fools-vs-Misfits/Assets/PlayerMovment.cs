using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovment : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movespeed = 5f;

    float HorizontalMovment;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(HorizontalMovment * movespeed, rb.linearVelocity.y);
    }

    public void Move(InputAction.CallbackContext context)
    {
        HorizontalMovment = context.ReadValue<Vector2>().x;
    }
}
