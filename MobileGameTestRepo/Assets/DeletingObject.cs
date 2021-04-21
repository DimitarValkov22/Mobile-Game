using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletingObject : MonoBehaviour
{
    public GameObject theCube;
    void Start()
    {
        theCube.SetActive(false);
    }

}
