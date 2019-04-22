using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

    GameObject pointText;
    int point = 0;

    public void largestar()
    {
        this.point += 20;
    }

    public void smallstar()
    {
        this.point += 10;
    }

    public void largecloud()
    {
        this.point += 40;
    }
    public void smallcloud()
    {
        this.point += 30;
    }

    // Use this for initialization
    void Start () {
        this.pointText = GameObject.Find("point");

    }
	
	// Update is called once per frame
	void Update () {
        this.pointText.GetComponent<Text>().text = this.point.ToString() + " point";
    }
}
