//
//  NumbersViewController.swift
//  TravelToRio
//
//  Created by Raysa Dutra on 07/04/16.
//  Copyright © 2016 Raysa Dutra. All rights reserved.
//

import UIKit

class NumbersViewController: UIViewController {

    @IBOutlet weak var Emergency: UITextView!
    @IBOutlet weak var Useful: UITextView!
    var numb1Arr: [String]?
    var numb2Arr: [String]?
    
    override func viewDidLoad() {
        super.viewDidLoad()
        if let bundlePath = NSBundle.mainBundle().pathForResource("Proceeds", ofType: "plist")
        {
            
            if let dicSafety = NSDictionary(contentsOfFile: bundlePath)
            {
                numb1Arr = dicSafety["UsefulNumbers"] as? [String]
            }
        }
        for i in numb1Arr!
        {
            Useful.text = Useful.text + "\n" + i + "\n"
        }
        
        if let bundlePath = NSBundle.mainBundle().pathForResource("Proceeds", ofType: "plist")
        {
            
            if let dicSafety = NSDictionary(contentsOfFile: bundlePath)
            {
                numb2Arr = dicSafety["EmergencyNumbers"] as? [String]
            }
        }
        for i in numb2Arr!
        {
            Emergency.text = Emergency.text + "\n" + i + "\n"
        }

        // Do any additional setup after loading the view.
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
