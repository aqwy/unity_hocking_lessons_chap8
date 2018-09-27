using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour, IGameManager
{
    public managerStatus status { get; private set; }
    public int health { get; private set; }
    public int maxHealth { get; private set; }
    public void Startup()
    {
        Debug.Log("Player manager starting...");
        health = 50;
        maxHealth = 100;
        status = managerStatus.Started;
    }
    public void changeHealth(int val)
    {
        health += val;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        else if (health <= 0)
        {
            health = 0;
        }
        Debug.Log("Health:" + health + "/" + maxHealth);
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
