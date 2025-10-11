
using System;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Geocontroler : MonoBehaviour
{
    public string VariableOne = "Hello";
    public string NextlLevel;
    int var = 3;

    private Rigidbody2D kuri;

    public int speed = 5;


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
        // Start is called before the first frame update
        void Start()
    {
        //Debug.Log("Hello Word");
      
            string VariableTwo = "World";

       Debug.Log(VariableOne + VariableTwo);

        kuri = GetComponent<Rigidbody2D>();

    }



        // Update is called once per frame
        void Update()
    { 
        //Debug.Log(var);
        var++;

        /*
        if (Input.GetKeyDown(KeyCode.A))
        {
            kuri.velocity += new Vector2(-1, kuri.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            kuri.velocity += new Vector2(1, kuri.velocity.y);
        }
        */
        
            float xInput = Input.GetAxis("Horizontal");
            kuri.velocity = new Vector2(xInput * speed, kuri.velocity.y);




            /*
                    if (Input.GetKeyDown(KeyCode.W))
                    {
                        transform.position += new Vector3(0, 1, 0);
                    }

                    if (Input.GetKeyDown(KeyCode.S))
                    {
                        transform.position += new Vector3(0, -1, 0);
                    }

                    if (Input.GetKeyDown(KeyCode.A))
                    {
                        transform.position += new Vector3(-1, 0, 0);
                    }

                    if (Input.GetKeyDodwn(KeyCode.D))
                    {
                        transform.position += new Vector3(1, 0, 0);
                    }

                */









        }

    private void GetAxis(string v)
    {
        throw new NotImplementedException();
    }
}





