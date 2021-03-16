//
//  MapViewController.swift
//  TravelToRio
//
//  Created by Raysa Dutra on 02/04/16.
//  Copyright © 2016 Raysa Dutra. All rights reserved.

import UIKit
import MapKit
class MapViewController: UIViewController {
    
    var MapPlace : NSArray?
    
    @IBOutlet weak var mapView: MKMapView!
    @IBOutlet weak var lbAddress: UILabel!
    //    @IBOutlet weak var traceRouter: UIButton!
    var coordinatePlace:CLLocationCoordinate2D?
    
    override func viewDidLoad() {
        super.viewDidLoad()
        lbAddress.text = MapPlace?.firstObject!["Address"] as? String
        btActionGeocoder()
    }
    
    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }
    func btActionGeocoder()
    {
        let _ = CLGeocoder().geocodeAddressString(lbAddress.text!)
            {
                (placemarks, error) -> Void in
                if let placemark:CLPlacemark = placemarks?[0]
                {
                    let location = placemark.location
                    if let coords:CLLocationCoordinate2D = location?.coordinate
                    {
                        self.coordinatePlace = coords
                        print("Latitude = \(coords.latitude), Longitude = \(coords.longitude)")
                        let span = MKCoordinateSpan(latitudeDelta: 0.005, longitudeDelta: 0.005)
                        let region = MKCoordinateRegion(center: coords, span: span)
                        self.mapView.setRegion(region, animated: false)
                        let annotation = MKPointAnnotation()
                        annotation.coordinate = coords
                        annotation.title = self.MapPlace?.firstObject!["Address"] as? String
                        self.mapView.addAnnotation(annotation)
                    }
                }else {
                    
                    print("Gecode Fail. Error: " )
                    
                }
        }
        
    }
    
    @IBAction func TraceRouter(sender: AnyObject)
    {
        if self.coordinatePlace != nil
        {
            let launchOptions = [MKLaunchOptionsDirectionsModeKey : MKLaunchOptionsDirectionsModeWalking]
            let placemark = MKPlacemark(coordinate: self.coordinatePlace!, addressDictionary: nil)
            let mapItem = MKMapItem(placemark: placemark)
            mapItem.openInMapsWithLaunchOptions(launchOptions)
            
        }
        
    }
    
}
