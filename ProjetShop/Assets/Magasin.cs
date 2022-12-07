using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magasin : MonoBehaviour
{
    public bool DebutJournee = false;
    public bool OuvrirMagasin = false;

    void Start()
    {
    }

    void Update()
    {
    }

    IEnumerator OuvertureMagasin()
    {
        print("Commence");
        yield return new WaitForSeconds(5); // est ce que je met le code au milieu ou sur le côté 
        print("Termine"); 
        yield return null;
    }
    // à la fin de la coroutine tout remettre à zero



    public void MagasinOuvert()
    {
        OuvrirMagasin = true;
        StartCoroutine(OuvertureMagasin());
    }

    public void SoleilSeLeve()
    {
        print("le soleil se lève");
        DebutJournee = true;
        Debug.Log("Debout !");
    }
}
