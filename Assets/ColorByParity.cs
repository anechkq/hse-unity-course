
using UnityEngine;
using UnityEngine.InputSystem;

public class ColorByParity : MonoBehaviour
{
    private int count = 0;

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.eKey.wasPressedThisFrame)
        {
            count++;

            if (count % 2 == 0)
            {
                GetComponent<Renderer>().material.color = Color.red;
                Debug.Log($"Count: {count}, color: red");
            }
            else
            {
                GetComponent<Renderer>().material.color = Color.blue;
                Debug.Log($"Count: {count}, color: blue");
            }
        }
    }
}
