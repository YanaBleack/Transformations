using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleSaze : MonoBehaviour
{
    [HideInInspector] public Transform Transform;
    [SerializeField] private float _duration;
    
    private Vector3 _scaleChange;
    private float _runningTime;
   
   private void Start()
    {
        Transform = GetComponent<Transform>();      
    }

    private void Update()
    {
        if (_runningTime <= _duration)
        {
            _runningTime += Time.deltaTime;

            float normalizeRunningTime = _runningTime / _duration;

            _scaleChange = new Vector3(1 * normalizeRunningTime, 1 * normalizeRunningTime, 1 * normalizeRunningTime);
            Transform.localScale = _scaleChange;         
        } 
    }
}
