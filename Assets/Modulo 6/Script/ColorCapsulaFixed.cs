using UnityEngine;

public class ColorCapsulaFixed : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    // Scripts de los Cubos y la Esfera

    public ColorCuboAwake cubo;
    public ColorEsferaUpdate esfera;

    // Variables booleana

    public bool estado = false;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.color = Color.black;
    }
    /*
     // Codigo anterior del modulo 6
    void FixedUpdate()
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
        bool estadoCubo = cubo.estado;
        bool estadoEsfera = esfera.estado;

        estado = estadoCubo && estadoEsfera;


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
