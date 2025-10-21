using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;
    [SerializeField] private GameObject interactVisuals;
    [SerializeField] private TextMeshProUGUI interactText;

    private void Awake()
    {
        instance = this;
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
}
