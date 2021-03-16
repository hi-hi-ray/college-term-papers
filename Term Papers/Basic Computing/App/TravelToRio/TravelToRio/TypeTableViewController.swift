//
//  TypeTableViewController.swift
//  TravelToRio
//
//  Created by Raysa Dutra on 01/04/16.
//  Copyright © 2016 Raysa Dutra. All rights reserved.
//

import UIKit

class TypeTableViewController: UITableViewController {

    var AType: [String] = []
    var IconType: [String] = []
    var Ctype : String?
    var Stype : NSArray?
    var Aplace: [[String:String]]?
    @IBOutlet var typeTable: UITableView!
    var OpChoosed : String?
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        
        if let bundlePath = NSBundle.mainBundle().pathForResource("Places", ofType: "plist")
        {
            
            if let dicionario = NSDictionary(contentsOfFile: bundlePath)
            {
                Aplace = dicionario["Places"] as? [[String:String]]
                typeTable.reloadData()
            }
        }
        for index in 0..<Aplace!.count
        {
            if(!AType.contains(Aplace![index]["Type"]!))
            {
                AType.append(Aplace![index]["Type"]!)
            }
        }
        AType.removeLast()
        AType.sortInPlace{$0 < $1}
        print(AType)
    }
    
    override func didReceiveMemoryWarning()
    {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }
    
    // MARK: - Table view data source
    
    override func tableView(tableView: UITableView, didSelectRowAtIndexPath indexPath: NSIndexPath)
    {
        
        Ctype = AType[indexPath.row]
        print(Ctype)
    }
    
    override func numberOfSectionsInTableView(tableView: UITableView) -> Int
    {
        // #warning Incomplete implementation, return the number of sections
        return 1
    }
    
    override func tableView(tableView: UITableView, numberOfRowsInSection section: Int) -> Int
    {
        return (AType.count)
    }
    
    override func tableView(tableView:UITableView, cellForRowAtIndexPath indexPath: NSIndexPath) -> UITableViewCell
    {
        
        let cell = tableView.dequeueReusableCellWithIdentifier("TypeCell", forIndexPath: indexPath)
        
        if let local:String = AType[indexPath.row]
        {
            cell.textLabel?.text = local
        }
        return cell
    }
    
    override func prepareForSegue(segue: UIStoryboardSegue, sender: AnyObject?) {
        let index = self.tableView.indexPathForSelectedRow
        let variavel: PlaceTableViewController = segue.destinationViewController as! PlaceTableViewController
        variavel.Ctype = AType[index!.row]
        variavel.Stype = Aplace
    }
    
}
