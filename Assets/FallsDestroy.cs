using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallsDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Kago")
        {
            Destroy(gameObject, 0.1f);
        }
    }
}
