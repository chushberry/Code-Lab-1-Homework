using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script is for the houses

public class W8SquareScript : MonoBehaviour , W8IClickable
{
    public GameObject a;
    public SpriteRenderer mySpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // if the house is clicked, it'll deliver the mail and make the house disappear
            a.GetComponent<W8GameManager>().isHoldingMail = false;
            Debug.Log(" isHoldingMail " + a.GetComponent<W8GameManager>().isHoldingMail);
            mySpriteRenderer.color = new Color(100, 95, 95, 0);
        }
    }
}
