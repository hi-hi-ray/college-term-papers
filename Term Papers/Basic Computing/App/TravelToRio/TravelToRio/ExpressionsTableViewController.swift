//
//  ExpressionsTableViewController.swift
//  TravelToRio
//
//  Created by Raysa Dutra on 05/04/16.
//  Copyright © 2016 Raysa Dutra. All rights reserved.
//

import UIKit
import AVFoundation

class ExpressionsTableViewController: UITableViewController {
    
    var audioplayer : AVAudioPlayer = AVAudioPlayer()
    
    
    
    @IBOutlet weak var lbQuestEN1: UILabel!
    @IBOutlet weak var lbQuestionPt1: UILabel!
    
    @IBOutlet weak var lbQuestEN2: UILabel!
    @IBOutlet weak var lbQuestionPt2: UILabel!
    
    @IBOutlet weak var lbQuestEN3: UILabel!
    @IBOutlet weak var lbQuestionPt3: UILabel!
    
    @IBOutlet weak var lbQuestEN4: UILabel!
    @IBOutlet weak var lbQuestionPt4: UILabel!
    
    @IBOutlet weak var lbQuestEN5: UILabel!
    @IBOutlet weak var lbQuestionPt5: UILabel!
    
    var audioPlayer = AVAudioPlayer()
    var audioPlayer2 = AVAudioPlayer()
    var audioPlayer3 = AVAudioPlayer()
    var audioPlayer4 = AVAudioPlayer()
    var audioPlayer5 = AVAudioPlayer()
    
    @IBAction func PlayAudio1(sender: AnyObject) {
        
        audioplayer.play()
    }
    
    @IBAction func PlayAudio2(sender: AnyObject) {
        audioPlayer2.play()
    }
    
    @IBAction func PlayAudio3(sender: AnyObject) {
        audioPlayer3.play()
    }
    
    @IBAction func PlayAudio4(sender: AnyObject) {
        audioPlayer4.play()
    }
    
    //Botão que executa o áudio
    @IBAction func PlayAudio5(sender: AnyObject) {
        audioPlayer5.play()
    }
    
        var expressionArray: [[String:String]]?
    
        override func viewDidLoad() {
            
            //Nessa parte é pego o Path do áudio e atribui a uma Variavel constante
            let audioPath1 = NSBundle.mainBundle().pathForResource("audio1Portugues", ofType: "wav")
            //Nessa parte é criado um Error para caso não seja encontrado algum áudio
            var _:NSError? = nil
            do {
                //Nessa parte atribui ao player a preprodução do áudio
                audioplayer = try AVAudioPlayer(contentsOfURL: NSURL(fileURLWithPath: audioPath1!))
            }//O catch busca o erro, e caso houver algum, ele imprime uma menssagem de erro
            catch {
                print("Something bad happened. Try catching specific errors to narrow things down")
            }
            
            let audioPath2 = NSBundle.mainBundle().pathForResource("audio2Perdido", ofType: "wav")
            var _:NSError? = nil
            do {
                audioPlayer2 = try AVAudioPlayer(contentsOfURL: NSURL(fileURLWithPath: audioPath2!))
            }
            catch {
                print("Something bad happened. Try catching specific errors to narrow things down")
            }
            let audioPath3 = NSBundle.mainBundle().pathForResource("audio3Roubado", ofType: "wav")
            var _:NSError? = nil
            do {
                audioPlayer3 = try AVAudioPlayer(contentsOfURL: NSURL(fileURLWithPath: audioPath3!))
            }
            catch {
                print("Something bad happened. Try catching specific errors to narrow things down")
            }
            let audioPath4 = NSBundle.mainBundle().pathForResource("audio4Delegacia", ofType: "wav")
            var _:NSError? = nil
            do {
                audioPlayer4 = try AVAudioPlayer(contentsOfURL: NSURL(fileURLWithPath: audioPath4!))
            }
            catch {
                print("Something bad happened. Try catching specific errors to narrow things down")
            }
            let audioPath5 = NSBundle.mainBundle().pathForResource("audio5Taxi", ofType: "wav")
            var _:NSError? = nil
            do {
                audioPlayer5 = try AVAudioPlayer(contentsOfURL: NSURL(fileURLWithPath: audioPath5!))
            }
            catch {
                print("Something bad happened. Try catching specific errors to narrow things down")
            }

            lbQuestEN1.text = "Hello! I don't speak Portuguese. Do you Speak English?"
            lbQuestionPt1.text = "Olá! Eu não falo português. Você fala inglês?"
            lbQuestEN2.text = "I'm lost. Can you Help Me?"
            lbQuestionPt2.text = "Eu estou perdido. Você pode me ajudar?"
            lbQuestEN3.text = "I was robbed!"
            lbQuestionPt3.text = "Eu fui roubado!"
            lbQuestEN4.text = "Where is the police station?"
            lbQuestionPt4.text = "Onde fica a Delegacia?"
            lbQuestEN5.text = "Is there any stand taxi here?"
            lbQuestionPt5.text = "Há algum ponto de táxi por aqui?"
            
        // Uncomment the following line to preserve selection between presentations
        // self.clearsSelectionOnViewWillAppear = false

        // Uncomment the following line to display an Edit button in the navigation bar for this view controller.
        // self.navigationItem.rightBarButtonItem = self.editButtonItem()
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }

    // MARK: - Table view data souoverride rce

    override func numberOfSectionsInTableView(tableView: UITableView) -> Int {
        // #warning Incomplete implementation, return the number of sections
        return 1
    }

    override func tableView(tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        // #warning Incomplete implementation, return the number of rows
        return 5
    }

}
