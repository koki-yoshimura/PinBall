using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    private GameObject director;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;
 
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "LargeStarTag")
        {
            this.director.GetComponent<GameDirector>().largestar();
        }
        else if (other.gameObject.tag == "SmallStarTag")
        {
            this.director.GetComponent<GameDirector>().smallstar();
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            this.director.GetComponent<GameDirector>().smallcloud();
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            this.director.GetComponent<GameDirector>().largecloud();
        }
    }

    // Use this for initialization
    void Start()
    {
        this.director = GameObject.Find("point");

        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";


        }
    }
}