using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeScript : MonoBehaviour
{
    int ID;
    public GameObject MergedObject;
    // Start is called before the first frame update
    void Start()
    {
        ID = GetInstanceID();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<SpriteRenderer>().color == GetComponent<SpriteRenderer>().color)
        {
            if(ID < collision.gameObject.GetComponent<MergeScript>().ID) { return; }
            Debug.Log($"SENDING MESSAGE FROM {gameObject.name} With The ID Number of {ID}");
            GameObject O = Instantiate(MergedObject, transform.position, Quaternion.identity) as GameObject;  
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
