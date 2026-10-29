using UnityEngine;

public class Tower : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float radius = Random.Range(0.5f, 1.5f);
        float height = Random.Range(1f, 4f);

        transform.localScale = new Vector3(radius, height, radius);

        // Unity's default cylinder is 2 units tall, so its center sits
        // at half the (scaled) height. Lift it up by that amount:
        transform.position += Vector3.up * height;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
