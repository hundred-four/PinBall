using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallCotroller : MonoBehaviour
{
    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;
    private GameObject scoreText;
    public GameObject replay;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");
        this.scoreText = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        this.scoreText.GetComponent<Text>().text="SCORE:"+score.ToString("d6");

        if (this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

        if (this.transform.position.y < -100)
        {
            this.replay.SetActive(true);
        }
        
    }

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 50;
        }

        if (other.gameObject.tag == "LargeStarTag")
        {
            score += 200;
        }

        if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 500;
        }
    }
}
