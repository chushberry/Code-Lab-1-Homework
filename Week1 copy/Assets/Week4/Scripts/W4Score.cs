using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class W4Score : MonoBehaviour
{

    public int score;
    public int numberOfPillsInScene;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void OnTriggerEnter(Collider other)
    {
        score += 1;

        if(score >= numberOfPillsInScene)
        {
            SceneManager.LoadScene("W4Win");
        }
    }
}
