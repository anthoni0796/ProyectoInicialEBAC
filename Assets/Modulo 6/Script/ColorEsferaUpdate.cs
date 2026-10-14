using UnityEngine;

public class ColorEsferaUpdate : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    //Variables booleana
    public bool estado = false;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();

        meshRenderer.material.color = Color.black;
    }
    /*
     // Codigo anterior del modulo 6
    void Update()
    {
        meshRenderer.material.color = new Color(
            Random.value,
            Random.value,
            Random.value
        );
    }
    */
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
