using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectorOn : MonoBehaviour
{
    public GameObject projector;

    public void OperateProjector(){
        projector.SetActive(true);
    }
}
