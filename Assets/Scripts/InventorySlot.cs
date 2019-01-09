using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventorySlot : MonoBehaviour
{
    private Image slotImage;
    private TextMeshProUGUI countText;

    void Awake()
    {
        slotImage = GetComponentsInChildren<Image>()[1];
        countText = GetComponentInChildren<TextMeshProUGUI>();
        countText.enabled = false;
    }

    public void SetSlot(Sprite sprite, int count, bool on = true)
    {
        slotImage.enabled = on;
        countText.enabled = on && count != 0;
        slotImage.sprite = sprite;
        countText.text = count.ToString();
    }
}
