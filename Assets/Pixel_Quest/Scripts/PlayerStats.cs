using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour 
{
    public string NextLevel;
    public Transform respawnPoint;
    private int coinCounter = 0;
    private int _health = 3;
    private int _maxHeatl = 3; 
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

            case "death":
                {
                    _health--;
                    if (_health == 0)
                    {
                        string thislevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thislevel);

                    }
                    else
                    {
                        transform.position = respawnPoint.position;
                    }
                    break;
                }

                case "Coin": {
                            coinCounter++;
                            Destroy(collision.gameObject);
                            break;


                        }
                    case "Health":
                        {
                            _health++;
                            Destroy(collision.gameObject);
                            break;


                        }
                    case "Finish":
                        {
                            SceneManager.LoadScene(NextLevel);
                            break;

                        }


                    }

    }
  
}
