//
//  AboutPlaceViewController.swift
//  TravelToRio
//
//  Created by Raysa Dutra on 02/04/16.
//  Copyright © 2016 Raysa Dutra. All rights reserved.
//

import UIKit

class AboutPlaceViewController: UIViewController {

    @IBOutlet var lbName: UILabel!
    @IBOutlet var PlaceImage: UIImageView!
    @IBOutlet var iconPlace: UIImageView!
    @IBOutlet var lbSafety: UITextView!
    @IBOutlet var lbAboutPlace: UITextView!
    
    var AllPlace : NSArray?
    var ChoosedPlace : String?
    var MapPlace : NSArray?
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        print(AllPlace)
        
        for index in AllPlace!
        {

            lbName.text = index["Name"] as? String
            lbAboutPlace.text = index["Description"] as? String
            lbSafety.text = index["Safety"] as? String
            iconPlace.image = UIImage(named: index["IconType"] as! String)
            PlaceImage.image = UIImage(named: index["Image"] as! String)
            
        }
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }
    

    
//     MARK: - Navigation
       override func prepareForSegue(segue: UIStoryboardSegue, sender: AnyObject?) {
    let variavel: MapViewController = segue.destinationViewController as! MapViewController
    variavel.MapPlace = AllPlace
        AllPlace?.firstObject!["Address"] as? String
        AllPlace?.firstObject!["Coordinates"] as? String
}



}
