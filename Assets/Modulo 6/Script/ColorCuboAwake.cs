using UnityEngine;

public class ColorCuboAwake : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    // Variables booleana
    public bool estado = false;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();

        // Codigo anterior del modulo 6
        //meshRenderer.material.color = new Color(
        //    Random.value,
        //    Random.value,
        //    Random.value

        //    );
        
        meshRenderer.material.color = Color.black;

    }

    void FixedUpdate()
    {
        estado = !estado;

        if (estado)
        {
            meshRenderer.material.color = Color.white;
        }
        else
        {
            meshRenderer.material.color = Color.black;
        }
    }
}
