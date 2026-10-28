using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    [SerializeField] private Image itemImageHolder;

    public void ShowItem(Color color)
    {
        itemImageHolder.color = color;
        itemImageHolder.enabled = true;
    }

    public void HideItem()
    {
        itemImageHolder.color = Color.white;
        itemImageHolder.enabled = false;
    }
}