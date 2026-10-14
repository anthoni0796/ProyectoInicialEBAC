
using UnityEngine;

public class ColorCuboFinal : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    // resultados anteriores
    public ColorCapsulaFixed capsulaAND;
    public ColorCapsulaOR capsulaOR;

    public bool estado = false;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.color = Color.black;
    }

    void FixedUpdate()
    {
        // resultados de AND y OR
        bool resultadoAND = capsulaAND.estado;
        bool resultadoOR = capsulaOR.estado;

        estado = resultadoAND && resultadoOR;

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
