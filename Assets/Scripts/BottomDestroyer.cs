using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomDestroyer : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        var objectController = other.GetComponent<ObjectController>();
        if (other.transform.position.y < transform.position.y && objectController != null)
        {
            GameManager.Instance.PointsManager.AteObject(objectController.Good);

            Destroy(objectController.gameObject);
        }
    }
}
