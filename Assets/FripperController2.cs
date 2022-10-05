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
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = new Touch();
            touch = Input.touches[i];

                if (touch.phase == TouchPhase.Began && touch.position.x < 540 && tag == "LeftFripperTag")
                {
                    SetAngle(this.flickAngle);
                }

                if (touch.phase == TouchPhase.Began && touch.position.x > 540 && tag == "RightFripperTag")
                {
                    SetAngle(this.flickAngle);
                }


                if (touch.phase == TouchPhase.Ended && touch.position.x < 540 && tag == "LeftFripperTag")
                {
                    SetAngle(this.defaultAngle);
                }

                if (touch.phase == TouchPhase.Ended && touch.position.x > 540 && tag == "RightFripperTag")
                {
                    SetAngle(this.defaultAngle);
                }
            
        }

            //Debug.Log("touch1=" + touch1);

        

    }

    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingejoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingejoint.spring = jointSpr;
    }
}
