using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    public int maxHealth = 100;
    public float moveSpeed = 2f;

    protected int currentHealth;

    protected virtual void Start()
    {
        currentHealth = maxHealth;
    }

    protected virtual void Update()
    {
        transform.position += Vector3.right * moveSpeed * Time.deltaTime;
    }

    public virtual void TakeDamage(int amount)
    {
        currentHealth -= amount;
        Debug.Log($"{name} geraakt! Levens over: {currentHealth}");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        Debug.Log($"{name} is verslagen!");
        Destroy(gameObject);
    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<MoveProj>() != null)
        {
            TakeDamage(25);
        }
    }
}