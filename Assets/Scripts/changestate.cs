using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changestate : MonoBehaviour
{
    public Animator playerAnimator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void changeState()
    {
        playerAnimator.SetBool("idle", true);
        Debug.Log(playerAnimator.GetBool("idle"));
        Debug.Log("Done");
    }
}
