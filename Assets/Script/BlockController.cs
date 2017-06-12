using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour {

    private Vector3 targetPosition;
    private Quaternion targetRotation;

    private void Start()
    {
        transform.position = new Vector3(0, 3, 0); 
    }

    void Update()
    {
        //game mechanism for moving blocks in four directions
        if (Input.GetKeyDown("up"))
        {
            transform.Translate(0, 0, 1.600001f);
        }

        if (Input.GetKeyDown("down"))
        {
            transform.Translate(0, 0, -1.600001f);
        }


        if (Input.GetKeyDown("right"))
        {
            transform.Translate(3.200001f, 0, 0);
        }

        if (Input.GetKeyDown("left"))
        {
            transform.Translate(-3.200001f, 0, 0);
        }
        
        //press space to snap a block into a ground 
        if (Input.GetKeyDown("space"))
        {
            RaycastHit hit;
            if (Physics.Raycast (transform.position, -Vector3.up, out hit))
            {
                Instantiate(this, hit.point, Quaternion.identity);
            }

        }
    }
    
}
