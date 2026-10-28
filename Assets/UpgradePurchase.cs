
using UnityEngine;
using UnityEngine.InputSystem;

public class UpgradePurchase : MonoBehaviour
{
    private int count = 0;
    public int gold = 500;
    public int costPerLevel = 20;

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.rKey.wasPressedThisFrame)
        {
            count++;

            if (count == 5)
            {
                for (int level = 5; level >= 1; level--)
                {
                    int cost = costPerLevel * level;
                    gold -= cost;

                    Debug.Log($"{level}... -{cost} gold");
                }

                Debug.Log("Upgrade complete!");
                count = 0;
            }
        }
    }
}
