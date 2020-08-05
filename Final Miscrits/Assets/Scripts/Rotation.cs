using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private GameObject goPlayer;
    [SerializeField] Animator anim;

    void Update()
    {

        RotationAndAnimation();
    }

    void RotationAndAnimation()
    {

        Vector3 v3Pos;
        float fAngle;

        if (Input.GetMouseButton(0))
        {

            //Convert the player to Screen coordinates
            v3Pos = Camera.main.WorldToScreenPoint(goPlayer.transform.position);
            v3Pos = Input.mousePosition - v3Pos;
            fAngle = Mathf.Atan2(v3Pos.y, v3Pos.x) * Mathf.Rad2Deg;
            if (fAngle < 0.0f) fAngle += 360.0f;
           // Debug.Log(fAngle);
            if (fAngle > 15 && fAngle < 75)
            {
                anim.Play("northeastrun");
            }
            if (fAngle > 75 && fAngle < 105)
            {
                anim.Play("northrun");
            }
            if (fAngle > 105 && fAngle < 165)
            {
                anim.Play("northwestrun");
            }
            if (fAngle > 165 && fAngle < 195)
            {
                anim.Play("westrun");
            }
            if (fAngle > 195 && fAngle < 255)
            {
                anim.Play("southwestrun");
            }
            if (fAngle > 255 && fAngle < 285)
            {
                anim.Play("southrun");
            }
            if (fAngle > 285 && fAngle < 345)
            {
                anim.Play("southeastrun");
            }
            if ((fAngle > 345 && fAngle < 360) || (fAngle > 0 && fAngle < 15))
            {
                anim.Play("eastrun");
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            anim.Play("idle");
        }
    }
}