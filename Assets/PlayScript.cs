﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{
    public void mulai(){
        SceneManager.LoadScene("SampleScene"); //scene mana yang ingin kita tuju
    }
}
