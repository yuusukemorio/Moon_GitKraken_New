using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class walk : MonoBehaviour
{
    CinemachineDollyCart CinemaDC;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        CinemaDC = GetComponent<CinemachineDollyCart>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            CinemaDC.m_Position = CinemaDC.m_Position + speed;
        }   
     else if (Input.GetKey(KeyCode.DownArrow))
        {
            CinemaDC.m_Position = CinemaDC.m_Position - speed;
        }
    }
}
