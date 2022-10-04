using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FripperController2 : MonoBehaviour
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
        if (Input.touchCount > 0)
        {
            Touch touch0 = Input.touches[0];
            Touch touch1 = Input.touches[1];


            if (touch0.phase == TouchPhase.Began && touch0.position.x<540 && tag == "LeftFripperTag")
            {
                SetAngle(this.flickAngle);
            }

            if (touch0.phase == TouchPhase.Began && touch0.position.x > 540 && tag == "RightFripperTag")
            {
                SetAngle(this.flickAngle);
            }


            if (touch0.phase == TouchPhase.Ended && touch0.position.x < 540 && tag == "LeftFripperTag")
            {
                SetAngle(this.defaultAngle);
            }

            if (touch0.phase == TouchPhase.Ended && touch0.position.x>540  && tag == "RightFripperTag")
            {
                SetAngle(this.defaultAngle);
            }

            Debug.Log("touch0=" + touch0);
            //Debug.Log("touch1=" + touch1);

        }

    }

    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingejoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingejoint.spring = jointSpr;
    }
}
