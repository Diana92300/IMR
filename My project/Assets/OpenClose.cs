using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;


public class OpenClose : MonoBehaviour
{
    private Animator mAnimator;
    public GameObject P1;
    public GameObject P2;
    public float dist;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position1 = P1.transform.position;
        Vector3 position2 = P2.transform.position;
        dist = Vector3.Distance(position1, position2);

        if (dist>=0.25)
        {
            mAnimator.SetTrigger("Tr-Idle");
        }
         else
        {
            mAnimator.SetTrigger("Tr-Attack");
        }
    }
}
