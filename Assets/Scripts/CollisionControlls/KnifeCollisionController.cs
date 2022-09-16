using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class KnifeCollisionController : MonoBehaviour
{
    [SerializeField] private KnifeDrag dragging;
    public Vector3 defaultPosition;
    
    private MaskObject _maskObject;
    
    private void Start()
    {
        defaultPosition = this.dragging.gameObject.transform.position;
        _maskObject = GetComponent<MaskObject>();
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("SoapEndPoint"))
        {
            dragging.DraggingActivation(false);

            _maskObject.HideFirstLayer();

            dragging.gameObject.transform.DOMove(defaultPosition, 2f).OnComplete(() =>
            {               
                _maskObject.MaskTheObject();

                if (_maskObject.objMasked.Count != 0)
                {
                    var valueY = dragging.gameObject.transform.position.y;
                    dragging.gameObject.transform.DOMoveY(valueY - 0.07f, 0.5f).OnComplete(() => { dragging.DraggingActivation(true); });             
                }
            });
        }

        if (other.gameObject.CompareTag("CutPoint"))
        {
            other.gameObject.GetComponent<CutCube>().InstantiateCubes();
        }
    }

   
}
