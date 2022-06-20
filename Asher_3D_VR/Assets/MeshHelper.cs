using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshHelper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = gameObject.GetComponent<MeshFilter>().mesh;
        mesh.Optimize();
    }

}
