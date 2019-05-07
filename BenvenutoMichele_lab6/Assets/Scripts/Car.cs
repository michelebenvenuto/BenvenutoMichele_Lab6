using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Car : MonoBehaviour
{
    public GameObject[] path;
    private int toGo = 0;
    private GameObject next;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (toGo < path.Length)
        {
            if (!GetComponent<NavMeshAgent>().hasPath)
            {
                next = path[toGo];
                Debug.Log(toGo);
                toGo += 1;
                GetComponent<NavMeshAgent>().SetDestination(next.transform.position);
            }
        }
        else {
            toGo = 0;
        }
    }
}
