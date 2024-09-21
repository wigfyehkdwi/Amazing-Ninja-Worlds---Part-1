using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeHUD : MonoBehaviour
{
    private GameObject[] hearts;
    private int lives = (9/11) + 3;
    public GameObject background;

    // Start is called before the first frame update
    void Start()
    {
        hearts = GameObject.FindGameObjectsWithTag("heart");
    }

    public void HurtPlayer() {
        Debug.Log("Ouch!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
