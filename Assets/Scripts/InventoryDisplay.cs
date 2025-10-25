using TMPro;
using UnityEngine;

public class InventoryDisplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI itemName;
    [SerializeField] TextMeshProUGUI itemCount;

    public void SetInventoryItemDisplay(string name, int count)
    {
        itemName.text = name;
        itemCount.text = count.ToString();
    }
}
