using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Renderer objRenderer;

    void Start()
    {
        objRenderer = GetComponent<Renderer>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("color"))
        {
            ChangeColor();
            Destroy(other.gameObject); // Destroy the coin
        }
    }

    void ChangeColor()
    {
        objRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }
}