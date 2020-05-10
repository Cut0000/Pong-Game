using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoringScript : MonoBehaviour
{
    public TextMeshProUGUI scoringtextP1, scoringtextP2;
    public  static int scoreP1=0, scoreP2=0;
    // Start is called before the first frame update
    void Start()
    {
        scoringtextP1.text = scoreP1.ToString();
        scoringtextP2.text = scoreP2.ToString();
    }

    // Update is called once per frame
    public void UpdateScore(string namaWall)
    {
        if(namaWall=="Tembokkiri"){
            scoreP2 += 1;
            scoringtextP2.text = scoreP2.ToString();
        }else if(namaWall=="Tembokkanan"){
            scoreP1 += 1;
            scoringtextP1.text = scoreP1.ToString();
        }
    }
}
