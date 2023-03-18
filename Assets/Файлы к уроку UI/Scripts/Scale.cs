using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    private BoxCollider _boxCollider;

    private void Start()
    {
        _boxCollider = GetComponent<BoxCollider>();
    }

    public void SetScale(float value)
    {
        transform.localScale = Vector3.one * value;
        _boxCollider.size = Vector3.one * value;
    }
}
