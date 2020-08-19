using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public Transform startPos;
    

    public int moveVel = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x != GameManager.instance.endPosBG.position.x)
        {
            transform.position = Vector3.MoveTowards(transform.position, GameManager.instance.endPosBG.position, Time.deltaTime * moveVel);
        }
        else
        {
            transform.position = startPos.position;
        }
    }
}
