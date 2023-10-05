using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static UnityEngine.GraphicsBuffer;

public class MovementAI : MonoBehaviour
{
    [SerializeField] private float maxSpeed;
    [SerializeField] private float targetRadius;
    
    private Transform currentTarget;

    public event UnityAction OnReachedTarget;

    // Update is called once per frame
    void Update()
    {
        if (currentTarget != null)
        {
            Steer();
        }
    }

    public void Steer()
    {
        Vector3 direction = currentTarget.position - transform.position;
        float distance = direction.magnitude;

        if (distance <= targetRadius)
        {
            OnReachedTarget?.Invoke();
            return;
        }

        Vector3 velocity = direction.normalized * (distance / targetRadius);

        if (velocity.magnitude > maxSpeed)
        {
            velocity = velocity.normalized * maxSpeed;
        }

        float newX = transform.position.x + velocity.x * Time.deltaTime;
        float newZ = transform.position.z + velocity.z * Time.deltaTime;

        transform.position = new Vector3(newX, 0f, newZ);
        FaceTarget(currentTarget.position);
    }

    public void FaceTarget(Vector3 targetPosition)
    {
        Vector3 facing;
        facing = targetPosition - transform.position;
        facing.y = 0f;
        facing.Normalize();

        //Apply Rotation
        Quaternion targ_rot = Quaternion.LookRotation(facing, Vector3.up);
        Quaternion nrot = Quaternion.RotateTowards(transform.rotation, targ_rot, 360f);
        transform.rotation = nrot;
    }

    public void SetTarget(Transform target)
    {
        currentTarget = target;
    }

    public void ClearTarget()
    {
        currentTarget = null;
    }    
}
