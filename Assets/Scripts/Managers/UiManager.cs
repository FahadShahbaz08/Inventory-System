using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;
    [SerializeField] private GameObject interactVisuals;
    [SerializeField] private TextMeshProUGUI interactText;
    [SerializeField] private GameObject inventoryPanel;
    [SerializeField] private Transform inventoryContent;
    [SerializeField] private GameObject foodItemVisual;
    [SerializeField] private GameObject survivalItemVisual;
    private void Awake()
    {
        instance = this;
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            ShowInventoryPanel();
        }
        else if (Input.GetKey(KeyCode.Escape))
        {
            HideInventoryPanel();
        }
    }
    public void ShowInteractVisual(string text)
    {
        interactVisuals.SetActive(true);
        interactText.text = text;
    }

    public void HideInteractVisual()
    {
        interactVisuals.SetActive(false);
    }

    public void ShowInventoryPanel()
    {
        inventoryPanel.SetActive(true);
        foreach(Transform go in inventoryContent)
        {
            Destroy(go.gameObject);
        }

        if (GameManager.instance.GetFoodItemCount() > 0)
        {
            for (int i = 0; i < GameManager.instance.GetFoodItemCount(); i++)
            {
                Instantiate(foodItemVisual, inventoryContent);
            }
        }

        if (GameManager.instance.GetSurvivalItemCount() > 0)
        {
            for (int i = 0; i < GameManager.instance.GetSurvivalItemCount(); i++)
            {
                Instantiate(survivalItemVisual, inventoryContent);
            }
        }

    }

    public void HideInventoryPanel()
    {
        inventoryPanel.SetActive(false);
    }
}
