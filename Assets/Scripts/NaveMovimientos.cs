
using UnityEngine;

public class NaveMovimientos : MonoBehaviour
{
    private Rigidbody2D rb;
    public float fuerza = 25f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up * fuerza, ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down * fuerza, ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * fuerza, ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * fuerza, ForceMode2D.Force);
        }
    }
}
