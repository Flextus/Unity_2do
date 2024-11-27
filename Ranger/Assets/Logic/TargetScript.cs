using UnityEditor;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public float hp = 5f;
    public AudioSource SourceTARGET;
    public AudioClip DieSound;
    public int muertes = 0;

    public void TakeDamage(float amount)
    {
        hp = hp - amount;
        Debug.Log("Remaining HP: " + hp);
        if (hp <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        SourceTARGET.PlayOneShot(DieSound);
        muertes = muertes + 1;
    }



}
