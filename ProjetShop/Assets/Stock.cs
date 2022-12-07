using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Stock : MonoBehaviour
{
    public float Argent = 20; 
    // Stock l'argent

    Dictionary<Epees, int> stockEpees; 
    // Le dico utilise la class Epee est un int ?

    [SerializeField] List<CoupleEpeesQuantite> intermediaireList; 
    //C'est une liste qui r�cup�re la class Epees et leurs quantit�s 

    private void Start()
    {
        stockEpees = new Dictionary<Epees, int>(); 
        // Cette ligne cr�� un dico de la class Epee avec des int (les int servent � quoi ?)

        foreach (CoupleEpeesQuantite element in intermediaireList) 
        // pour chaque �l�ments dans la liste la mettre dans le dictionnaire ?  
        {
            stockEpees[element.epees] = element.quantite; 
            // chaque �l�ment epees correspond � une quantit� ? 
        }
    }

    public bool Restockage(int Restock) 
    // la fonction qui permet de restocker le magasin avec le fournisseur
    {
        foreach (Epees Epee in stockEpees.Keys) 
        // Une boucle pour chaque Epee du dico pouvoir restocker 
        {
            float Cout = Epee.prixVente * Restock;

            if(Cout <= Argent)
            {
                Argent -= Cout;
                stockEpees[Epee] += Restock;
            }
            else
            {
                return false;
            }
        }

        return true;
        // ATTENTION : � partir du moment o� il n'y aura plus d'argent, la boucle s'arr�te et ne rempli plus de stock
    }
}

[Serializable]
public struct CoupleEpeesQuantite
{
    public Epees epees; 
    //R�cup�re la class Epees pour en faire une variable ? 

    public int quantite; 
    // Permet d'associer la classe Epees � la quantit� 
}

[Serializable]
public class Epees 
    //contient les caract�ristiques des �p�es
{
    [SerializeField] float PrixVente; 
    // le [SerializeField] permet d'afficher la variable dans inspector mais PAS de la rendre public 

    [SerializeField] float PrixAchat;

    public float prixAchat => PrixAchat; 
    //getter : permet de mettre une variable en public
    public float prixVente => PrixVente; 
    //getter
}
