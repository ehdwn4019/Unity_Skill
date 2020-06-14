using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    Rigidbody m_myrigid = null;

    private void OnEnable()
    {
        if(m_myrigid==null)
        {
            m_myrigid = GetComponent<Rigidbody>();
        }

        m_myrigid.velocity = Vector3.zero;
        m_myrigid.AddExplosionForce(1000, transform.position, 1f);

        StartCoroutine(DestroyCube());
    }

    IEnumerator DestroyCube()
    {
        yield return new WaitForSeconds(1f);
        //Destroy(gameObject);
        ObjectPoolingManager.instance.InserQueue(gameObject);


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
