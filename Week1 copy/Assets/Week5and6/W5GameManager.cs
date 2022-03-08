using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W5GameManager : MonoBehaviour
{
    private static W5GameManager instance;
    public static W5GameManager FindInstance()
    {
        return instance;
    }

    // number of cards in deck
    public int cardCount;

    //card prefab
    public GameObject cardObj;

    //all potential game states
    public enum State
    {
        CreateCards,
        Deal,
        Select,
        CardChosen,
        Resolve
    }

    //tracks the state the game is in now
    public State currentState;

    public List<GameObject> deck = new List<GameObject>();

    public Vector3 handStartPos;

    public float enemyHealth;
    public string enemyText;

    void Awake()
    {

        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else if(instance == null)
        {
            DontDestroyOnLoad(this);
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        // start by creating cards
        TransitionStates(State.CreateCards);
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void TransitionStates(State newState)
    {
        currentState = newState;

        switch (newState)
        {
            case State.CreateCards:
                for ( int i = 0; i < cardCount; i++)
                {
                    GameObject newCard = Instantiate(cardObj);
                    Vector3 newPos = new Vector3(gameObject.transform.position.x + (i * 3), gameObject.transform.position.y, 0);
                    newCard.transform.position = newPos;
                    deck.Add(newCard);
                }
                //once all cards have been made, go to the deal state
                TransitionStates(State.Deal);
                break;
            case State.Deal:
                break;
            case State.Select:
                break;
            case State.CardChosen:
                break;
            case State.Resolve:
                break;
            default:
                Debug.Log("this state doesn't exist");
                break;
        }

    }

    void RunState()
    {
        switch (currentState)
        {
            case State.Deal:
                for(int i = 0; i < deck.Count; i++)
                {
                    float step = 5.0f * Time.deltaTime;
                    Vector3 newPos = new Vector3(handStartPos.x + (i * 3), handStartPos.y, 0);
                    deck[i].transform.position = Vector3.MoveTowards(deck[i].transform.position, newPos, step);
                    if(i == deck.Count - 1 && Vector3.Distance(deck[i].transform.position, newPos) < 0.5f)
                    {
                        TransitionStates(State.Select);
                    }
                }
                break;
        }
    }
}
