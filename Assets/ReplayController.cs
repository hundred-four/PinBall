using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayController : MonoBehaviour
{
    public GameObject ballPos;
    private float visiblePosY = -100f;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        /*if (ballPos.transform.position.y < this.visiblePosY)
        {
            this.gameObject.SetActive(true);
        }
        Debug.Log("deteru?" + ballPos.transform.position);
        */

    }
    public void Replay()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
