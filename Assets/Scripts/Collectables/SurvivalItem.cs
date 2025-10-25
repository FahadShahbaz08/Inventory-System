using UnityEngine;

public class SurvivalItem : Item
{
    public override void Interact()
    {
        print($"{itemName} is interacted");
    }

    public override void Collect()
    {
        print($"{itemName} is collected");
        //GameManager.instance.IterateSurvivalCount();
        GameManager.instance.AddItem(this);
        Destroy( this.gameObject );
    }
}
