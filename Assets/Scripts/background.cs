using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    private MeshRenderer MyMesh;

    private void Awake()
    {
        MyMesh = GetComponent<MeshRenderer>();
    }
}
