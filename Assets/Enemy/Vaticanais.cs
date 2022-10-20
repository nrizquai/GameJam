using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vaticanais : MonoBehaviour
{ 
    [SerializeField] private float _speed;
    private Transform _target;
    void Awake()
    {
        _target = FindObjectOfType<PControl>().transform;

    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }
}