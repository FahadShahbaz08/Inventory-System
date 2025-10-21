using UnityEngine;
using static UnityEngine.UI.Image;

public class RayThrowringSystem : MonoBehaviour
{
    [SerializeField] float distance = 1f;
    [SerializeField] Vector3 offset;
    private void Update()
    {
        ThrowRay();
    }

    private void ThrowRay()
    {
        Vector3 startPos = transform.position + offset;
        Vector3 endPos = transform.forward;

        Ray ray = new Ray (startPos, endPos);
        if (Physics.Raycast(ray, out RaycastHit hitInfo, distance))
        {
            Item interactedItem = hitInfo.transform.GetComponent<Item>();
            if (interactedItem != null)
            {
                UiManager.instance.ShowInteractVisual("Press to collect "+ interactedItem.GetItemName());
                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactedItem.Collect();
                }
            }
        }
        else
        {
            UiManager.instance.HideInteractVisual();
        }

            Debug.DrawLine(startPos, startPos + endPos * distance, Color.red);
    }
}
