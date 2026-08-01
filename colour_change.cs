using UnityEngine;

public class ContinuousColorChange : MonoBehaviour
{
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float hue = (Time.time * 0.5f) % 1f;
        Color color = Color.HSVToRGB(hue, 1f, 1f);

        rend.material.SetColor("_BaseColor", color); // URP fix
    }
}