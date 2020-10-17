using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falls : MonoBehaviour
{
    public GameObject falls;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Falling", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Falling()
    {
        int x = Random.Range(-8, 8);
        Instantiate(falls.gameObject, new Vector3(x, 4f, 0f), Quaternion.identity);
    }
}
    
