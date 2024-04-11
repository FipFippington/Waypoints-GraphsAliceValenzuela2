using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowWaypoints : MonoBehaviour {


    GameObject[] wps;
    GameObject currentNode;
    NavMeshAgent agent;
    public GameObject wpManager;

    void Start() 
    {
        Time.timeScale = 5.0f;
        wps = wpManager.GetComponent<WPManager>().waypoints;
        currentNode = wps[0];

        agent = this.GetComponent<NavMeshAgent>();
    }

    public void GotoHeli() 
    {
        //g.AStar(currentNode, wps[0]);
        agent.SetDestination(wps[0].transform.position);
    }

    public void GotoRuin() 
    {
        //g.AStar(currentNode, wps[7]);
        agent.SetDestination(wps[7].transform.position);
    }

    public void GotoRock() 
    {
        //g.AStar(currentNode, wps[1]);
        agent.SetDestination(wps[1].transform.position);
    }

    public void GotoFactory() 
    {
        //g.AStar(currentNode, wps[4]);
        agent.SetDestination(wps[4].transform.position);
    }
}
