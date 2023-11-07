using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogFlume : MonoBehaviour
{
    public int NumberOfLogs { get; set; }

    private int _queueSize;
    public int QueueSize
    {
        get 
        {
            return _queueSize;
        }
        set
        {
            _queueSize = value;

            if (_queueSize > 3)
            {
                NumberOfLogs++;
                NumberOfStaff++;
            }
        }
    }    

    public int NumberOfStaff { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        QueueSize++;
        QueueSize++;
        QueueSize++;
        QueueSize++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
