using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour {

    public static int pointSum = 0;
    public GameObject pointText;
	// Use this for initialization
	void Start () {
        this.pointText = GameObject.Find("PointText");
        this.pointText.GetComponent<Text>().text = "0";
    }

    // Update is called once per frame
    void Update () {
        this.pointText.GetComponent<Text>().text = pointSum.ToString();
    }
}
