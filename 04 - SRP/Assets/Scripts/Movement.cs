using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private bool useVerticalInput = false;

    private void Update()
    {
        float input = useVerticalInput ? Input.GetAxis("Vertical") : 1f;
        transform.position = transform.position + transform.forward * moveSpeed * input * Time.deltaTime;
    }

    public void IncreaseMoveSpeed(float amount)
    {
        moveSpeed += amount;
    }
}