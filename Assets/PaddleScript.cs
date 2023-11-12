using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            if(transform.position.x < 8)
            {
                transform.Translate(Vector3.right * Time.deltaTime * 4);

            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(transform.position.x > -8)
            {
                transform.Translate(Vector3.left * Time.deltaTime * 4);
            }
        }

    }
}
