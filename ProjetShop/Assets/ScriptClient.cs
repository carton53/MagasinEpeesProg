using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptClient : MonoBehaviour
{
    public Magasin magasin;
    public string nomClient;
    public string nomEpee;
    public int nombreClient;

    public void OnEnable()
    {
        Debug.Log(nomClient + "entre dans le magasin");
        AcheterClient();
        Debug.Log(nomClient + "sors du magasin");
        Destroy(gameObject);
    }
    public void AcheterClient()
    {
        bool isEpee = false;
        foreach (Stock stock in magasin.Epees)
        {
            if (stock.nom == nomEpee)
            {
                Debug.Log("J'ai trouvé ton épée !!!!");
                isEpee = true;

                if (stock.nombre >= nombreClient)
                {
                    magasin.argent = magasin.argent + nombreClient * stock.prix;
                    stock.nombre -= nombreClient;
                    Debug.Log(nomClient+ "achete" + nombreClient + " " + nomEpee);
                }
                else
                {
                    Debug.LogError(nomEpee+"Victime de son succès !");
                }

            }
        }
        if (isEpee == false)
        {
            Debug.LogWarning("Victime de son succès");
        }
    }
}
