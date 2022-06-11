using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    Animator m_animator;
    Animator m_Ramrod_animator;
    Factory m_Factory;
    void Start()
    {
        m_animator = transform.GetComponent<Animator>();
        m_Ramrod_animator = GameObject.Find("Ramrod").GetComponent<Animator>();
        m_Factory = GameObject.Find("Factory").GetComponent<Factory>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setActTrue()
    {
        m_animator.SetBool("act", true);
        m_Ramrod_animator.SetBool("act", false);
    }

    public void setActFalse()
    {
        m_animator.SetBool("act", false);
        m_animator.SetBool("up", false);
        m_Factory.CloneBalls();
    }

    public void setRamrodTrue()
    {
        m_Ramrod_animator.SetBool("act", true);
    }

    public void setRamrodFalse()
    {
        m_Ramrod_animator.SetBool("act", false);
    }

    public void setUpTrue()
    {
        m_animator.SetBool("up", true);
    }
}
