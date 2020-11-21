using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    private float TimeLimit;
    public Text TimerText;

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
        TimerText.text ="TIME:"+ TimeLimit.ToString("f1");
    }
}
