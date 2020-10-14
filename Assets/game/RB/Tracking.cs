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

    public Camera_Collision CameraC;
    string CCscript;

    void Update()
    {
        CCscript = CameraC.nani_hureta;

        m_velocity += (m_target.position - transform.position) * m_speed;
        m_velocity *= m_attenuation;
        m_velocity += offset;

        transform.position += m_velocity *= Time.deltaTime;

        if (CCscript == "saisyo_hanntei")
        {
            offset = new Vector3(-7.51f, 17.4f, -10);
        }
        if (CCscript == "gomakasi")
        {
            offset = new Vector3(-7.51f, 17.4f, 2f);
        }
       

        if (CCscript == "paipu_in")
        {
            offset = new Vector3(-7.51f, 17.4f, 2f);
        }
        if (CCscript == "paipu_out")
        {
            offset = new Vector3(-4.74f, 13.83f, 5.9f);
        }




        if (CCscript == "hall_in")
        {
            offset = new Vector3(-4.74f, 13.83f, 5.9f);
        }
        if (CCscript == "hall_out")
        {
            offset = new Vector3(-4.74f, 13.83f, 5.9f);
        }


        if (CCscript == "tuuro_in")
        {
            offset = new Vector3(-4.74f, 13.83f, 5.9f);
        }
        if (CCscript == "tuuro_out")
        {
            offset = new Vector3(-12f, 12f, -1.23f);
        }



        if (CCscript == "tuuro2_in")
        {
            offset = new Vector3(-12f, 12f, -1.23f);
        }
        if (CCscript == "tuuro2_out")
        {
            offset = new Vector3(4f, 10.49f, 9.7f);
        }



        if (CCscript == "taiki-1_in")
        {

        }
        if (CCscript == "taiki-1_out")
        {

        }
        if (CCscript == "taiki-0.5_in")
        {

        }
        if (CCscript == "taiki-0.5_out")
        {

        }
        if (CCscript == "taiki_in")
        {
            offset = new Vector3(4f, 10.49f, 9.7f);
        }
        if (CCscript == "taiki_out")
        {
            offset = new Vector3(4f, 13f, 9.7f);
        }
        if (CCscript == "taiki2_in")
        {

        }
        if (CCscript == "taiki2_out")
        {

        }
        if (CCscript == "taiki3_in")
        {
            offset = new Vector3(4f, 13f, 9.7f);
        }
        if (CCscript == "taiki3_out")
        {
            offset = new Vector3(4f, 17.09f, -8.28f);
        }



        if (CCscript == "hatudenn_in")
        {
            offset = new Vector3(4f, 17.09f, -8.28f);
        }
        if (CCscript == "hatudenn_out")
        {
            offset = new Vector3(6.6f, 17.09f, 5);
        }



        if (CCscript == "kuraituuro_in")
        {

        }
        if (CCscript == "kuraituuro_out")
        {

        }



        if (CCscript == "tikagai_in")
        {

        }
        if (CCscript == "tikagai_out")
        {

        }
        if (CCscript == "tikagai2_in")
        {
            offset = new Vector3(6.6f, 17.09f, 5);
        }
        if (CCscript == "tikagai2_out")
        {
            offset = new Vector3(10.87f, 17.09f, 5);
        }
        if (CCscript == "tikagai3_in") 
        {

        }
        if (CCscript == "tikagai3_out")
        {

        }

        if (CCscript == "kurayami_in")
        {
            offset = new Vector3(10.87f, 17.09f, 5);
        }
        if (CCscript == "kurayami_out")
        {
            offset = new Vector3(-7.51f, 17.4f, 16.83f);
        }
        if (CCscript == "kurayami1.5_in")
        {
            offset = new Vector3(-7.51f, 17.4f, 16.83f);
        }
        if (CCscript == "kurayami1.5_out")
        {
            offset = new Vector3(-1.51f, 17.4f, 5.83f);
        }
        if (CCscript == "kurayami2_in")
        {
            offset = new Vector3(-1.51f, 17.4f, 5.83f);
        }
        if (CCscript == "kurayami2_out")
        {
            offset = new Vector3(-7.51f, 17.4f, -10);
        }


    }
}