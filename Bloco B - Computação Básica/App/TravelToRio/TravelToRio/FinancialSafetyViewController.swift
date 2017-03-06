//
//  FinancialSafetyViewController.swift
//  TravelToRio
//
//  Created by Raysa Dutra on 07/04/16.
//  Copyright © 2016 Raysa Dutra. All rights reserved.
//

import UIKit

class FinancialSafetyViewController: UIViewController {

    var financialArr: [String]?
    
    @IBOutlet weak var lbFinancialSafety: UITextView!
    
    override func viewDidLoad() {
        
        super.viewDidLoad()
        if let bundlePath = NSBundle.mainBundle().pathForResource("Safety", ofType: "plist")
        {
            
            if let dicSafety = NSDictionary(contentsOfFile: bundlePath)
            {
                financialArr = dicSafety["Financial"] as? [String]
            }
        }
        for i in financialArr!
        {
            lbFinancialSafety.text = lbFinancialSafety.text + "\n" + i + "\n"
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
