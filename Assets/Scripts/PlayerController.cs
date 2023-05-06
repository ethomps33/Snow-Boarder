using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    //Member variables
    Rigidbody2D rb2d;
    [SerializeField]float tAmount = 1f;
    // Start is called before the first frame update
    void Start()
    {
     //Setting the rigidbody of the character to rb2d   
     rb2d = GetComponent<Rigidbody2D>(),   
    }

    // Update is called once per frame
    void Update()
    {
        // if the Left Arrow us pressed torque will be applied to the character
        if(Input.GetKey(KeyCode.LeftArrow)){
            rb2d.AddTorque(tAmount);
        }
    }
}
