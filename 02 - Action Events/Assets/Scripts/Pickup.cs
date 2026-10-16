using System;
using UnityEngine;


public class Pickup : MonoBehaviour
{
    public static event Action<int> OnPickupCollected;

    [SerializeField] public int points = 50; // per pickup instelbaar in de Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log($"[{gameObject.name}] sent {points} points");
            OnPickupCollected?.Invoke(points);
            Destroy(gameObject);
        }
    }
}