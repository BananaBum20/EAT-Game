using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : MonoBehaviour
{
    bool _isFrozen;
    public float duration = 1f;
    float _pendingFreezeDuration = 0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Goal")
        {
            Time.timeScale = 0.0f;
            Debug.Log("goal was touched");
            Freezer();
        }
        else if (collision.tag == "Obstacle")
        {
            Time.timeScale = 0.0f;
            Debug.Log("obstacle was touched");
            Freezer();
        }
        
    }

     void Update()
    {
        if (_pendingFreezeDuration > 0 && ! _isFrozen)
        {
            StartCoroutine(DoFreeze());
        }
    }

    public void Freezer()
    {
        _pendingFreezeDuration = duration;
    }

    IEnumerator DoFreeze()
    {
        _isFrozen = true;
        var original = Time.timeScale;
        Time.timeScale = 0f;

        yield return new WaitForSecondsRealtime(duration);

        Time.timeScale = original;
        _pendingFreezeDuration = 0;
        _isFrozen = false;
    }
}
