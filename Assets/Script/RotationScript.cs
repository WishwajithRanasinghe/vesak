using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private bool _isLeft;

    public bool _isStart;


    private void Update()
    {
        if (_isStart)
        {
            if (_isLeft)
            {
                transform.Rotate(Vector3.forward * -_rotationSpeed * Time.deltaTime);
            }
            else
            {
                transform.Rotate(Vector3.forward * _rotationSpeed * Time.deltaTime);
            }
        }
        
    }
}
