using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomDrop : MonoBehaviour
{
    public GameObject gem;
    public List<GameObject> gemList = new List<GameObject>();
    TextMeshProUGUI text;
    public GameObject canvas;
    int count; 
    // Start is called before the first frame update
    void Start()
    { 
        text = canvas.AddComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        int randVal = Random.Range(0, 600); 

        if(count < 10)
        {
            if (randVal == 4)
            {
                Vector3 randomSpawnPosition = new Vector3(Random.Range(-8, 8), 8, 0);
                GameObject g = new GameObject();

                g = Instantiate(gem, randomSpawnPosition, Quaternion.Euler(-90, 0, 0));
                gemList.Add(g);
            }

            for (int i = 0; i < gemList.Count; i++)
            {
                OnCollisionEnter(Collision.gemList[i], i);
            }

        }


        else if (count >= 10)
        {
            gemList.Clear();
            text.text = "Game Over -- Press Space to Quit";
            if (Input.GetKey(KeyCode.Space))
            {
                UnityEditor.EditorApplication.isPlaying = false;
            }

        }

    }

    void OnCollisionEnter(Collision collision, int i)
    {
        count++;
        Destroy(gemList[i]);
        gemList.Remove(gemList[i]);
    }
}

class Gem {
    GameObject gem; 
    public Gem(GameObject gem)
    {
        gem = new GameObject(); 
    }
    void OnCollisionEnter(Collision collision, int i)
    {
        count++;
        Destroy(gemList[i]);
        gemList.Remove(gemList[i]);
    }

}

