using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class MouvementsSousMarin : MonoBehaviour
{
    [SerializeField] private float _vitessePromenade;
    private Rigidbody _rb;
    private Vector3 directionInput;//Travail en Vector3 et non en axis
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void OnDirections(InputValue directionBase)
    {
        Vector3 directionAvecVitesse = directionBase.Get<Vector3>() * _vitessePromenade;
        directionInput = new Vector3(0f, directionAvecVitesse.z, directionAvecVitesse.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
