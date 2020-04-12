using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager worldManager;

    private void OnTriggerEnter(Collider other)
    {
        worldManager.CompletedLevel();
    }
}
