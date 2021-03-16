//
//  PlaceTableViewController.swift
//  TravelToRio
//
//  Created by Raysa Dutra on 01/04/16.
//  Copyright © 2016 Raysa Dutra. All rights reserved.
//

import UIKit

class PlaceTableViewController: UITableViewController {
    var Ctype : String?
    var Stype : NSArray?
    var AllPlace : NSArray?
    var ChoosedPlace : String?
    var MenuOp : [String]?
    
    override func viewDidLoad() {
        super.viewDidLoad()
                Stype = Stype?.filteredArrayUsingPredicate(NSPredicate(format: "Type = %@", Ctype!))
//       print(Stype!)
        
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }

    // MARK: - Table view data source

    override func numberOfSectionsInTableView(tableView: UITableView) -> Int {
        // #warning Incomplete implementation, return the number of sections
        return 1
    }
//
    override func tableView(tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        // #warning Incomplete implementation, return the number of rows
        return (Stype!.count)
//        return 1
    }

    
    override func tableView(tableView: UITableView, cellForRowAtIndexPath indexPath: NSIndexPath) -> UITableViewCell {
        let cell:PlaceTableViewCell = tableView.dequeueReusableCellWithIdentifier("PlaceCell", forIndexPath: indexPath) as! PlaceTableViewCell
        
        if let local:NSDictionary = Stype![indexPath.row] as? NSDictionary
        {
            cell.lbplace.text = local["Name"] as? String
        }
        return cell
    }
    override func prepareForSegue(segue: UIStoryboardSegue, sender: AnyObject?) {
        let index = self.tableView.indexPathForSelectedRow
        let variavel: AboutPlaceViewController = segue.destinationViewController as! AboutPlaceViewController
        ChoosedPlace = Stype![index!.row]["Name"] as? String
        variavel.AllPlace = Stype?.filteredArrayUsingPredicate(NSPredicate(format: "Name = %@", ChoosedPlace!))
        variavel.ChoosedPlace = ChoosedPlace
    }
    
}
