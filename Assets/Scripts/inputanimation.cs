using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class inputanimation : MonoBehaviour
{
    public InputActionAsset tobbesPlayerAction;
    public Animator tobbesAnimator;
    
  

    // Update is called once per frame
    void Update()
    {
        if (tobbesPlayerAction.FindAction("Move").IsPressed())
        {
            tobbesAnimator.SetBool("run", true);
        }
        else
        tobbesAnimator.SetBool("run", false);
            
        }
    }

