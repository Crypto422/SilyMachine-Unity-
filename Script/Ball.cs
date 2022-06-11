using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.name.Equals("Button"))
        {
            other.transform.parent.GetComponent<Button>().setActTrue();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.name.Equals("Button"))
        {
            collision.transform.parent.GetComponent<Button>().setUpTrue();
        }
    }
}
