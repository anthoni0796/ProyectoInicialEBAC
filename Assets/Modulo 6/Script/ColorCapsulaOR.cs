using UnityEngine;

public class ColorCapsulaOR : MonoBehaviour
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
    
    void FixedUpdate()
    {
        bool estadoCubo = cubo.estado;
        bool estadoEsfera = esfera.estado;

        estado = estadoCubo || estadoEsfera;


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
