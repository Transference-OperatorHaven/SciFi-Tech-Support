using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerGenerator : TechAndFailures
{
    TechAndFailures[] customerTech = new TechAndFailures[4];
    string currentFault;

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
    }

    void GenerateCustomerComplaint()
    {
        currentFault = customerTech[Random.Range(0, customerTech.Length)].techIssues[Random.Range(0, techIssues.Length)];
    }

}
