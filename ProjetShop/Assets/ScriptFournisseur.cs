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
    //private bool collisionVendeur = false;

    private void OnEnable()
    {
        Debug.Log("Fournisseur arrive");
        // remettre à zero la postion initial à zero 
        moveFournisseur = true;
    }
    // Start is called before the first frame update
    void Start()
    {

        if (Magasin.DebutJournee == true)
        {
            //moveFournisseur = true;
            Debug.Log("Bonjour !!");
        }
    }

    public void Awake()
    {
        Stock = GameObject.Find("Vendeur").GetComponent<Stock>();
    }

    // Update is called once per frame
    void Update()
    {
        if(moveFournisseur == true)
        {
           transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
           float Distance = Mathf.Abs(transform.position.x - Destination.position.x); 
           //Mathf.Abs transforme la valeur en valeur absolu : permet de rendre un résultat qui peut être négatif en nombre positif
            
            if(Distance <= 0.1f) // permet de dire si il est arrivé à destination, si la destination est égal à 0s
            {
                moveFournisseur = false;
            }

        }
        //if (gameObject.GetComponent<Fournisseur>().SetActive(true));
        //if (GameObject.Find(Fournisseur).SetActive(true)) ;
        {
            // mettre +4 de stock et -15 argent par exemple 

        }

    }

    public void jesaispas()
    {
        Stock.Restockage(Restock);
    }

    //void OntriggerEnter(Collision2D other)
    //{
        // if(coll.gameObject.Vendeur == ){
        //collisionVendeur = true;
        //Debug.Log("Aie");
        //moveFournisseur = false;
        // }

    //}

}
