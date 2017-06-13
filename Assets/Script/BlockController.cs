using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour {

    private GameObject brick;
    private Vector3 targetPosition;
    private Quaternion targetRotation;
    private Vector3 targetLocation;

    private void Start()
    {
        transform.position = new Vector3(0, 5, 0);
        brick = Resources.Load("Lego_long_Bricks") as GameObject;
    }

    void Update()
    {
        RaycastHit hit;
        //Highlight a color
        if (Physics.Raycast(transform.position, Vector3.down, out hit))
        {
            Highlight(hit.transform.gameObject.GetComponent<Renderer>());

        }
        

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
            if (Physics.Raycast (transform.position, Vector3.down, out hit))
            {
                targetLocation = hit.point;
                
            }
            //targetLocation += new Vector3(0, transform.localScale.y / 2, 0);
            transform.position = targetLocation;
            BlockController script = GetComponent<BlockController>();
            script.enabled = false;
            Instantiate(brick, new Vector3(0, 5, 0), Quaternion.identity);

            
          
        }
    }


    // The method that highlights color of ground
    void Highlight(Renderer rend)
    {
        Color originalColor = rend.material.color;
        rend.material.color = Color.yellow;
       
        rend.material.color = originalColor;
    }
    
}
