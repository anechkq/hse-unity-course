
using UnityEngine;
using UnityEngine.InputSystem;

public class InventoryValue : MonoBehaviour
{
    private int count = 0;
    private int coinValue = 10;

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            count++;

            if (count == 5)
            {
                int totalValue = 0;

                for (int i = 1; i <= count; i++)
                {
                    totalValue += coinValue;
                }

                Debug.Log($"Coins: {count}, total value: {totalValue}");

                count = 0;
            }
        }
    }
}
