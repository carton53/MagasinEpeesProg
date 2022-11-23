using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Stock : MonoBehaviour
{
    Dictionary<Epees, int> stockEpees;

    [SerializeField] List<CoupleEpeesQuantite> intermediaireList;

    private void Start()
    {
        stockEpees = new Dictionary<Epees, int>();

        foreach (CoupleEpeesQuantite element in intermediaireList)
        {
            stockEpees[element.epees] = element.quantite;
        }
    }
}

[Serializable]
public struct CoupleEpeesQuantite
{
    public Epees epees;
    public int quantite;
}

[Serializable]
public class Epees
{
    [SerializeField] float Prix;
}
