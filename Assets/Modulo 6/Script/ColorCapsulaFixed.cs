using UnityEngine;

public class ColorCapsulaFixed : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void FixedUpdate()
    {
        meshRenderer.material.color = new Color(
            Random.value,
            Random.value,
            Random.value
        );
    }
}
