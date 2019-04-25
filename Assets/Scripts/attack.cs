using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public GameObject sword;
    private Vector3 initSwordPos = Vector3.zero;
private Quaternion initSwordRot = Quaternion.identity;
    
    private void Start()
    {
        
        initSwordPos = sword.transform.localPosition;
        initSwordRot = sword.transform.localRotation;
    }


    // Update is called once per frame
    void Update()
    {
        if(sword.transform.localPosition.y > initSwordPos.y)
            sword.transform.localPosition -= Vector3.up * 0.04f;

        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //attack
            if(sword.transform.localPosition.y <= initSwordPos.y)
                sword.transform.localPosition += Vector3.up * 0.2f;
            //swing
            //hitthings

        } 
    }
}
