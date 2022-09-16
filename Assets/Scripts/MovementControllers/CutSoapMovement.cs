using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CutSoapMovement : MonoBehaviour
{
    private Rigidbody _rigidBody;
    private void Start()
    {
        var randomZRot = Random.Range(-10, 10);

        var rotation = transform.rotation;
        transform.Rotate(rotation.x, rotation.y, randomZRot);
            
        _rigidBody = GetComponent<Rigidbody>();

        float randomFloat = Random.Range(-200, 200);

        _rigidBody.AddForce(Vector3.up * 1200 * Time.deltaTime);
        _rigidBody.AddForce(Vector3.right * randomFloat * Time.deltaTime);

        transform.DOScale(0, 2f).OnComplete(() => { 
            Destroy(this.gameObject);   
        });
    }
}
