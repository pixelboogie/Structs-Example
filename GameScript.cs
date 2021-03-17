using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{

    Hero myHero;
    
    void Start()
    {
        myHero = new Hero();
        myHero.Name = "Elvis";
        myHero.Score = 100;
        myHero.Lives = 3;
    }


    void OnDisable()
    {
        Debug.Log("Name: " + myHero.Name + ", Score: " + myHero.Score);
    }
}
