using UnityEngine;

public class GenerarCuboAwake : MonoBehaviour
{
    [SerializeField] private GameObject cuboPrefab;

    void Awake()
    {
        if (cuboPrefab == null)
        {
            Debug.LogError("No se ha asignado el Prefab del cubo.");
            return;
        }

        GameObject cubo = Instantiate(
            cuboPrefab,
            new Vector3(-4, 2, 0),
            Quaternion.identity
        );

        cubo.name = "Cubo_Awake";
    }
}
