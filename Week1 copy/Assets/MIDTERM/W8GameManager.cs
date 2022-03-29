using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class W8GameManager : MonoBehaviour
{
    public GameObject b;
    public Text NextInstructionsText;
    private static W8GameManager instance;
    public static W8GameManager FindInstance()
    {
        return instance;
    }

    public bool isHoldingMail;

    //list of states
    public enum State
    {
     Retrieve,
     Deliver
    }

    //tracks the current state
    public State currentState;

    void Start()
    {
        //start in the retrieve state
        TransitionStates(State.Retrieve);

    }

    // Update is called once per frame
    void Update()
    {
        //if im holding mail, then go to deliver state
        if (isHoldingMail == true)
        {
            TransitionStates(State.Deliver);
        }

        // if im not holding mail then go to retrieve state
        if (isHoldingMail == false)
        {
            TransitionStates(State.Retrieve);
        }

        // if you are retrieving mail and the total amount of mail at the post office is 0, AND
        // you are not holding any mail anymore, you win!
        if (b.GetComponent<W8CircleScript>().totalMail == 0 && isHoldingMail == false)
        {
            SceneManager.LoadScene("W8YouWin");
        }
    }

    public void TransitionStates(State newState)
    {
        // thisll keep track of what state im in
        currentState = newState;

        switch (newState)
        {
 
            case State.Retrieve:

                // show the current state

                Debug.Log("current state " + currentState);

                // tell the player to retrieve

                NextInstructionsText.text = "Go Retrieve Mail!";


                break;


            case State.Deliver:

                // show the current state

                Debug.Log("current state " + currentState);

                // tell the player to deliver

                NextInstructionsText.text = "Go Deliver Mail!";

                break;

        }

    }
}
