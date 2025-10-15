using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform followTarget;
    [SerializeField] Vector3 offset;
    private void LateUpdate()
    {
        transform.position = (followTarget.position + offset);
    }
}
