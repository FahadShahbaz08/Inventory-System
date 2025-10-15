using UnityEngine;

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
        Ray ray = new Ray (transform.position + offset, transform.forward * distance);
        if (Physics.Raycast(ray, out RaycastHit hitInfo))
        {
            print(hitInfo.transform.gameObject.name);
        }

        Debug.DrawLine(transform.position + offset, transform.forward * distance, Color.red);
    }
}
