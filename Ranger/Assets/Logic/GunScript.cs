using Cinemachine;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float damage = 10f;
    public float range = 10f;

    public Camera Cam1;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (Cam1 == null)
        {
            Debug.LogError("Cam1 is not assigned in the Inspector.");
            return;
        }

        RaycastHit hit;
        if (Physics.Raycast(Cam1.transform.position, Cam1.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            TargetScript target = hit.transform.GetComponent<TargetScript>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
