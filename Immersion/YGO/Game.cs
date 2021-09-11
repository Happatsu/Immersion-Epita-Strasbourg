using System;
using System.Collections.Generic;

namespace YGO
{
    public class Game
    {
        public Duelist Kaiba;
        public Duelist Player;
        
        public Game(string playername)
        {
            Kaiba = new Duelist("Kaiba");
            Player = new Duelist(playername);
        }

        
        public void Play()
        {
            bool winner = false;
            bool stop = false;

            while (!winner && !stop)
            {
                if (Kaiba.hp < 1)
                {
                    Console.WriteLine("{0} wins ! gg :)", Player.name);
                    winner = true;
                }
                else if (Player.hp < 1)
                {
                    Console.WriteLine("Kaiba wins ! Too bad");
                    winner = true;
                }

                else
                {
                    Console.WriteLine("Press any key to continue. Press q to quit");
                    string answer = Console.ReadLine();

                    if (answer == "q")
                        stop = true;

                    else
                    {
                        Kaiba_Round();
                        Player_Round();
                    }
                    
                }
            }

        }

        
        public void Player_Round()
        {
            Console.Clear();
            Board();
            bool WrongAnswer = true;
            
            while (WrongAnswer)
            {
                Console.WriteLine("Draw Phase");
                Console.WriteLine("Press e to pull a card");
                string answer = Console.ReadLine();

                if (answer == "e")
                    WrongAnswer = false;
            }

            Card NewCard = PullCard(Player);
            
            //dessiner la carte sur la console genre dragon blanc aux yeux bleu
            NewCard.Print();
            WrongAnswer = true;
            
            while (WrongAnswer)
            {
                Console.WriteLine("Standby Phase");
                
            }

        }

        public Card PullCard(Duelist duelist)
        {
            int lenght = duelist.deck.Count;
            int index = new Random().Next(lenght);
            Card card = duelist.deck[index];
            
            duelist.hand.Add(card);
            duelist.deck.RemoveAt(index);

            return card;
        }
        
        
        public void Kaiba_Round()
        {
              Console.Clear();       
        }
        
        
        public void Board()
        {
            Console.WriteLine(
                "MWNNNNNNNNNNNNNNNNNNWMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWMMMMM\nW0xxdddoodoooooodddkXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXxlllllclcclcclllloKMMMM\nWOl:;:::;;,,,',,;;;dXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMK:........    ....,OMMMM\nWKo,,;;;,,,,,,,,,';dXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMK:.  ...          ,OMMMM\nMXd,,,,,,,'',;,,,,;dXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMK:.   ..         .,OMMMM\n MKo;,,,;,....',,,,:xNMMMMMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWNWWWWWWWWWWWWWWWWWMMMMK:.              .;0MMMM\n W0l;'','.......'',:kWMMMMWOdddoolllllllllook0kddooollllllllloodkkdodolllllllllloooOKkdddollllllllloooOXOddooolllllllllood0WMMMK:.        ..    .:KWMMM\n W0d:,''.........',:OWMMMMWk;,;;;,,''...''''oOd:,;;;,,''...'''':xo;,;;;,''.....''',xKo;,;;;,''....''',dXk;,;;;;,''...'''':OWMMMK:..              'OMMMM\n W0xc,,,'........',:kWMMMMWk;.'','.''....'.'o0d;..',''''....'.':dl'.',,''''....''.,xKo,.',,''''...''.'dXk;..',''''....'.':OWMMMK:..          ..  'OMMMM\n WOlc,''........''';kWMMMMNk;..'''....'...''oOd;..'''....'....':dl'.''''....''...',xKo,..'''....'...',dXk;..'''....'....':OWMMMK:..             .,OMMMM\n W0o:,''''......''':OWMMMMWk;'............',o0d;'.............':xo,...............,xXd'.............',dXk;'............',cOWMMMK:..             .,OMMMM\n W0d:,,,,,,,,''',:;:OWMMMMNk:'...........'.,d0d:'..............lOo'...............,kXd,............'';xXk:'...........'.,cOWMMMK:...          ...,OMMMM\n WOl,'''''''',:cllclOWMMMMNk:''............,d0d:,'.............oKo................,OXd,..............,xXk:,'............,c0WMMMKc.         ......;OMMMM\n WOl:;::::c::loooood0WMMMMWk:,''.........'.'o0d:,''...........'cxl'...............'xXd;'.............,dXk:,''.........'.':OWMMMKc'.........',,',,:0MMMM\n WK0KkdxxxxxxxxxxxxxOXNNWMWk:,'.........''.'o0d:;'.........''.'cxo;,...........''.,xKo;,..........''.,xXx:;'.........''.'c0WMWNKOkkkkkkkkkkkkkkk0KNMMMM\n MMMNx:;;:;;;;,,,,,,;:ckNMNx;,'...........''d0d;,'...........''cxl;,............'',kKo;,'..........'',xXx:,'...........''c0WMXdccc:::;;;;;;::::dXMMMMMM\n MMMXd,'',,'''.....''',xNMNx;,'.........';;,d0d;,'..'......';;,lxl;,'..'.......,;;;kKo;,'..'......,;,;xXk;,'..'......';;,l0WMKc''','..........'oXMMMMMM\n MMMXd,..'''..'''....';xNMNx;.....'..',::c:;d0d;.....'...,::c::lxo'.....'..',;::c::kKo'.....'..';::c::xXk;.....'...,::c::l0WMKc...............'oXMMMMMM\n MMMXd,.''...........';xNMNx:;;:;;::::clllllk0dc;;;:;::;:clllcloxo:;;;;::;;:cccllllkKd:;;::;::::clllllkXkc;;::::;;:clllllo0WMKc...............'oXMMMMMM\n MMMXd;..............';xNMWX0KKKKKKKKKKKKKKKXNKKK0KKKKKKKK0KK00KKK0000KKK00KKK0KKKKXNX0KKKKKKKKKKKKKKKXWXKK0KKKK00KKKKKKKKNMMKc...............'dWMMMMMM\n MMMNd'..............';xNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM0c................dWMMMMMM\n MMMNo...............';xNMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM0c'..............'lXMMMMMM\n MMMNo'.............'';xNMNXKXXXXXXXXXXXXXXXXNXKXXXXXXXXXXXXXXXXKKXXXXXXXXXXXXXXXXXNNXKXXXXXXXXXXXXXXXXNXXXXXXXXXXXXXXXXXXWMMKc'..............'oXMMMMMM\n MMMXd,''..........''';xNMKollllc:c::::::ccclkxllllc:c:::::ccccccllllcccc::cc:ccccckKdllllccc::c::ccccdOxllllcccc:c::ccccoKMMKc'..............'oXMMMMMM\n MMMXd;''..........''';kNMKo;,;:;,,'''..',',ckx:,;:;;,''''.''',:cc;,;:;,,''''.'',',xKo;,;:;,,'''.'',',oOd:,;:;,,'''.'''''lKMMKc'..............,oXMMMMMM\n MMMXd;''.......'',,,,:kNMKo;'',,''''''.''''ckx;'',,,'''''.'''':cc,'',,'''''''.''',xKo,'',,''''''.''',okd;''',,'''''.''''lKMMKc'...........',',oXMMMMMM\n MMMXd;..''.''.';cccc:ckWMKo;.''''....''..',ckx;'''''....''..',:cc,.''''...'''..'',xKo,'''''....'..'',okd;'''''....''..',lKMMKc.........';;;;;;dXMMMMMM\n MMMXxlcccccllcclloooooOWMKo;''...........',ckx:,'...........',:cc;''............';xKo,''...........';okd:,'...........',lKMMXkolccccccllloooookXMMMMMM\n MMMWNNNNNNNNNNNNNNNNNNNMMKo:'..........''',lOx:'...........''':oc,'''..........'';kKo,''.........''';okd:,...........'',lKMMMWWWNNNNNNNNNNNNNNNWMMMMMM\n W0oololllllllllllllxXMMMMKo:,''.........'',lOx:'............'.:Oo.''............',kXl'''..........'';okd:,''.........'',oKMMMMMWXXXXXXXXXXXXXXXNNNWMMM\n Wx'.......      ...cKMMMMKoc,''........''',ckxc,............'.:Od'''............',kXl'''.........''',oOdc;''.........'',lKMMMMMKocccc:::::::::cllxXMMM\n Wx'   ...         .cKMMMMKo:;'.........''',lOxc;'...........'':dl,''...........'';kKo,,'.........''',oOd:;'.........''',lKMMMMMKc',,;,''......'.,dXMMM\n Wx'.   .          .:KMMMMKo:;'.........''',lOx:;''.........'',coc;,'..........''';kKo;,'.........''',oOd:;'..........'',lXMMMMMKc..'''..........,dNMMM\n WO,..            ..cKMMMMKo:,'''''''''',:;;lOx:,,''''.'''',:;;clc;,'''''.''''';:;:kKo;,'''''.'''',:;;dOd:,,''''.'''',:;;oXMMMMMKc..'''.....'..'',dNMMM\n MK;            .  .cXMMMMKd;.''''''.':cclccoOk;..'''''.';cclccllc,.''''''.,;:cclcckKd,.''.'''.,:cllccdOd;'.''.''.';cclccdXMMMMMKc''',,''''',,',,,oXMMM\n Wk.               .cKMMMMKxlcccccccclooddddxOklccccclcclooddoddoolccccclllloodddddOKxlcccccllcloddoddxOxlcccccccclooooddxXMMMMMKl'''',,,,,,,,,,,'lXMMM\n Wx.              ..cKMMMMWNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNXXNNNNNNNNNNNNNNNNNNWNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNXNNNNWMMMMMKl'''''..''.''''',oXMMM\n Wx'.              .cXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMKl,'.............,dNMMM\n Wk'               .cXMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMKc,'''...........;kNMMM\n Wx..            ...cKMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMKc,,,''......'''';OWMMM\n Wx'.        .......cKMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMKc',,,,,,,,,,,,,';kWMMM\n Wx,..........''''''lKMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMKc.',,''''',,;,;;:kWMMM\n WKkkxxxkxxxkkkxxkkkONMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMXxlllolllllooddddxONMMM\n MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWWWWWWWWWWWWWWWWWWWMMMM\n MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM");
            
        }
    }
}