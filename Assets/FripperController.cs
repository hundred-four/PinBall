using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController : MonoBehaviour
{
    private HingeJoint myHingejoint;
    private float defaultAngle = 20;
    private float flickAngle = -20;

    // Start is called before the first frame update
    void Start()
    {
        this.myHingejoint = GetComponent<HingeJoint>();
        SetAngle(this.defaultAngle);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
    }

    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingejoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingejoint.spring = jointSpr;
    }
}
