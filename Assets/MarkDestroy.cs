using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkDestroy : MonoBehaviour {

    public float DeletesPoint = 0;
    // Update is called once per frame
    void Update()
    {
        DeletesPoint += Time.deltaTime;
        if (DeletesPoint > 1)
            Destroy(gameObject);
    }
}
