using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour 
{ 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    Debug.Log("Player Has Died");
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }

            case "Finish":
                {
                    SceneManager.LoadScene(NextlLevel);
                    break;

                }

           
        }

    }
  
}
