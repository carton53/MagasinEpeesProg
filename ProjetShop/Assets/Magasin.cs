using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magasin : MonoBehaviour
{
    public bool DebutJournee = false;
    // Start is called before the first frame update
    void Start()
    {
        print("le soleil se l�ve");
        DebutJournee = true;
        
    }
    // Mettre une coroutine pour l'ouverture/fermeture du magasin en tps r�el 
    //Dans le moment o� on veut que le magasin ouvre
    // StartCoroutine(OuvertureMagasin());

    //IEnumerator OuvertureMagasin());
    //print("Time.Time");
    //yield return new WaitForSecondsRealTime(0);
    //print("Time.Time");

    // Update is called once per frame
    void Update()
    {

    }
}
