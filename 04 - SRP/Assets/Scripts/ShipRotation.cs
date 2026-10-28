using UnityEngine;

public class ShipRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 25f;

    private void Update()
    {
        transform.Rotate(transform.up * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
    }

    public void IncreaseRotationSpeed(float amount)
    {
        rotationSpeed += amount;
    }
}