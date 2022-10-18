using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleVisualRaycaster : MonoBehaviour
{
    public string RaycastLayerName = "HuSISWalls";
    public GameObject Visual;
    public Transform RaySourceTransform;
    public Transform VisualLookAtTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        if (VisualLookAtTransform == null)
        {
            VisualLookAtTransform = RaySourceTransform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hitInfo;
        int layer = 1 << LayerMask.NameToLayer(RaycastLayerName);
        if (Physics.Raycast(GetRay(), out hitInfo, Mathf.Infinity, layer))
        {
            Visual.transform.position = hitInfo.point;
            Visual.transform.LookAt(VisualLookAtTransform);
        }    
    }

    public Ray GetRay()
    {
        return new Ray(RaySourceTransform.position, RaySourceTransform.forward);
    }
}
