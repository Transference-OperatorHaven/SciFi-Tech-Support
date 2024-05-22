using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIssue : MonoBehaviour
{
    public int tech, techIssue;
    [SerializeField] GameObject customerManager;

    public void SetTech(int tech)
    { this.tech = tech; }

    public void SetTechIssue(int techIssue)
    {
        this.techIssue = techIssue;
    }

    public void Compare()
    {
        customerManager.GetComponent<CustomerGenerator>().CheckIssue(tech, techIssue);
    }
}
