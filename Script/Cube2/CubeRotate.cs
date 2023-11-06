using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    [SerializeField] private Vector3 _rotate;
    [SerializeField] private float _duration;

    private void Update()
    {
        transform.Rotate(_rotate * _duration);
    }
}
