﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndingScript : MonoBehaviour
{
    public TextMeshProUGUI endingtext;
   
    // Start is called before the first frame update
    void Start()
    {
        if(ScoringScript.scoreP1 > ScoringScript.scoreP2){
            endingtext.text = "Player 1 menang";
        }else if(ScoringScript.scoreP1 < ScoringScript.scoreP2){
            endingtext.text = "Player 2 menang";
        }else{
            endingtext.text = "keduanya menang";
        }
    }

}