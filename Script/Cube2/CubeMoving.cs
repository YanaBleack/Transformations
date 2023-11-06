using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoving : MonoBehaviour
{
    [SerializeField] private float _speed;

   
    private void Update()
    {
        transform.Translate(new Vector3(_speed, 0, 0) * Time.deltaTime);
    }
}
