using UnityEngine;

public class ColorCuboAwake : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();

        meshRenderer.material.color = new Color(
            Random.value,
            Random.value,
            Random.value


            );
    }
}
