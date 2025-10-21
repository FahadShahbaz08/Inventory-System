using UnityEngine;

public class FoodItem : Item
{
    public override void Interact()
    {
        print($"{itemName} is interacted");
    }

    public override void Collect()
    {
        print($"{itemName} is collected");
        GameManager.instance.IterateFoodCount();
        Destroy(this.gameObject);
    }
}
