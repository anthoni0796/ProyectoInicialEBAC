using UnityEngine;

public class GenerarCuboUpdate : MonoBehaviour
{
    [SerializeField] private GameObject cuboPrefab;

    private float tiempo = 0f;
    private int cantidadCubos = 0;

    void Update()
    {
        if (cuboPrefab == null)
            return;

        tiempo += Time.deltaTime;

        if (tiempo >= 1f && cantidadCubos < 5)
        {
            GameObject cubo = Instantiate(
                cuboPrefab,
                new Vector3(cantidadCubos * 2 - 4, 0, 4),
                Quaternion.identity
            );

            cubo.name = "Cubo_Update_" + cantidadCubos;

            cantidadCubos++;
            tiempo = 0f;
        }
    }
}
