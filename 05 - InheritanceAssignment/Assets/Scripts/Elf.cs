using UnityEngine;

public class Elf : EnemyParent
{
    private float invisibilityInterval = 3f;
    private float invisibilityDuration = 0.5f;
    private float timer = 0f;
    private bool invisible = false;

    private Renderer elfRenderer;

    protected override void Start()
    {
        maxHealth = 30;
        moveSpeed = 0.5f;
        base.Start();

        elfRenderer = GetComponentInChildren<Renderer>();
    }

    protected override void Update()
    {
        base.Update();

        timer += Time.deltaTime;

        if (!invisible && timer >= invisibilityInterval)
        {
            ToggleVisibility();
        }
        else if (invisible && timer >= invisibilityDuration)
        {
            ToggleVisibility();
        }
    }

    private void ToggleVisibility()
    {
        invisible = !invisible;
        timer = 0f;

        if (elfRenderer != null)
        {
            elfRenderer.enabled = !invisible;
        }
    }
}