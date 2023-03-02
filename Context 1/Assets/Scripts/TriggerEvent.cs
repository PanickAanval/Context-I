using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent onEnter, onExit;
    public GameObject player1;
    public GameObject player2;
    public GameObject player1Tp;
    public GameObject player2Tp;
    private bool player1IsIn;
    private bool player2IsIn;

    private void OnTriggerEnter(Collider other)
    {
        print(other);
        onEnter.Invoke();
        if (other.gameObject == player1)
        {
            player1IsIn = true;
        }
        
        if (other.gameObject == player2)
        {
            player2IsIn = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        print(other);
        onExit.Invoke();
        if (other.gameObject == player1)
        {
            player1IsIn = false;
        }

        if (other.gameObject == player2)
        {
            player2IsIn = false;
        }
    }
    private void Update()
    {
        if (player1IsIn && player2IsIn)
        {
            player1.transform.position = player1Tp.transform.position;
            player2.transform.position = player2Tp.transform.position;
            Debug.Log("AAAAAAAAAAAAAAA");
        }
    }
}
