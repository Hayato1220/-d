using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{
    public Transform tr;
    public GameObject bag;

    public Vector3 vec;
    // Start is called before the first frame update
    void Start()
    {
        tr = this.transform;
        vec = bag.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButton("pad"))
        {
            vec.y -= 0.01f;
            if(vec.y < 0.6f)
            {
                vec.y = 0.6f;
            }
            tr.localPosition = vec;
        }
        else
        {
            vec.y += 0.01f;
            if (vec.y > 1.2f)
            {
                vec.y = 1.2f;
            }
            tr.localPosition = vec;
        }
    }
}
