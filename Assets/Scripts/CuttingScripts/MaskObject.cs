using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskObject : MonoBehaviour
{
    public List<GameObject> objMasked;

    private LevelEndCheck _levelEndCheck;

    void Start()
    {
        objMasked[0].GetComponent<MeshRenderer>().material.renderQueue = 3002;

        _levelEndCheck = LevelEndCheck.Instance;    
    }   

    public void MaskTheObject()
    {        
        objMasked.RemoveAt(0);

        if (objMasked.Count == 0)
        {
            FinishLevel();
            return;
        }

        objMasked[0].GetComponent<MeshRenderer>().material.renderQueue = 3002;
    }

    private void FinishLevel()
    {
        _levelEndCheck.TriggerLevelEnd();
    }

    public void HideFirstLayer()
    {
        objMasked[0].gameObject.SetActive(false);
    }
}

