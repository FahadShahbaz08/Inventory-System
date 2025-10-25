using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int foodItemCount = 0;
    private int survivalItemCount = 0;

    public Dictionary<ItemType, List<Item>> _collectedItems = new Dictionary<ItemType, List<Item>>();

    private void Awake()
    {
        instance = this;
    }
    public void AddItem(Item newItem)
    {
        if (!_collectedItems.ContainsKey(newItem.type))
            _collectedItems[newItem.type] = new List<Item>();

        _collectedItems[newItem.type].Add(newItem);
    }

    public List<Item> GetItemsOfType(ItemType type)
    {
        if (_collectedItems.TryGetValue(type, out var items))
            return items;
        return new List<Item>();
    }

    public int GetTotalItemCount(ItemType type)
    {
        if (_collectedItems.TryGetValue(type, out var items))
            return items.Count;
        return 0;
    }
    public ItemType GetDicItemNumber(int num)
    {
       return _collectedItems.ElementAt(num).Key;
    }
}
