using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    // Start is called before the first frame update
    Transform spawnPoint;
    void Start()
    {
        spawnPoint = gameObject.transform.Find("spawnPoint").transform;
        CloneBalls();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void CloneBalls()
    {
        var ball = Resources.Load<GameObject>("Prefabs/Ball") as GameObject;
        GameObject clone;
        clone = Instantiate(ball, spawnPoint.position, spawnPoint.rotation);

    }
}
