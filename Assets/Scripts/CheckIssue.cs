using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CheckIssue : MonoBehaviour
{
    int tech, techIssue;
    [SerializeField]TextMeshProUGUI text;
    string issueText;
    [SerializeField] GameObject customerManager;

    public void SetTech(int tech)
    { this.tech = tech; }

    public void SetTechIssue(int techIssue)
    {
        this.techIssue = techIssue;
    }

    public void SetIssueText(string techString)
    {
        this.issueText = techString;
        text.text = issueText;
    }

    public void Compare()
    {
        customerManager.GetComponent<CustomerGenerator>().CheckIssue(tech, techIssue);
    }
}
