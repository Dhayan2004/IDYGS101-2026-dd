
using UnityEngine;
using UnityEngine.InputSystem;

public class CambioColorInput : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public void OnChangeColor(InputValue value)
    {
        if (value.isPressed)
        {
            spriteRenderer.color = Color.red;
        }
    }
}
