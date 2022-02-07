using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class W2CircleScript : MonoBehaviour
{
    W2GameManager myManager;

    // Start is called before the first frame update
    void Start()
    {
        // the below is now commented out because score in the game manager script is staticed
        // but its the old way of accessing a particular instance of a class
        // W2GameManager myManager = GameObject.Find("Game Manager").GetComponent<W2GameManager>();

        Debug.Log(W2GameManager.score);

        // the score variable from the game manager can be edited here because its public and static
        W2GameManager.score += 0;

        // gets an instance of the game manager, because it uses a singleton pattern
        myManager = W2GameManager.FindInstance();
    }

    // Update is called once per frame
    void Update()
    {
        //can directly access W2Utilscript's Vector2moditfy function beauce its static
        // use this to move the circle;
        // transform.position = W2UtilScript.Vector3Modify(transform.position, W2GameManager.circleSpeed, 0, 0);

        //because GRAVITY is const and static, we can read it but not change it
        //Debug.Log("GRAVITY:" W2GameManager.GRAVITY);

        //because highScore is a private variable, it cant be directly accessed from this script
        // use the getter and setter of HighScore to access it
        Debug.Log("HighScore:" + myManager.HighScore);

        // the score variable from the game manager can be edited here because its public and static
        // every time the mouse is clicked, the score goes up by one
        if (Input.GetMouseButtonDown(0))
        {
            W2GameManager.score += 1;
            transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
   
        }

        if (W2GameManager.score >= 29)
        {
            SceneManager.LoadScene("W2Win");
        }
        

    }
}
