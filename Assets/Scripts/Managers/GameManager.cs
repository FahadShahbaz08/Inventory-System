using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int foodItemCount = 0;
    private int survivalItemCount = 0;
    private void Awake()
    {
        instance = this;
    }
    public void IterateFoodCount()
    {
        foodItemCount++;
    }

    public void IterateSurvivalCount()
    {
        survivalItemCount++;
    }

    public int GetFoodItemCount()
    {
        return foodItemCount;
    }

    public int GetSurvivalItemCount()
    {
        return survivalItemCount;
    }
}
