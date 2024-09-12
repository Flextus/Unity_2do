using System.Collections;
using UnityEngine;

public class LogSpawner : MonoBehaviour
{
    public GameObject logPrefab; // Prefab del tronco
    public float spawnInterval = 5f; // Tiempo entre spawns
    public float logLifetime = 10f; // Tiempo de vida del tronco
    public Vector3 logRotation; // Rotación deseada para el tronco (configurable desde el inspector)

    private void Start()
    {
        // Inicia la corutina que genera los troncos
        StartCoroutine(SpawnLogRoutine());
    }

    private IEnumerator SpawnLogRoutine()
    {
        while (true)
        {
            // Crear el tronco con la rotación especificada
            GameObject spawnedLog = Instantiate(logPrefab, transform.position, Quaternion.Euler(logRotation));
            Debug.Log("Log spawn at: " + Time.time + " seconds"); // Mensaje al spawnear

            // Espera el tiempo de vida antes de eliminar el tronco
            Destroy(spawnedLog, logLifetime);

            // Iniciar la corutina para despawnear
            StartCoroutine(DespawnLog(spawnedLog, logLifetime));

            // Espera el tiempo antes de spawnear el siguiente tronco
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    // Corutina para manejar el despawn del tronco
    private IEnumerator DespawnLog(GameObject log, float delay)
    {
        // Espera el tiempo de vida antes de enviar el mensaje de despawn
        yield return new WaitForSeconds(delay);
        Debug.Log("Log dispawned: " + Time.time + " seconds"); // Mensaje al despawnear
    }
}
