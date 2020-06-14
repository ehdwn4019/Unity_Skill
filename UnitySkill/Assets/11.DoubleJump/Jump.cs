using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] float m_jumpForce = 0f;
    [SerializeField] int m_maxJumpCount = 0;
    int m_jumpCount = 0;

    Rigidbody m_rigid = null;

    float m_distance = 0f;
    [SerializeField] LayerMask m_layerMask = 0;

    // Start is called before the first frame update
    void Start()
    {
        m_rigid = GetComponent<Rigidbody>();
        m_distance = GetComponent<BoxCollider>().bounds.extents.y + 0.05f;
    }

    void TryJump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(m_jumpCount<m_maxJumpCount)
            {
                m_jumpCount++;
                m_rigid.velocity = Vector2.up * m_jumpForce;
            }
        }
    }

    //void CheckGround()
    //{
    //    if(m_rigid.velocity.y<0)
    //    {
    //        RaycastHit t_hit = Physics.Raycast(transform.position, Vector3.down, m_distance, m_layerMask);
    //
    //        if(t_hit)
    //        {
    //            if(t_hit.transform.CompareTag("Ground"))
    //            {
    //                m_jumpCount = 0;
    //            }
    //        }
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        TryJump();
        //CheckGround();
    }
}
