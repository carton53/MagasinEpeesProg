using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Magasin : MonoBehaviour
{

    /////////////MAINTENANT///////////
    public float argent;
    public bool IsOuvert;

    public List<Stock> Epees = new List<Stock>();

    /////////////AVANT/////////////////////
    //// Les 4 barres sont des commentaires ////
    // Les 2 barres sont des codes annulés //

    //public bool DebutJournee = false;
    //public bool OuvrirMagasin = false;
    //public int Argent = 20;
    //public int Epee = 10;
    //
    //public TMP_Text TextArgent;
    //public TMP_Text TextEpees;


    /////////////MAINTENANT///////////
    public void OnEnable()
    {
        //// Pour contrôler que le magasin est ouvert
        Debug.Log("Le magasin est Ouvert");
        IsOuvert = true;
    }

    public void OnDisable()
    {
        ////ou fermer
        Debug.Log("Le magasin est Fermé !");
        IsOuvert = false; 
    }


    /////////////AVANT/////////////////////
    //void Update()
    //{
    //    TextArgent.text = Argent.ToString();
    //    TextEpees.text = Epee.ToString();
    //}
    //
    //IEnumerator OuvertureMagasin()
    //{
    //    print("Commence");
    //    yield return new WaitForSeconds(5); 
    //    //// est ce que je met le code au milieu ou sur le côté 
    //    print("Termine"); 
    //    yield return null;
    //}
    //// à la fin de la coroutine tout remettre à zero

    //public void MagasinOuvert()
    //{
    //    OuvrirMagasin = true;
    //    StartCoroutine(OuvertureMagasin());
    //}
    //
    //public void SoleilSeLeve()
    //{
    //    print("le soleil se lève");
    //    DebutJournee = true;
    //    Debug.Log("Debout !");
    //}
    //
    //public void AcheterAuxFournisseurs()
    //{
    //    print("-10 argent et + 1 épée");
    //    Argent -= 10;
    //    Epee += 1;
    //}

    //public void VendreAuxClients()
    //{
    //    print("+20 argent et - 1 épée");
    //    Argent += 10;
    //    Epee -= 1;
    //
    //
    //}
}
