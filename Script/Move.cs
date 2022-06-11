using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
     Transform target;
     float distance = 7;
     float xSpeed = 250.0f;
     float ySpeed = 120.0f;
     float yMinLimit = -20;
    public float sensitivity = 1;
    public float maxdistance = 50;
    public float mindistance = 5;
     float yMaxLimit = 80;
    private float x = 0.0f;
    private float y = 0.0f;
    private bool flag_rotate = false;
    private float rotate_speed = 0;

    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;

        // Make the rigid body not change rotation
        if (GetComponent<Rigidbody>())
        {
            GetComponent<Rigidbody>().freezeRotation = true;
        }

        target = GameObject.Find("camTarget").transform;
    }

    void LateUpdate()
    {

        // allow or dismiss rotate
        if (Input.GetMouseButtonDown(0))
        {
            flag_rotate = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            flag_rotate = false;
        }

        // rotate aroubd target
        if (target)
        {
            x += rotate_speed;
            if (flag_rotate)
            {
                rotate_speed = Input.GetAxis("Mouse X") * xSpeed * 0.02f * sensitivity;
                x += Input.GetAxis("Mouse X") * xSpeed * 0.02f * sensitivity;
               
                if (Input.GetKey((KeyCode.LeftShift)) || Input.GetKey((KeyCode.RightShift)))
                {
                    distance -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f * sensitivity;
                    if (distance > maxdistance)
                        distance = maxdistance;
                    if (distance < mindistance)
                        distance = mindistance;
                } else
                {
                    y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f * sensitivity;
                }
            }

            // control y limit
            //  yMinLimit = -(Mathf.Asin(1 / distance) * 180 / Mathf.PI) + 10;      // 5 means camera center`s height and 1 means absolute limit of y axis

            ClampAngle(y, yMinLimit, yMaxLimit);

            Quaternion rotation = Quaternion.Euler(y, x, 0);
            Vector3 position = rotation * new Vector3(0.0f, 0.0f, -distance) + target.position;

            transform.rotation = rotation;
            transform.position = position;
        }
    }

    public float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360)
            angle += 360;
        if (angle > 360)
            angle -= 360;
        angle = Mathf.Clamp(angle, min, max);
        return y = angle;
    }


    // control the Gameobject of building


    void Update()
    {

    }

    // to refresh buiding by state_day

}


