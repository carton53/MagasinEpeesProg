using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFournisseur : MonoBehaviour
{
    public Stock Stock;
    public int Restock = 4;
    public Magasin Magasin;

    public float moveSpeed = 0.3f;
    public bool moveFournisseur = false;
    public Transform Destination;
    public Transform Destination2;
    public Transform PositionBase;
    
    public void Awake()
    {
        //Stock = GameObject.Find("Vendeur").GetComponent<Stock>();
        //PositionBase = transform.Translate(Vector2 14.07f, 0);
        // Donc quand le GameObject est activé, nous allons chercher le stock dans le GameObject Vendeur dans le Component Stock qui est un script.
    }


    void Start()
    {
        if (Magasin.DebutJournee == true)
        {
            Debug.Log("Bonjour !!");
        }
    }    


    private void OnEnable()
    {
       // Debug.Log("Fournisseur arrive");
        // remettre à zero la postion initial à zero 
        //moveFournisseur = true;
    }

    void Update()
    {


       // if(moveFournisseur == true)
        {
            ///// Les deux lignes ci-dessous sont pour le déplacement du fournisseur vers le vendeur
           //transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
           //float Distance = Mathf.Abs(transform.position.x - Destination.position.x); 
           ///////////Mathf.Abs transforme la valeur en valeur absolu : permet de rendre un résultat qui peut être négatif en nombre positif
            
            //if(Distance <= 0.1f) // permet de dire si il est arrivé à destination, si la destination est égal à 0s
            {
                //moveFournisseur = false;
                //FournisseurTravaille();
                //////////Possiblement là où je vais mettre l'interaction du fournisseur avec le stock et l'argent////////////////
            }

        }

    }

    //public void FournisseurTravaille()
    //{
        //Stock.Restockage(Restock);
    }


    //////////////////////////////////////////////////////////Ancienne tentative///////////////////////////////////////////////////////

    //private bool collisionVendeur = false; je sais pas si j'en aurais encore besoin


    //void OntriggerEnter(Collision2D other)
    //{
    // if(coll.gameObject.Vendeur == ){
    //collisionVendeur = true;
    //Debug.Log("Aie");
    //moveFournisseur = false;
    // }

    //}

    //????????????if (gameObject.GetComponent<Fournisseur>().SetActive(true));
    //????????????if (GameObject.Find(Fournisseur).SetActive(true)) ;
    //???????????? mettre +4 de stock et -15 argent par exemple 

//}
