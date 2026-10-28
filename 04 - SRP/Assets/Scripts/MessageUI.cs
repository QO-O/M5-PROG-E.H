using System.Collections;
using TMPro;
using UnityEngine;

public class MessageUI : MonoBehaviour
{
    [SerializeField] private TMP_Text introductionField;
    [SerializeField] private TMP_Text messageField;

    private void Start()
    {
        StartCoroutine(ShowText(introductionField,
            "Welcome to Space 4 8. \n Move your ship with the arrows or WASD. \n Shoot with SPACE. \n Gather pickups and cycle with 'Left CTR'.  \n  Use pickups with 'E'.",
            5f));
    }

    public void ShowMessage(string message)
    {
        StartCoroutine(ShowText(messageField, message, 3f));
    }

    private IEnumerator ShowText(TMP_Text field, string text, float seconds)
    {
        field.enabled = true;
        field.text = text;
        yield return new WaitForSeconds(seconds);
        field.enabled = false;
    }
}