using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracking : MonoBehaviour
{
    public Transform m_target;
    public float m_speed = 5;
    public float m_attenuation = 0.5f;
    public Vector3 offset;

    private Vector3 m_velocity;

    private void Update()
    {
        m_velocity += (m_target.position - transform.position) * m_speed;
        m_velocity *= m_attenuation;
        m_velocity += offset;

        transform.position += m_velocity *= Time.deltaTime;
    }
}