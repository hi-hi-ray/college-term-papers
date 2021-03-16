//
//  BeachSafetyViewController.swift
//  TravelToRio
//
//  Created by Raysa Dutra on 07/04/16.
//  Copyright © 2016 Raysa Dutra. All rights reserved.
//

import UIKit

class BeachSafetyViewController: UIViewController {
    
    var beachArr: [String]?
    
    @IBOutlet weak var lbBeachSafety: UITextView!
    
    override func viewDidLoad() {
        
        super.viewDidLoad()
        if let bundlePath = NSBundle.mainBundle().pathForResource("Safety", ofType: "plist")
        {
            
            if let dicSafety = NSDictionary(contentsOfFile: bundlePath)
            {
                beachArr = dicSafety["Beach"] as? [String]
            }
        }
        for i in beachArr!
        {
            lbBeachSafety.text = lbBeachSafety.text + "\n" + i + "\n"
        }
        
        // Uncomment the following line to preserve selection between presentations
        // self.clearsSelectionOnViewWillAppear = false
        
        // Uncomment the following line to display an Edit button in the navigation bar for this view controller.
        // self.navigationItem.rightBarButtonItem = self.editButtonItem()
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
