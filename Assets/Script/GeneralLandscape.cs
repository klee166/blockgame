using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralLandscape : MonoBehaviour {

    public int width = 10;
    public int depth = 10;

    public GameObject block;
    private BoxCollider b_collider;

	// Use this for initialization
	void Start () {

        for (int z = 0; z < depth; z++)
        {
            for (int x = 0; x < width; x++) {

            float width_box = x * 3.200001f / 2.0f;
            float height_box = z * 1.600001f * 2.0f;
            int y = 0;
            Vector3 blockPos = new Vector3(height_box, y, width_box);
            Instantiate(block, blockPos, Quaternion.identity);
        }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
