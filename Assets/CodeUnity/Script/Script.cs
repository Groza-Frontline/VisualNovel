using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduction : MonoBehaviour
{
    public int STR;
    public int healthpoints;

    public int Damage;
    public int Agil;
    // Start is called before the first frame update
    void Start()
    {
        healthpoints = 5 * STR;
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("Hello World!");
        // When we press space bar...
        // we call the function takedamage!
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage();
        }
        if (healthpoints<0)
        {
            Debug.Log("You are dead!");
            healthpoints = 0;
        }
    }
    void TakeDamage()
    {
        //1000 - 50 = 950
        healthpoints = healthpoints - Damage;
    }
}
