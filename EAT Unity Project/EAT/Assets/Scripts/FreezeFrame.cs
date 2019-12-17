using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeFrame : MonoBehaviour
{
    public float duration = 1f; // how long the frame will freeze for
    bool _isFrozen = false; // to check if the frame is already frozen
    float _pendingFreezeDuration = 0f; // track duration

    public void Freeze() // made for other scriptes to call it if needed
    {
        _pendingFreezeDuration = duration;
    }
    //IEnumerator Do
    // Update is called once per frame
    void Update()
    {
        if (_pendingFreezeDuration < 0 && !_isFrozen)
        {
            // Do something
            //StartCoroutine(DoFreeze());
        } 
    }
   //IEnumerator DoFreeze()
   

   
}
