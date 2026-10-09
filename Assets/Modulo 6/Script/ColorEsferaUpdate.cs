using UnityEngine;

public class ColorEsferaUpdate : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        meshRenderer.material.color = new Color(
            Random.value,
            Random.value,
            Random.value
        );
    }
}
