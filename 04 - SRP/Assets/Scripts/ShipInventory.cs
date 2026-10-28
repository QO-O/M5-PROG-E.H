using System.Collections.Generic;
using UnityEngine;

public class ShipInventory : MonoBehaviour
{
    [SerializeField] private MessageUI messageUI;
    [SerializeField] private ItemUI itemUI;

    private Movement movement;
    private ShipRotation rotation;
    private ShipShooting shooting;

    private List<Color> items = new List<Color>();
    private int activeItemIndex = -1;

    private void Awake()
    {
        movement = GetComponent<Movement>();
        rotation = GetComponent<ShipRotation>();
        shooting = GetComponent<ShipShooting>();
    }

    private void Update()
    {
        CycleItems();
        UseItem();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            PickUpItem(other.gameObject);
        }
    }

    private void PickUpItem(GameObject item)
    {
        Color color = item.GetComponent<Renderer>().material.color;
        Destroy(item);

        items.Add(color);
        activeItemIndex = items.Count - 1;
        itemUI.ShowItem(items[activeItemIndex]);
    }

    public void CycleItems()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (items.Count > 0)
            {
                activeItemIndex = (activeItemIndex < items.Count - 1) ? activeItemIndex + 1 : 0;
                itemUI.ShowItem(items[activeItemIndex]);
            }
            else
            {
                activeItemIndex = -1;
                itemUI.HideItem();
            }
        }
    }

    public void UseItem()
    {
        if (Input.GetKeyDown(KeyCode.E) && items.Count > 0 && activeItemIndex != -1)
        {
            if (items[activeItemIndex] == Color.blue)
            {
                messageUI.ShowMessage(" +  Move Speed");
                movement.IncreaseMoveSpeed(5);
            }
            else if (items[activeItemIndex] == Color.red)
            {
                messageUI.ShowMessage(" + Fire Rate");
                shooting.ReduceCooldownTime(0.1f);
            }
            else if (items[activeItemIndex] == Color.green)
            {
                messageUI.ShowMessage(" + Rotation Speed");
                rotation.IncreaseRotationSpeed(10);
            }

            items.RemoveAt(activeItemIndex);

            if (activeItemIndex > 0)
            {
                activeItemIndex--;
                itemUI.ShowItem(items[activeItemIndex]);
            }
            else if (items.Count == 0)
            {
                activeItemIndex = -1;
                itemUI.HideItem();
            }
        }
    }
}