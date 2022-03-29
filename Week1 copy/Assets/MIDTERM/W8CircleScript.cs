using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// this script is for the post office

public class W8CircleScript : MonoBehaviour , W8IClickable
{
    public SpriteRenderer mySpriteRenderer;
    public int totalMail;
    public GameObject a;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnClick()
        //when mouse is over this
    {
        // if it's clicked
        if (Input.GetMouseButtonDown(0))
        {
            //-1 mail
            totalMail -= 1;
            a.GetComponent<W8GameManager>().isHoldingMail = true;
            Debug.Log("isHoldingMail " + a.GetComponent<W8GameManager>().isHoldingMail);

            // if theres no more mail, go to the win screen
            if (totalMail < 1)
            {
                SceneManager.LoadScene("W8YouWin");
            }
        }
        
    }
}
