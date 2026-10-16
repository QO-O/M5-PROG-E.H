using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal"); // A/D
        float z = Input.GetAxis("Vertical");   // W/S

        Vector3 movement = new Vector3(x, 0f, z) * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }
}