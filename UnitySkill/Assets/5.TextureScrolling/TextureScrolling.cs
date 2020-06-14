using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScrolling : MonoBehaviour
{
    [SerializeField] Vector2 m_offset = Vector2.zero;

    MeshRenderer m_mesh = null;


    // Start is called before the first frame update
    void Start()
    {
        m_mesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        m_mesh.material.mainTextureOffset += m_offset * Time.deltaTime;
    }
}
