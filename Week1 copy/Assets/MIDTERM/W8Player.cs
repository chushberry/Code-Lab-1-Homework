using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W8Player : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //when my mouse hits a collider,
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if(hit.collider != null)
        {
            //if(hit.transform.gameObject.name == "Circle")
            //{
            //    hit.transform.gameObject.GetComponent<W8CircleScript>().ClickedCircle();
            //}

            //if(hit.transform.gameObject.name == "Square")
            //{
            //    hit.transform.gameObject.GetComponent<W8SquareScript>().ClickedSquare();
            //}

            //if(hit.transform.gameObject.name == "Capsule")
            //{
            //    hit.transform.gameObject.GetComponent<W8CapsuleScript>().ClickedCapsule();
            //}

            // run Iclickable's OnClick function
            hit.transform.gameObject.GetComponent<W8IClickable>().OnClick();
        }
    }
}
