using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectorOn : MonoBehaviour
{
    public GameObject projector;

    public void OnProjector(){
        projector.SetActive(true);
    }
}
