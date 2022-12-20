using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

[ExecuteAlways]
public class CoordinateSystem : MonoBehaviour
{

    TextMeshPro label;
    Vector2Int coords = new Vector2Int();

    private void Awake()
    {
        label = GetComponent<TextMeshPro>();
        DisplayCoordinates();
    }
    // Update is called once per frame
    void Update()
    {
        if(!Application.isPlaying)
        {
            DisplayCoordinates();
            UpdateName();
        }
    }

    void DisplayCoordinates()
    {
        coords.x = (int)(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        coords.y = (int)(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);

        label.text = coords.x + "," + coords.y;
    }

    void UpdateName()
    {
        transform.parent.name = coords.ToString();
    }
}
