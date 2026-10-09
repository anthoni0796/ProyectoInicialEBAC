using UnityEngine;

public class GenerarCuboActivacion : MonoBehaviour
{
    [SerializeField] private GameObject cuboPrefab;

    void OnEnable()
    {
        if (Application.isPlaying && cuboPrefab != null)
        {
            GameObject cubo = Instantiate(
                cuboPrefab,
                new Vector3(-4, 0, -4),
                Quaternion.identity
            );

            cubo.name = "Cubo_OnEnable";
        }
    }

    void OnDisable()
    {
        if (Application.isPlaying && cuboPrefab != null)
        {
            GameObject cubo = Instantiate(
                cuboPrefab,
                new Vector3(4, 0, -4),
                Quaternion.identity
            );

            cubo.name = "Cubo_OnDisable";
        }
    }
}
