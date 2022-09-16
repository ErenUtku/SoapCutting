using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutCube : MonoBehaviour
{
    [SerializeField] private GameObject cutCubeObject;
    
    private SoapCutters _soapCutters;
    private int _cutCount;

    private void Start()
    {
        _soapCutters = GetComponentInParent<SoapCutters>();
        _cutCount = _soapCutters.cutAmount;
    }
    
    public void InstantiateCubes()
    {
        for (int i = 0; i < _cutCount; i++)
        {
            var instObject = Instantiate(cutCubeObject, transform.position, Quaternion.identity);
        }
    }
}
