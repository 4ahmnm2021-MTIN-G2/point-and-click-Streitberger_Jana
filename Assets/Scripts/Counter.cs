using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public int counter = 0;
    public GameObject button;
    public GameObject gameOver;
    public GameObject items;
    public int falseCounter = 0;


    public void OnMouseDown()
    {
        if (gameObject.CompareTag("Zutat")){
            Debug.Log("wuerde funk");
            counter +=1;
        }
        //geht nicht wegen Manager CompareTag
        if(gameObject.CompareTag("Falsch"))
        {
            Debug.Log("falsch geht");
            falseCounter += 1;
            counter -= 1;
        }

        if(counter == 6)
        {
            button.SetActive(true);
        }
        if(falseCounter >= 1)
        {
            gameOver.SetActive(true);
        }
    }



}
