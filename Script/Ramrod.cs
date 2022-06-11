using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramrod : MonoBehaviour
{
    // Start is called before the first frame update
    Animator m_animator;
    void Start()
    {
        m_animator = GameObject.Find("Ramrod").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetBackward()
    {
        m_animator.SetBool("backwrad", true);
        m_animator.SetBool("forward", false);
    }

    public void setForward()
    {
        m_animator.SetBool("forward", true);
        m_animator.SetBool("backward", false);
    }
}
