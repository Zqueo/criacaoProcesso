using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class tilemap_control : MonoBehaviour
{
    private TilemapRenderer tilemapRenderer;
    private TilemapCollider2D tilemapCollider;

    void Start()
    {
        tilemapRenderer = GetComponent<TilemapRenderer>();
        tilemapCollider = GetComponent<TilemapCollider2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            bool isActive = tilemapRenderer.enabled;

            // Alterna visualização
            tilemapRenderer.enabled = !isActive;

            // Alterna colisão (se existir)
            if (tilemapCollider != null)
                tilemapCollider.enabled = !isActive;
        }
    }
}