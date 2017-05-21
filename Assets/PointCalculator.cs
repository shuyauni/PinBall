using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCalculator : MonoBehaviour {
    private int SmallStarPoint = 10;
    private int LargeStarPoint = 20;
    private int SmallCloudPoint = 5;
    private int LargeCloudPoint = 15;
    private int PointSum = 0;
    private int Count = 0;

    private GameObject pointText;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (this.Count == 1)
        {
            if (tag == "SmallStarTag")
            {
                PointManager.pointSum += SmallStarPoint;
            }else if (tag == "LargeStarTag")
            {
                PointManager.pointSum += LargeStarPoint;
            }else if(tag == "SmallCloudTag")
            {
                PointManager.pointSum += SmallCloudPoint;
            }else if (tag == "LargeCloudTag")
            {
                PointManager.pointSum += LargeCloudPoint;
            }
            this.Count=0;    
        }
        
    }

    void OnCollisionEnter(Collision other)
    {
        this.Count=1;
    }
}
