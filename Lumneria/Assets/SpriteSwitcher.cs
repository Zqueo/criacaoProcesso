using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwitcher : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Pega o componente SpriteRenderer do objeto
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Verifica se o botão Fire1 foi pressionado neste frame
        if (Input.GetButtonDown("Fire1"))
        {
            // Alterna o estado do SpriteRenderer
            spriteRenderer.enabled = !spriteRenderer.enabled;
        }
    }
}
