using System.Collections;
using UnityEngine;

public class RingSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject Objective; // Prefab slot
    public float spawnInterval = 5f; // Tiempo entre spawns
    public float Lifetime = 5f; // Tiempo de vida
    public float RingSpeed = 5f;

    private void Start()
    {
        // Inicia la corutina que genera los objetivos
        StartCoroutine(SpawnObjectiveRoutine());
    }

    private IEnumerator SpawnObjectiveRoutine()
    {
        while (true)
        {
            // Crear el objetivo sin rotación
            GameObject spawnedObjective = Instantiate(Objective, transform.position, Quaternion.identity);
            Debug.Log("Objective spawn at: " + Time.time + " seconds"); // Mensaje al spawnear

            // Mover el objetivo hacia adelante
            spawnedObjective.GetComponent<Rigidbody>().velocity = transform.forward * RingSpeed;

            // Espera el tiempo de vida antes de eliminar el objetivo
            Destroy(spawnedObjective, Lifetime);

            // Iniciar la corutina para despawnear
            StartCoroutine(DespawnObjective(spawnedObjective, Lifetime));

            // Espera el tiempo antes de spawnear el siguiente objetivo
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    // Corutina para manejar el despawn del objetivo
    private IEnumerator DespawnObjective(GameObject Objective, float delay)
    {
        // Espera el tiempo de vida antes de enviar el mensaje de despawn
        yield return new WaitForSeconds(delay);
        Debug.Log("Objective despawned: " + Time.time + " seconds"); // Mensaje al despawnear
    }
}
