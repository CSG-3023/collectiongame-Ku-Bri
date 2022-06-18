/****
 * Created by: Bridget Kurr
 * Date Created: June 17, 2022
 * 
 * Last Edited by:
 * Last Edited:
 * 
 * Description: A class to add constant rotation to objects
 ****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantRotation : MonoBehaviour
{

    /****VARIABLES****/
    private float y; //


    // Start is called before the first frame update
    void Start()
    {
        y = 0.5f;  //velocity in the y direction
    }


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, y, 0)); //applying rotation on the x axis
    }

   
  
}//end ConstantRotation
