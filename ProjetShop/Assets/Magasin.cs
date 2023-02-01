using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Magasin : MonoBehaviour
{
    public bool DebutJournee = false;
    public bool OuvrirMagasin = false;
    public int Argent = 20;
    public int Epee = 10;

    public TMP_Text TextArgent;
    public TMP_Text TextEpees;

    void Start()
    {
    }

    void Update()
    {
        TextArgent.text = ScoreArgent;
        TextEpees.text = ScoreEpees;
    }

    IEnumerator OuvertureMagasin()
    {
        print("Commence");
        yield return new WaitForSeconds(5); // est ce que je met le code au milieu ou sur le c�t� 
        print("Termine"); 
        yield return null;
    }
    // � la fin de la coroutine tout remettre � zero

    public void MagasinOuvert()
    {
        OuvrirMagasin = true;
        StartCoroutine(OuvertureMagasin());
    }

    public void SoleilSeLeve()
    {
        print("le soleil se l�ve");
        DebutJournee = true;
        Debug.Log("Debout !");
    }

    public void AcheterAuxFournisseurs()
    {
        print("-10 argent et + 1 �p�e");
        Argent -= 10;
        Epee += 1;


    }

    public void VendreAuxClients()
    {
        print("+20 argent et - 1 �p�e");
        Argent += 10;
        Epee -= 1;


    }
}
