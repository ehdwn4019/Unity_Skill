﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{
    //    
    //}

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray t_ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit t_hit;
            if (Physics.Raycast(t_ray, out t_hit, 100f))
            {
                t_hit.transform.GetComponent<Cube2>().Explosion();
            }
        }
        
    }
}
