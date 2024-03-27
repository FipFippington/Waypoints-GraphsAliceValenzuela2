using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWaypoints : MonoBehaviour
{
    Transform goal;
    float speed = 5.0f;
    float accuracy = 1.0f;
    float rotSpeed = 2.0f;

    public GameObject wpManager;
    GameObject[] wps;
    GameObject currentNode;
    int currentWp = 0;
    Graph g;

    // Start is called before the first frame update
    void Start()
    {
        wps = wpManager.GetComponent<WpManager>().waypoints;
        g = wpManager.GetComponent<WpManager>().graph;
        currentNode = wps[];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
