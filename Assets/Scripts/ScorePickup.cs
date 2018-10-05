using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour {

    public Score scoreTracker;
    public int scoreValue = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        //Only do if it's hit the player
        if(collision.GetComponent<Player>())
        {
            //Updating the score based on how much the score is worth
            scoreTracker.ChangeValue(scoreValue);

            //Gets rid of the item
            Destroy(gameObject);
      
        }
    }

}
