/****
 * Created by: Bridget Kurr
 * Date Created: June 20, 2022
 * 
 * Last Edited by:
 * Last Edited:
 * 
 * Description: A class to use a PowerUp to add time to the timer in a level
 ****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    
    /***VARIABLES***/
    private int playerPowerUpCount = 0;
    static public int powerUpsInScene;
    public Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = Timer.LevelTimer; //reference to level timer
    }//end Start()

        // Awake() is called on instantiation before Start
        private void Awake()
    {
        powerUpsInScene++; //counts collectables in scene
        Debug.Log("<color=lightblue>PowerUps in scene </color>" + powerUpsInScene);
    }

    //PowerUpCount() is called when the Player collides with a PowerUp
    public void AddToPowerUpCount()
    {
        playerPowerUpCount++; //tracks how many PowerUps are gained
        Debug.Log("<color=blue>PowerUps used </color>" + playerPowerUpCount);
    }//end PowerUpCount()

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Count added to PowerUps Used by Player");
        AddToPowerUpCount();

        if (other.tag == "Player")
        {
            Debug.Log("<color=yellow> PowerUp Triggered </color>");
            timer.AddTime(); //call method on contact with PowerUp
            Destroy(gameObject); //destroy this gameObject 
        }
    }//end OnTriggerEvent

}//end PowerUP
