using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRagDoll : MonoBehaviour
{
    [SerializeField] Animator enemyAnimator;

    private void Start()
    {
        SetRigidbodyState(true);
        SetColliderState(false);
    }
    public void death()
    {
        enemyAnimator.enabled = false;
        SetRigidbodyState(false);
        SetColliderState(true);
    }

    void SetRigidbodyState(bool state)
    {

        Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic = state;
        }

        GetComponent<Rigidbody>().isKinematic = state; // previously !state

    }

    void SetColliderState(bool state)
    {

        Collider[] colliders = GetComponentsInChildren<Collider>();

        foreach (Collider collider in colliders)
        {
            collider.enabled = state;
        }
        GetComponent<Collider>().enabled = !state;

    }
}
