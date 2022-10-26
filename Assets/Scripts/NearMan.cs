using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearMan : MonoBehaviour
{

    public Transform target;
    
    void Start()
    {

    }

    void Update()
    {

        //取得距離
        float dist = Vector3.Distance(transform.position, target.position);
        Vector3 targetPos;

        if (dist < 8)
        {

            //距離靠近時
            targetPos = new Vector3(transform.position.x, 0, target.position.z);
        }
        else
        {

            //距離遠離後
            targetPos = new Vector3(transform.position.x, -2, target.position.z);
        }

        //漸漸改變位置
        transform.position = Vector3.Lerp(transform.position, targetPos, 0.05f);

    }
}
