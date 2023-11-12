using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextEndGame : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI text;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Game Over -- Press Space to Quit";
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Application.Quit();
        }
    }
}
