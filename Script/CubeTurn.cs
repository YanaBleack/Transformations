using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTurn : MonoBehaviour
{
    [SerializeField] private Vector3 _rotate;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(_rotate * _speed);
    }
}
