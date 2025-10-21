using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController characterController;
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float rotSpeed = 10f;

    private float currentVelocity;
    private float fallingVelocity;

    private void Update()
    {
        MoveInput();
        ApplyGravity();
    }

    private void MoveInput()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticleInput = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3 (horizontalInput,0, verticleInput);
        Rotate(dir);
        Move(dir);
        
    }
    private void Move(Vector3 dir)
    {
        characterController.Move(dir * moveSpeed * Time.deltaTime);
    }

    private void Rotate(Vector3 rotDir)
    {
        if (rotDir.sqrMagnitude == 0) return;  

        float targetAngle = Mathf.Atan2(rotDir.x, rotDir.z) * Mathf.Rad2Deg;

        float smoothTime = 0.1f;
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref currentVelocity, smoothTime);

        transform.rotation = Quaternion.Euler(0, angle, 0);
    }


    private void ApplyGravity()
    {
        float gravity = -9.81f;

        if (!characterController.isGrounded)
        {
            fallingVelocity += gravity * Time.deltaTime;
            characterController.Move(new Vector3(0, fallingVelocity * Time.deltaTime, 0));
        }
        else
        {
            currentVelocity = -1f;
        }
    }

}
