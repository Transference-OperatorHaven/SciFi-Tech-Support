using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CustomerGenerator : MonoBehaviour
{

    struct TechAndFailures
    {
        public string techName;
        public string[] techIssues;
    }
    TechAndFailures[] customerTech = new TechAndFailures[4];

    [SerializeField]TextMeshProUGUI infoText, quotaText;
    [SerializeField] Slider slider;

    float angryPercent;
    string currentFault;
    int customerWave;
    int currentCustomerNumber, quotaTarget, quota;
    Coroutine currentCustomerCoroutine;
    bool customerComplaintResolved;

    int chosenTech, chosenTechIssue;

    private void Start()
    {
        customerTech[0].techName = "Hoover";
        customerTech[0].techIssues = new string[] 
        { "My hoover sucks things up its hose fine but when I turn it off all of the things I hoovered up spill back out.",
          "My hoover refuses to suck things up its hose",
          "My hoover refuses to turn on even after letting it charge overnight!",
          "My hoover keeps turning off and on and its super annoying!!!1!" 
        };

        customerTech[1].techName = "Coffee Maker";
        customerTech[1].techIssues = new string[] 
        { "My coffee no longer tastes good and isn't calibrated to my tastes as advertised!",
          "My coffee machine refuses to take drink requests which i hate!",
          "there's a flashing light ont he handlink of my coffee maker", 
          "I installed a general purpose drink upgrade to my coffee maker but it won't work!" 
        };

        customerTech[2].techName = "Phone";
        customerTech[2].techIssues = new string[] 
        { "My calls are no longer instant between galaxies and so no longer go through", 
          "Phone screen isn't turning on", 
          "I was on EUGENE-Loire-16 and took an intersectorial flight to AUGUST-Rilea-5 and when I landed my time was still set to Loire-16 help??", 
          "New updates for my apps and phone no longer install and say something about incompatibility." 
        };

        customerTech[3].techName = "Games Console";
        customerTech[3].techIssues = new string[] 
        { "A holoprojection rock broke underneath me with a loud warning sound when I stood on it.",
          "Holoprojection games take a full minute to load new areas now.",
          "My holoprojections are halfway in the bloody wall!!!!!", 
          "I brought Super Mario Kosmos but my console refuses to install it." 
        };

        WaveStart();
        GenerateCustomerComplaint();
    }

    private void Update()
    {
        slider.value = angryPercent;
        quotaText.text = "Quota: " + quota + "/" + quotaTarget;

        if(customerComplaintResolved)
        {
            StartCoroutine(Success());
        }
    }

    void WaveStart()
    {
        customerWave++;
        currentCustomerNumber = 0;
        quota = 0;
        quotaTarget = 5 + (customerWave-1) * 3; //5,8,11,14,etc
    }

    void GenerateCustomerComplaint()
    {
        currentCustomerNumber++;
        chosenTech = Random.Range(0, customerTech.Length);
        chosenTechIssue = Random.Range(0, customerTech[chosenTech].techIssues.Length);
        currentFault = customerTech[chosenTech].techIssues[chosenTechIssue];
        infoText.text = currentFault;
        currentCustomerCoroutine = StartCoroutine(angryTimer());
    }

    public void CheckIssue(int tech, int techIssue)
    {
        if (tech == chosenTech && techIssue == chosenTechIssue)
        {
            customerComplaintResolved = true;
        }
        else
        {
            Debug.Log("failed");
            //failure event
        }
    }

    IEnumerator Success()
    {
        StopCoroutine(currentCustomerCoroutine);
        customerComplaintResolved = false;
        infoText.text = "";
        quota++;
        yield return new WaitForSeconds(3);
        if (quota == quotaTarget)
        {
            WaveStart();
        }
        GenerateCustomerComplaint();
    }

    IEnumerator angryTimer()
    {

        int angerTime = Mathf.RoundToInt(10.0f + (3.6f * Mathf.Sqrt(30 / currentCustomerNumber)));
        float t = 0;
        while(t < angerTime)
        {
            angryPercent = t/angerTime;
            t += Time.deltaTime;
            yield return null;
        }
        if(!customerComplaintResolved )
        {
            //Trigger anger event
        }
    }
}

