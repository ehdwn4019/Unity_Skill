using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] GameObject m_goPrefab = null;
    [SerializeField] Transform m_tfArrow = null;

    Camera m_cam = null;

    // Start is called before the first frame update
    void Start()
    {
        m_cam = Camera.main;
    }

    void LookAtmouse()
    {
        Vector2 t_mousePos = m_cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 t_direction = new Vector2(t_mousePos.x - m_tfArrow.position.x, t_mousePos.y - m_tfArrow.position.y);

        m_tfArrow.right = t_direction;
    }

    void TryFire()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject t_arrow = Instantiate(m_goPrefab, m_tfArrow.position, m_tfArrow.rotation);
            t_arrow.GetComponent<Rigidbody2D>().velocity = t_arrow.transform.right * 10f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        LookAtmouse();
        TryFire();
    }
}
