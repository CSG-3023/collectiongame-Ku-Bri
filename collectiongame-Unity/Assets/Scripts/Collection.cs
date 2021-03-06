/****
 * Created by: Bridget Kurr
 * Date Created: June 15, 2022
 * 
 * Last Edited by:
 * Last Edited:
 * 
 * Description: Manages collections and wining conditions.
 ****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    /***VARIABLES***/
    [Tooltip("Number of collectables to beat level")]
    public int winCollectAmount; //number of collectables to beat the level

    [Tooltip("Use the total number of collectables for the win amount")]
    public bool useCollectableCount; //Do we use the collectable count

    [HideInInspector]
    public bool hasCollectedAll = false; //have all collectables been collected

    private int collectablesInCollection = 0; //number of collectables collected by player

    private Timer timer; //reference to level timer


    // Start is called before the first frame update
    void Start()
    {
        timer = Timer.LevelTimer; //reference to level timer

        //if we are using the collectable count
        if(useCollectableCount)
        {
            //set the win amount to the amount of collectables in the scene
            winCollectAmount = Collectable.collectableCount;
        }//end if(useCollectableCount)

        Debug.Log("Win collect amount: " + winCollectAmount);
    }//end Start()

    // Update is called once per frame
    void Update()
    {
        if(collectablesInCollection == winCollectAmount)
        {
            hasCollectedAll = true;

            //if timer exists, stop timer
            if(timer != null) { timer.timerStopped = true; }

            Debug.Log("YOU WIN!");

        }//end if()

    }//end Update()


    //Add to collection
    public void AddToCollection()
    {
        collectablesInCollection++; //add to amount in collection
        Debug.Log("<color=blue>Collectable Added</color>");
    }//end AddToCollection()

}//end Collection
