using UnityEngine;

public class Item : MonoBehaviour, ICollectable, IInteractable
{
    [SerializeField] internal string itemName;
    public ItemType type;
    public virtual void Interact() {}

    public virtual void Collect() {}

    public string GetItemName()
    {
        return itemName;
    }
}
