
using UnityEngine;
using UnityEngine.InputSystem;

public class TwoKeyCounter : MonoBehaviour
{
    private int count = 0;

    void Update()
    {
        if (Keyboard.current == null)
        {
            return;
        }

        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            count++;
            Debug.Log($"Count: {count}");
        }
        else if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            count--;
            Debug.Log($"Count: {count}");
        }
        else
        {
            return;
        }

        if (count < 0)
        {
            Debug.Log("Negative!");
            count = 0;
        }
        else if (count == 5)
        {
            Debug.Log("Max reached!");
            count = 0;
        }
    }
}
