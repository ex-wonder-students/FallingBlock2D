﻿using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text ScoreText;
    private int Score;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0.3f, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-0.3f, 0, 0);
        }
        ScoreText.text = Score.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Falls" )
        {
            Score += 1000;
        }
    }
}
