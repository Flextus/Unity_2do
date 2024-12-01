using Cinemachine;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float damage = 10f;
    public float range = 10f;

    public Camera Cam1;


    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(Cam1.transform.position, Cam1.transform.forward, out hit, range))
        Debug.Log("BULLET");
        Debug.DrawRay(Cam1.transform.position, Cam1.transform.forward);
        {
            Debug.Log(hit.transform.name);
        }
    }
}
