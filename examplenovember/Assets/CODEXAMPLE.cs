using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CODEXAMPLE : MonoBehaviour
{
    //public int[] arreglo;
    public List<int> ListaDenteros = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        //arreglo = new int[20];
        ListaDenteros.Add(10);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
