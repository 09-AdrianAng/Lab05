using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionCheck : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore;

    void OnTriggerEnter(Collider other)
    {
        theScore += 10;
        scoreText.GetComponent<Text>().text = "Score: " + theScore;
        Destroy(gameObject);
    }
}
