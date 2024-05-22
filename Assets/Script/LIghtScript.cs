using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LIghtScript : MonoBehaviour
{
    [SerializeField] private Material _material1;
    [SerializeField] private Material _material2;
    [SerializeField] private RotationScript[] _rotationScript;
    [SerializeField] private float _startTime;
    

    private void Start()
    {
        _material1.SetFloat("_isLightOn", 0.0f);
        _material2.SetFloat("_isLightOn", 0.0f);
        for (int i= 0; i < _rotationScript.Length; i++)
        {
            _rotationScript[i]._isStart = false;
            
            
        }
        
    }

    // Update is called once per frame
    private void Update()
    {
        _startTime -= Time.deltaTime;
        if(_startTime <= 1.5)
        {
            _material1.SetFloat("_isLightOn", 1.0f);
            _material2.SetFloat("_isLightOn", 1.0f);
        }
        if(_startTime <= 0)
        {
            for (int i = 0; i < _rotationScript.Length; i++)
            {
                _rotationScript[i]._isStart = true;
                
            }
            

            _startTime = 0;
        }

    }
}
