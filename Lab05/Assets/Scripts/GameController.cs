using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GameController : MonoBehaviour
{
    public GameObject ghost;
    public GameObject player;

    private NavMeshAgent m_agent;

    // public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        m_agent = ghost.GetComponent<NavMeshAgent>();
        // canvas = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        m_agent.SetDestination(player.transform.position);
    }
}
