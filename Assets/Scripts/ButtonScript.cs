﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void OnRestartClick()
    {
        SceneManager.LoadScene("GameScene");
    }
}
