using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public float Speed = 25f;
    public float Corner = 1.0f;
    // Start is called before the first frame update
    void Start() {
        //Get the rigidbody from the start when we first call upon the game
        rb = GetComponent<Rigidbody>();

    
    }

    // Update is called once per frame
    void Update()
    {
        // Hint: The global static variable "Terrain.activeTerrain" 
        // may be helpful or have useful methods for user here or in
        // other scripts.
        Terrain terrain = Terrain.activeTerrain;

        Vector3 position = transform.position;
        
        // set the game object's translation (not an increment)
        transform.position = position;

        // // translate by 0.1m on Z axis each frame for as long as
        // // the space bar is held down
        // if (Input.GetKey  (KeyCode.Space)){
        //     // increment the game object's translation
        //     transform.Translate(0, 0, 0.1f);
        //    //need to find the right amount of force amount needed
        //    //this makes it lean in the direction that it ment to
        //     forceAmount = 4f;
        //     Addforce();
        // }

       

        if(Input.GetKey  (KeyCode.W)){
            //forwards
            transform.Translate(0,0,Speed * Time.deltaTime);
        }
        if(Input.GetKey (KeyCode.A)){
            //left
            transform.Rotate(0,Corner * Time.deltaTime,0);
        }
        if(Input.GetKey (KeyCode.S)){
            //backwards or reverse 
            transform.Translate(0,0,-Speed * Time.deltaTime);
        }
        if(Input.GetKey (KeyCode.D)){
            //right
            transform.Rotate(0,-Corner * Time.deltaTime,0);
        }

    }








void Addforce(){

    //need to fix so it only when every the player actaully presses on it and not just moving on it own
    //more then likely will be some if statments
    
    //rb.AddForce(transform.forward * forceAmount);


}
   

}
