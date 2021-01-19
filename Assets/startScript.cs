using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class startScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.Find("AStarGrid").GetComponent<AstarPath>().enabled = true;
            GameObject.Find("Robot").GetComponent<customAIMoveScriptGrid>().enabled = true;

        }
    }

    
}
