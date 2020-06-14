using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCube : MonoBehaviour
{
    //public GameObject m_goPrefab = null;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CreaterCoroutine());
    }


    IEnumerator CreaterCoroutine()
    {
        while (true)
        {
            yield return null;
            GameObject t_object = ObjectPoolingManager.instance.GetQueue();
            t_object.transform.position = Vector3.zero;
            //Instantiate(m_goPrefab, Vector3.zero, Quaternion.identity);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
