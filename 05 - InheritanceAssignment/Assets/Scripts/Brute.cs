using UnityEngine;

public class Brute : EnemyParent
{
    protected override void Start()
    {
        maxHealth = 500;
        moveSpeed = 0.1f;
        base.Start();
    }
}