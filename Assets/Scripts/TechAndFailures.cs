using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TechAndFailures : MonoBehaviour
{
    public string techName;
    public string[] techIssues = { };

    public string generateIssue()
    {
        return techIssues[Random.Range(0, 3)];
    }
}

