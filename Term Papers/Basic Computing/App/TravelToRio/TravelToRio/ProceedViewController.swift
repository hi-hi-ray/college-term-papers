//
//  ProceedViewController.swift
//  TravelToRio
//
//  Created by Raysa Dutra on 07/04/16.
//  Copyright © 2016 Raysa Dutra. All rights reserved.
//

import UIKit

class ProceedViewController: UIViewController {

    var incidentArr: [String]?

    @IBOutlet weak var incident: UITextView!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        if let bundlePath = NSBundle.mainBundle().pathForResource("Proceeds", ofType: "plist")
        {
            
            if let dicSafety = NSDictionary(contentsOfFile: bundlePath)
            {
                incidentArr = dicSafety["Incidents"] as? [String]
            }
        }
        for i in incidentArr!
        {
            incident.text = incident.text + "\n" + i + "\n"
        }
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }
    

    /*
    // MARK: - Navigation

    // In a storyboard-based application, you will often want to do a little preparation before navigation
    override func prepareForSegue(segue: UIStoryboardSegue, sender: AnyObject?) {
        // Get the new view controller using segue.destinationViewController.
        // Pass the selected object to the new view controller.
    }
    */

}
