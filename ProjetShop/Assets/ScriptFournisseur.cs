using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFournisseur : MonoBehaviour
{
    public float moveSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        print"Aie";
        moveSpeed = 0f;
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
}
