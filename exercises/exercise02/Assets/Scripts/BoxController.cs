using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Target")
        {
            col.gameObject.GetComponent<Renderer>().material.color = Color.red;

            // If you wanted to remove the cube rather than change its color, you
            // would "Destroy" it using the following line of code.
            //Destroy(col.gameObject);
        }
    }
}
