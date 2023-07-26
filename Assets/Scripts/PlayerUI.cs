using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    private void OnEnable()
    {
        Item.OnItemCollected += ItemUI;
    }

    private void ItemUI()
    {
        Debug.Log("Item UI enabled");
    }

    private void OnDisable()
    {
        Item.OnItemCollected -= ItemUI;
    }

}
