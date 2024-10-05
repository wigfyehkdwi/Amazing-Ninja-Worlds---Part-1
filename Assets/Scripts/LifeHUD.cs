using System;
using UnityEngine;

public class LifeHUD : MonoBehaviour
{
    private GameObject[] hearts;
    private int lives = 3;
    public GameObject background;

    // Start is called before the first frame update
    void Start()
    {
        hearts = GameObject.FindGameObjectsWithTag("heart");
        Array.Sort(hearts, (a, b) => a.name.CompareTo(b.name)); // workaround to unity doing it wrong
    }

    public void HurtPlayer() {
        Debug.Log("Ouch!");
        hearts[--lives].SetActive(false);

        if (lives == 0)
        {
            background.GetComponent<GameManager>().GameOver();
        }
    }
}
