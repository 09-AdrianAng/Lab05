using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class CollisionCheck : MonoBehaviour
{
    public Text PointText;
    public GameObject Effects;

    private float TimerValue;
    private float scorevalue;
    public float totalcoins;
    public float timeleft;

    public int timeRemaining;

    public Text Timetext;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        timeleft -= Time.deltaTime;
        timeRemaining = Mathf.FloorToInt(timeleft % 60);
        Timetext.text = "Timer: " + timeRemaining.ToString();

        if (scorevalue == totalcoins)
        {
            if (timeleft <= TimerValue)
            {
                SceneManager.LoadScene("GameWin_Scene");
            }
        }
        else if (timeleft <= 0)
        {
            SceneManager.LoadScene("GameLose_Scene");
        }

        GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.m_cursorIsLocked = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            scorevalue += 10;
            PointText.text = "Points: " + scorevalue;
            Destroy(other.gameObject);
            Instantiate(Effects, other.transform.position, Quaternion.identity);
        }
        if (other.gameObject.tag == "Water")
        {
            SceneManager.LoadScene("GameLose_Scene");
            GameObject.Find("FPSController").GetComponent<FirstPersonController>().m_MouseLook.m_cursorIsLocked = false;
        }
    }


}
