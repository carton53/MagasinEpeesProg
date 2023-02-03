using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stock
{
    //////////////////////////MAINTENANT/////////////////
    public string nom;
    public int nombre;
    public float prix;

    //////////////////////////////////AVANT////////////////////////////
    //public float Argent = 20; 
    //// Stock l'argent
    //
    //Dictionary<Epees, int> stockEpees; 
    //// Le dico s'appelle stockEpees
    //
    //[SerializeField] List<CoupleEpeesQuantite> intermediaireList; 
    ////On récupère la struct pour la mettre dans une liste
    //
    //////////////////////////MAINTENANT/////////////////

    //////////////////////AVANT////////////////////

    //private void Start()
    //{
    //    stockEpees = new Dictionary<Epees, int>(); 
    //    // Création d'un dico de la class Epee avec des int
    //
    //    foreach (CoupleEpeesQuantite element in intermediaireList) 
    //    // pour chaque éléments dans la liste la mettre dans le dictionnaire ?  
    //    {
    //        stockEpees[element.epees] = element.quantite; 
    //        // On associe la class à la quantité récupéré dans le list de la struct 
    //    }
    //}
    //
    //public bool Restockage(int Restock) 
    /////////// C'est une fonction booléan donc on retourne un vrai ou faux///////////
    //// la fonction qui permet de restocker le magasin avec le fournisseur
    //{
    //    foreach (Epees Epee in stockEpees.Keys) 
    //    // pour chaque Epee de la class Epees du dico
    //    {
    //        float Cout = Epee.prixVente * Restock; 
    //        // Création d'une variable Cout qui correspond au prix de vente de l'epee actuelle mulitplié par la variable Restock;
    //
    //        if(Cout <= Argent) 
    //        // si le Cout est plus petit ou égale à l'argent 
    //        {
    //            Argent -= Cout; 
    //            // On soustrait le cout à l'argent 
    //            stockEpees[Epee] += Restock; 
    //            // et on rajoute Restock à Epee du dico
    //        }
    //        else
    //        {
    //            return false;
    //            // sinon on retourne faux
    //        }
    //    }
    //
    //    return true;
    //    // ATTENTION : à partir du moment où il n'y aura plus d'argent, la boucle s'arrête et ne rempli plus de stock
    //}
}

//[Serializable]
//public struct CoupleEpeesQuantite
//{
//    public Epees epees; 
//    //Récupère la class Epees pour en faire une variable ? 
//
//    public int quantite; 
//    // Permet d'associer la classe Epees à la quantité 
//}

//[Serializable] // Permet de voir la class dans l'inspector
//public class Epees 
////contient les caractéristiques des épées
//{
//    [SerializeField] float PrixVente; 
//    // le [SerializeField] permet d'afficher la variable dans inspector mais PAS de la rendre public 
//
//    [SerializeField] float PrixAchat;
//
//    public float prixAchat => PrixAchat; 
//    //getter : permet de mettre une variable en public
//    public float prixVente => PrixVente; 
//    //getter
//}
