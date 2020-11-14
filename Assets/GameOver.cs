using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private float TimeLimit;

    // Start is called before the first frame update
    void Start()
    {
        TimeLimit = 60;
    }

    // Update is called once per frame
    void Update()
    {
        TimeLimit -= Time.deltaTime;

        if(TimeLimit<=0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
