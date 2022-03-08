
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W5CardBehaviour : MonoBehaviour
{

    public SpriteRenderer myRenderer;

    public Color faceColor;
    public Color backColor;

    W5GameManager myManager;

    //an enum is a special class that lets us define constants
    //as if they were a new data type
    //here, we've created a thing called a "State"
    //which can be one of three things
    public enum State
    {
        FaceUp,
        FaceDown,
        CleanUp
    }

    State currentState; //keeps track of the state we're on

    // Start is called before the first frame update
    void Start()
    {
        myManager = W5GameManager.FindInstance(); //get the game manager

        TransitionState(State.FaceDown); //set to face down

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    { //when the mouse is clicked
        Debug.Log(myManager.currentState);
        if (myManager.currentState == W5GameManager.State.Select) //if we're in the select state
        {
            if (currentState == State.FaceDown) //if the card is face down
            {
                TransitionState(State.FaceUp); //move to the faceup state
                myManager.TransitionStates(W5GameManager.State.CardChosen); //move to cardchoosen state
                //currentState = State.FaceUp;
            }
            else if (currentState == State.FaceUp) //if the card is face up
            {
                TransitionState(State.FaceDown); //move to the face down state
                //currentState = State.FaceDown;
            }
        }
    }

    void TransitionState(State newState)

    {
        currentState = newState; //set the new state to be the current state
        switch (newState) //check the value of newState
        { //if new state is...
            case State.FaceDown: //face down 
                myRenderer.color = backColor; //set the sprite color
                break;
            case State.FaceUp: //face up
                myRenderer.color = faceColor; //set the sprite color
                break;
            default: //if none of these are the state, go here
                Debug.Log("no transition for this state");
                break;
        }
    }


}
