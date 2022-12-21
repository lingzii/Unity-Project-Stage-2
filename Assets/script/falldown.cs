using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falldown : MonoBehaviour
{   public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        float y =  Player.transform.position.y;
        Debug.Log(y); 
        if(y<=1.56f)
        {   
            Player.GetComponent<CharacterController>().enabled = false;    
            Player.transform.position = new Vector3(1.45f,4.4f,4.32f);
            Player.GetComponent<CharacterController>().enabled = true;    
            Debug.Log("pppp");    
        }
    }
}
