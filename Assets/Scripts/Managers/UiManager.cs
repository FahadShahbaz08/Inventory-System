using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;
    [SerializeField] private GameObject interactVisuals;
    [SerializeField] private TextMeshProUGUI interactText;
    [SerializeField] private GameObject inventoryPanel;
    [SerializeField] private Transform inventoryContent;
    [SerializeField] private InventoryDisplay inventoryDisplay;

    private GameManager gameManager;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        gameManager = GameManager.instance;
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
        for(int i =0; i< gameManager._collectedItems.Count; i++)
        {
            print("hehe item is " + gameManager.GetTotalItemCount(gameManager.GetDicItemNumber(i)));
            GameObject go = Instantiate(inventoryDisplay.gameObject, inventoryContent);
            go.GetComponent<InventoryDisplay>().SetInventoryItemDisplay(gameManager.GetDicItemNumber(i).HumanName(),gameManager.GetTotalItemCount(gameManager.GetDicItemNumber(i)));

        }
    }

    public void HideInventoryPanel()
    {
        inventoryPanel.SetActive(false);
    }
}
