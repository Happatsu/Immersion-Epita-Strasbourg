using System;

namespace YGO
{
    public class Card
    {
        public TYPE type;
        public string name;

        public enum TYPE
        {
            MONSTER,
            TRAP,
            MAGIC
        }


        public Card(string _name, TYPE _type)
        {
            name = _name;
            type = _type;
        }
        
        public void Print()
        {
            switch (name)
            {
                case "Blue Dragon":
                    BlueDragon();
                    break;
                
            }
        }

        public void BlueDragon()
        {
            Console.WriteLine("cllllllllllllllcccllllllolllllllllllllllllllloloollollloooooollooooollllllllloooloolollllllllllllolllllllccllllllllllllllllllllllllllccccclllllllllll;");
            Console.WriteLine("ccc:::::::::::::::looooc:::::::::::::::::cldddddddddocccccccc::::::::::::::::::cldddlc::::::::::::::::::::::::::::::::::::::::::;;;coc;:::::::::::::,'");
            Console.WriteLine("cc,.............;okOxl;..................;x00000OOOkc,..........................':dOkl:;;'...','................................. .oK: ....  .......''");
            Console.WriteLine("cc,.          .cO0xc'..................'cx0kddkO00OOxdolc;'........................,cllloddodoololc;............. ....            .OWx.    .....   .''");
            Console.WriteLine("cc,.         .:O0x,...................:x0kl,..,codkxdoodxxdodxkkkkkdc....................',;'....,:loo;..........  ..             :KKO;   ....     .''");
            Console.WriteLine("cc,.         .ck0x:,..................cO0x;......';loxOKNWMWWWNKOOko;...............................;xdlc:;'...                  .kKlxl  ......... .''");
            Console.WriteLine("cc,.          .,:lddxdoc,..............;okOxc..:dOXWWWWWNKXWKxodkO00ko:,....................   ....,;cdxddxdlclc;...             cXO,ok. ..    ....',,");
            Console.WriteLine("cc,.              ..'ck0x;...............;ldod0NWWWMWKxllkOo'.':ok0000Oxc'..............',;clodkO0KXXXXXKKOkxdl:;ld;...     ... .OWx.cO,...      ..',,");
            Console.WriteLine("cc,.                ..:xOxc;'............:x0NWWWWN0o;..c0k,......;ok0000Oo,'....';cloxk0KNWWWWWNNX0Okkxolc;,...,:lo,............lNNc ;O:        ...',,");
            Console.WriteLine("cc,.                ....;coddddol;..;;,ckNWWWWWKd;.   :XO'........':xOkdolccloxOKNWWWWWWWNNNXKKOkdolc:;,',cooodxkdollc:'....   .OMO' ,Ol  ..........,,");
            Console.WriteLine("cc,.            .............,lO0Oo;cd0NWWWWNkc.     .kNl...........;odxk0NWWWWWWWWWNNNXXK0Okxdolc:;,,''cOXNWXKKKOdol:;...    .lNNc  'kl  ...   ....''");
            Console.WriteLine("cc;.... ..        .........';ok0Oxdd0WWWWN0d;....... ,0X:......,:cdOKNWWWWWWWWNNNNXXKK0Okkxdolcc;,,''',lkOOkOxddl;,',,'...    ,0Wk.  .kl     ..  ...''");
            Console.WriteLine("cl,.    ...       ........,lOOxdoONWWWWW0c.........  '0Xc..;lx0XWWWWWWWWWNNNNXXK00Okkxddollc::;,',,'':llcllcllokkxdoddooddl,.'OWK;   .ko.......  ..'''");
            Console.WriteLine("cl,.     ................,lOk::xXWWWWW0l'.........   .:dod0NWWWWWWWWWWNNXXKK00Okkxddoollcc:;,'',,'';cc:::;;:clclolc::c:::;'.,o0Wx.   .ll....     ..'''");
            Console.WriteLine("cl,.           ..........:kxloKWWWWWKo'.........   .'cxKWWWWWWWWWWWNNXK0Okkxxxddoollccc:;,''''''';lc::;;;:::::;:lodoc:::;'.,oxK0,..'..cl............''");
            Console.WriteLine("ll;.            .......,cdooOWWWWWNx,.........  .'lOXWWWWWMWWWWWNNXK0Okxdooollllc::;;,,'...',,;:::::;,;;::;,:::;:oxdlcll:''llcxdol:'..do......... ..''");
            Console.WriteLine("ll,.               ..'lkdlkNWWWWWNd'........  .lkXWWWWWWWWWWWNNXKOkxddollcc::;;;,''.'',,,,,,;;;;,,,:;,:;,;:;;::,';:'...  .:xxkkd:.   .do...       ..''");
            Console.WriteLine("cl,.              ..,dOoc0WWWWWWNd'.........:xKWWWWMWWWWWWNNXKOkxdollc:::;,,''',;;;;;,,,,,,;;::cc;,;;,;;,,;'.''...;;',:ldO0kxx;.     .dc...  . .  ..''");
            Console.WriteLine("cc,.            .'codocdXWWWWWWKl........,o0WWWWWWWWWWWWNXK0kxollc:;;;,'',;;;;;;:ccccclllllllllc:,',;,,,'.....,;:cdk0KNKxc,c00,      .xc............''");
            Console.WriteLine("cc,.         ..,lxo;.'xNWWWWWWO;.......;xXWWWMWWXOxk000OOkxdlc:::;'''',;;,;::::cloodxxolccc:c:::;,,,''',;:lodkKNXK0OOOoc,.cXNo.      .d: ...........''");
            Console.WriteLine("cc,..'.......';okl. ,OWWWWWWXo'......;xXWWWWWWKko:clooldxxdolc:'..'''',::coddxoccccoxkkkxdoooooddxxxkO0KXWWWX0kkkxxkxcld;.xWk.       .o; ...........''");
            Console.WriteLine("cc,..:' ......;kx' ,0WWWWWW0:......;xXWWWWWWXOl;'.......,:cloc,;;,,,;ccllloddxxkOK0OkkOOkO00KXNWWWWWMWWX0OxddodkkkOd,lXNKxdx;        ,x;...........',,");
            Console.WriteLine("cc;'''.      .cOo.,0WWWWWNx'.....:xXWWWWWWWNkc,;c;'..''..:;...;clccccc::ox0XNX0OkkOOOKNWMWWWWWWWWNKOkkkxddxkkkkkkkkl,:odxxd:....     ck'.....'.....',,");
            Console.WriteLine("cc;..       .;xx;;0WWWWWXl.....;kNWWWWWWNNNNx.,xdlc'';,..;,':okkxxl::lx0KOxxkkO0KNWWWWWWWWWWWX0kxdoodxkkkkxxxxdodddddxxdddxxkkkdolc,.:o............',,");
            Console.WriteLine("cc,.    ..,:llc,;OWWWWWKc....,xXWWWWWNNXXXX0:..,,,..,;;';clokX0dlclcc0Kkxk0XNWWWWWMWWWWWW0xxkxooxxxddddxOOkkkkkkOOkxxkxxxxxxkkdc,'...dl.............''");
            Console.WriteLine("cc,. ..:clcc:,':OWWWWWKc...'lKWWWWWNNKO000Ko..',;,,;:loodkkOOxocldolxOxx0NWWWWWWWWMMWWW0c,:ldxkxkxxkOOKXNXOddxxxc;;;:ccloxk0KXKl. . ,k:.............''");
            Console.WriteLine("cc,..,do,. .:''kWWWWW0;...;kNWWXKXXOdldOOxoc::ldxdlclooodxxl;;cldodO0XWXxxXWWWWWWWWWWWW0xO00KXNNNWWWNNNXXKkxxol;..',:cloxk0KNNWK: . ck'.............''");
            Console.WriteLine("cl,.,xo.  . .'xNWWWWO;..'lKWXOOkxxxdoxdooc:ldxOkxxdoloxOOOkkxooxk0NWN0kxl:dKXNNNNNNNNNNWWNKOO00OOOOOOOkkkkxo,......',;clodk0KXNWk. .dd..............''");
            Console.WriteLine("ll;.ox,.... .lNWWWWO;..'dNWW0ddocclloc;:lxOXXOxdldkO0OOOkolloxOXNXOdoc::,,ldolc:cccccclodxkxddolcccllcllccc:;,''.....';:lodk0KXNX: 'xc..............''");
            Console.WriteLine("cl;;xl......;KWWWW0;..'xNWWKd:;,,ckkocclONKdllxxxkko:'.;::lkK0xol;;c;...,::::;...........''..,;;;;;,,,,,,,,,,,;;;;;,,'''',ldk0KNXc :d'..........''.'''");
            Console.WriteLine("cl;.lx:.....xWWWW0:..,kWWWKololx0KOooc:kNXxx0Oxo;,ld;..'cdoc:,...;do,:oddoollc:'..........................;,',;;;;;;;:,.,;coxO0XK; lo............',,''");
            Console.WriteLine("cc,,do'....lXWWWKc..,OWWWKlo0KNWNKk0KOO0Oxlc:;lc. .;,...,;;',l:cO0Ok0XKOxdollc;,'...................'','.'lxddddolccccc,':cldkOKk'.xc.....'.....',',,'");
            Console.WriteLine("cc:oo'   .:KWWWXl..,OWWNXxl0NWWWWMN0kd;',ol'.',c,.      ,c;,',o0KOXWNX0kdlc:;,'...,cdxdddddol:,'''''''''..:xkO00kxollc:;.,:coxk0l.cd'......''..'..',,,");
            Console.WriteLine("ccll'. . .kWWWWx'.'xWWNXkcdNWNX0Ox:;dOl'';lc''''..     .';cc,c0KKNWNX0xo:,'.......',;:ccccoOKk:'..........lKOkO0Oxollc::,.;cldkx,.ol......''......',,'");
            Console.WriteLine("cc;......cXWWW0;..dNWNKkc';xkl,;dd;';cdc',,;;,,.. .......';lxKWWWWXKkl;'..................,dKKd,.........'d0KXNNX0xoodl,'.':ldxc.;x;....'c:,:c,.....''");
            Console.WriteLine("cc;.... .kWWWNl..;KWWKdcc;.;xk:';lc,,;;;;;:::;'..,;:c:;:l,,xNWWNNXOl,.....................,dX0l:l:'......dNK0OOOOxlccc:;;'';coc..co,;:::c:'.':c;;;;,''");
            Console.WriteLine("cco:....cXWWWx'..:OOdl''oOl.':c,',,;;;::::::;'.;clllc:''ooxNWNNKkc,.......................';dllkOKKd:,;:;o0XWMWKxxdlcoc::'.;cc;.'oc;c;,.......':;,,'''");
            Console.WriteLine("cco:....kWWWK:.......:o;.,c;',',,;;;;,,;:cc;',cooodc,cl',kNNXKx:.....................''....',,dOx00xddocdKK000Okodoc::,,'.';;;dlco'.'..........'''''''");
            Console.WriteLine("cc;. ..:XWWWx......   .'..'',,,;;;,.. .,cc:;coddxddl;cxoxNN0o;.........................''''''lkdddlxkolcxXWWWXOkkdc::;;;..',';xdl;...':dxxoc'.......''");
            Console.WriteLine("cc,. ..dWWWNl.....     ..'',,,;;'.   .,clc:odxddd;:oc,;kNKdc'............................'''lOolllOklodkkkO0XXO00xllc;;'...';ldd:...'x0kxdxkd'.....'''");
            Console.WriteLine("cc,.. 'OWWW0;.....    ..'',,;;'.    .:lloodxkkl:c,'dl;kKxlxOc...........'.................:kXx::lOxlolo0NNKOOkkxoc:;,''....;:coo,..'oxdkxlloc'.''..',,");
            Console.WriteLine("cc,.  :XWWWx.....    ..'',,;,.     .:loddxkxollcldlcdkdcdKWNo,;,'..':lxO00xoc'......'..,:lx0Ko::ldddokkkOKNXKX0dc:;;::'...':;:o;..;xk:oXNXxol:c,''',,,");
            Console.WriteLine("cc,. .oWWWK:....    ..'',,,..     'coodxkdollool;cloo;'cdOKNKkxdlcd0NWWWNNNNX0l,,,'';cx0NNkx0l;;lxl:xXNNK0Oddkxlc;,,;'.....',cc..:OOd;,l0N0ddkxc'.',;;");
            Console.WriteLine("cc,. '0WWWd....    .''',,'. ..,'.'cooxxdolcclodolll;'..,:ldk0K0OOKXXKK0OOkkOOKXd,cdkKNNNNNXX0:;xkccddONWXXNKxl:;;',,........'l:.c0Odo:..;O0xdO0d;.';::");
            Console.WriteLine("cc,. cNWWX:....   .'',,,....,::''codxolc::ccldddoc,,cl,.',:cloddddddollcc:cclodc'xWNNNNNNNXNklOk:l0XXOkxx0Kkolc:;;;'.',;:c:':o';Okolc:;..:kxd0Xk;.';::");
            Console.WriteLine("cc,..dWWWk'....  .',,,'..';:cc,,codoc:;',lddddl;..,lxOx;..',;:ccc::;;,',ldkO000Odox0XXXXXXXXolddlc0WX0KOxdlc;;,''..'cxOkllxlll'cdol:;c:;;,oxoKKd:'.,::");
            Console.WriteLine("cc,..dWWNl....  .',,;'..;::cc;,cdoc;;'.'lddoc,. .'::loddc,....',''...'l0NWWWNNXKKOolxO0KXXXKc.:XNkcld0KOdlc::;::'.;ldxOX0;:l:;;cllc::c::c,;:;kXoc:',::");
            Console.WriteLine("cc,..kWW0;.... .',;;..,:::cc;;loc,,,..,odo;..   ..',;:clodl;'. .... 'kNWWWNNXKOkkxxc;okOOk0O, lNXK0dllcc:;,,;:;',cllox0Xk'.'..,:cc:::::;;'..'xOdx:.,;;");
            Console.WriteLine("cc, '0WWk'... .',;,.';:::ccccll,',...,oo:'..........',;::cloo:. ...,OWWWNX00Oxxdlcl;':ooxkKd..;xkOOko:;,,''',..,c::lox0Kl.';:;:l:,;:;'.''''.':dOd,.,;;");
            Console.WriteLine("cc,.'OMXl.... .;;,',:::c:::cl:.';...:l:.........;colc,'',,;:cc,...;ONNNX0Oxddoo:;:;'.,lx00Ko...lOxdoolc:clc;...,c::lookO;,o0Ko;:::,'...'''''.'ok;'',;,");
            Console.WriteLine("cc;.'OMK:.'...;:;';:::;,,:lc'.,,...:l,........,ldkO00kc'..',;:,...dXKK0Oxddooc;,,'..,oO0KKXk'...,clc:;:c:;..''',cc;:llolldkxdoc:;,''..'''''',,;;.'',,,");
            Console.WriteLine("cc;..OMK;.,..,c;';:::'. 'll'.,....:c.     ...;:clllccod;.,:cok0d',kOkxxdolcc;'''..,oO0KKKXKKo.........'......;;,;:,,::cllllcccc:;::;';;,,,,,;,''''',,'");
            Console.WriteLine("cc;..xMK:''..c:,;c:,.  .;o;',....,;. ..   .'clokOkkx;:c,;c:lxddOl;lldxdl:;'.....'oOKKKXKK00OOo,.............'',;;;:ccclccccc:;,;::,'',,,,,,;;,,,,,,,''");
            Console.WriteLine("cc;..dWK:''.:c,;lc,.   'oc,'....... .';c:,;ld0K000Ol';cclldkOd::'.;ldxOOo'.....;kXXXKK0OOkxxxxxoc;,,'.''....''';'':c::::::;,,;;;;,'''''''''''',,''''''");
            Console.WriteLine("cl;..oWK:,.'c;;c:'.   .co;'.......'ck0XXdcoxKK0KOo,..;ld0KKkl;'.':ldxo:oo,...,oKXXKKOOkxdolloddxO00xodO0kl'..''''.,;;;;;,'..,:;;,,''''''',''''''',,'''");
            Console.WriteLine("ll;. cNK:''::,c:.    .,o;..  .. .c0NK00dcox0KKOl;,,':dOKK0dc:'':dO0K0d;;;.':dKNNXK0kxdollc:llldxkxdoxOKXNNd..'..'..',;;;;;,,,,::,''''''''''''',;,,,'''");
            Console.WriteLine("lo;. ;KK:.,:;:c'     .lc..   ..'xNW0kKklox0K0dc;',::o0XKOl:c,'lOKXKk:',;;'cOKNXK0kxollc:;:ccllllolodk0XNNNo.'''.','',,''''....,cxl,'''''''''',,,''''''");
            Console.WriteLine("lo;. 'OXl':;;c,.     ,o,      'kWWNkOXocdkKkl:cc;.'ckXKkc:c:,cOXKkc'.,::,',:xXKOxdllc:,,;:cc:;clllodkKXNWO,.'''...'.........''',dx,'''''''''',;'''''''");
            Console.WriteLine("lo;. .xWd,:,::. .   .;:.     .xWWW0kXNoc0Xkccccc;.'xKKx:;::,:kXKd'.'::;'';,':kOdolc;;;;:::;,;cccclodkKXN0;.,'''''...''''''''''''l0occ;,'''',,,,'',''''");
            Console.WriteLine("lo;. .lNx,,,;'.......,.... ..;0WWKd0WNkcOOcclc::;.'kXk;..'..lXKl..;:,'',;;::;cl:c:::::;;;..;cccccccox0KKc.',,'''''''''''''''''',;cc:cxd,',,'''''',,'''");
            Console.WriteLine("lo;.  ,0O;',,...   ........cdo0MXdxXOKKdc:cocc::;..l0c......cx;..','',;;;::c:;:,.;c:;;;'..,cccccccccldxkxdolccoxO00Oo:;'''''''',,'''';do;,,,,,,,','',,");
            Console.WriteLine("oo;.  .x0;.,.          ..;dOo:0WxoOdxKK0xoolc:::,...'............'',;;:::cccc;,'.:::;,...':c:cll:::codxkO00kkKXXO0NWXxddc'',,'',,''''':ko,,,,,,,,'',,,");
            Console.WriteLine("oo;.   :0c.'.          .:kko;:KKlldxKK0Okdolc::;'...............,;;::ccccllll:'.'::;'....,;,cl:;:clllooddxllxOOK0dkNWNdd0l'''''''''';ol:::;,,,,,,,,,,,");
            Console.WriteLine("oo;.   .kd...          .:o:,;dNd'l0KK0Okxdlc::;,.',............;::cclllccodxd;..','.......'cl;,clllllooodo:lxxkOKkdKWWx:Ox.',,'',;;,:dc',;::;;,,,,,,,,");
            Console.WriteLine("oo;.    lx'..          .cc;;cOO;oKK00Okxdolc::;'.;cc;..',,,;;,,:lcccccldkOdc,.............,;'..,,,,'',,;;,'lxxkOkoxKOdcxO:.,,,''::,,':lc,,,:;,;,,,,,,,");
            Console.WriteLine("lo;.    'dc..          'cll:od:dXK00Oxdxolc:::,..,:::;',;;:ccccccl;,cdkOxl'..............'''''',,,,,,;,,;cldddlc,,:;;oxo;,,;,,,;c;,;;;;cc:,;:;;,,,;,,,");
            Console.WriteLine("ll;.     :d'.          .clcxx'cXK0OOx:ldlc::;,....',;;,,:::lclloccldkxdl;.'''..',,.........''';;,,,;:cloxxdxkOkko;:cll;,;;;;;;:c;,;;:;;;;clc:ccccc:,,,");
            Console.WriteLine("ll,.     .c;..         .::lo'.oK0OOd,'clcc:'...........,cloddddocodolc,..'''''''','..'',''',,;:;'';:codollokOkollc:;;;:;;;,;::;cc;;;;;;;,:l:;cdl::,,''");
            Console.WriteLine("cl,.      .:,.          .lk,  'ldoc'.:cc:,,,'.............',;;:loo:;'.........''''',,,;;;;,,,;::clddolc:oxxxxkkxl;:lc:::;;;cc;:lc;;:;;;::c:;,:ll:::,''");
            Console.WriteLine("cl,.       .,.          .oXc    ...,cc:;;;;,'..........'';;'..';,'............''''..'',,,;::cllccclc:okdolc:c0WWKo:cllc:::cc:;co:;;;;;;cc:;;;,:oo::,''");
            Console.WriteLine("cc,.                     ;KKl:;,,,:cc:;::,,:c:lol;;lo:;l:''.'.......................',;:c;,;;;;:::okxllc:::::dXWNOllolc:::::::coo:;:::cc:;;;;;;col:;''");
            Console.WriteLine("cc,.            ..;cc'.  .,odddolcc:;::;'.'',;clo:cdo:,;,..''.''...................',;,;c;,,;::coxkxc;:c:::::ckNWW0dolc:::::::cll::c::colc:::::::cl:''");
            Console.WriteLine("cc,.        .'coxkdllc:coo:..',,''...;,................';'....''''''..........'',,,,,,,,:looxxl:;:c;;cc,:l:;;:xNWNKkdc::::::::oo:::cc:;:lo:::c:;;:lc''");
            Console.WriteLine("cc,.      .:xOkdlcloxOOdxOxc:c:;'...,,'................':;.'''.....''.......'',;::cccccloxk00K0xdlccclddxkxdooxO00Okxxoooddl::lolcloollcclccc:;;:cl;''");
            Console.WriteLine("cc,.    .,dkxo::lkK0kkdcclokkdccl:;:,.cd,.............,,,,',;'';looddl'...''',,,::::ccloxOkooodOKXXK00KXXX0kkO0OxxOxoddooxKkllcoolxdccoolllodo:coll;''");
            Console.WriteLine("cc,.    ,do:',oOOkkxollokKXXXOl:;;;'...ll.........''',;'.,;;,cxOkdl:;;'......'',;;;;:lodxdc;occxkkOO0000XXX0kdokkxkdccllllkKkdoxkxdlcccc:::cccclolc;',");
            Console.WriteLine("cc,.   .''..,dkdl::,;o0KOkxxxxoc'.......'.............,,'',''::;,,''',,'',''''.'''':llcccll:;cc;,;cddoolodxxxklcdOkdl::clxK0dooolllcccccccccc::::c:;''");
            Console.WriteLine("cc,.       ;kd;'...,k0Okxdolll:,......................,;;'....',,,',;;;,,,;;::::::dd;,,,,,,,,;:::;;;;;::c::::cllcdXW0lcdxkKOoddollcccllcclccccccc::;''");
            Console.WriteLine("cc;.      .cc.   .:kOoc;'.........................',..,,,,'''';;'''''',,.';c:;;;;;lo;,;;;:::cc;;;:::cddoollooooclkNW0xxdlldxdddddxkoclccllllcccc::;,''");
            Console.WriteLine("cc;.      ..     ;ko,.............................,,...''',,,''''''''',,',:c;;;;,:lcclcclcccccccccccoxoodc::cccdKNXxokkloolllcccccdOxcclolllcccc:::,''");
            Console.WriteLine("cc;'.....'''''''':c'............................''','''',,,,,,,,,,,'''',',;;,,;,;::;;:::;;;;;;;;;;,;:;:c:;;;;;;cooc;;cc::::::;;;;;;cc;;::::::;;;;;;,,'");
            Console.WriteLine(":;;;;;;;;;;;;;;;;,,,,,,,,,,,''''''''''''''''''''''',,,;;;;;::;;;;;;,,,'''''''',,,,,,,,,,'',,',,,,,,,;;;;;;,,'''''''''',,,,,,''''''''''',,,,,,,,;;;;;,,");
            Console.WriteLine("ccllcclllllccc::::;;;;;;;;;;;;;;;;:::::::::::::::::cccc:::::ccccccc::::;;;;;;;;;,;;;;;;;;;;;;;;;;;:::::::::::::::::::::::::;;;;;;,;;;:::::c:::::;;;;;;");
            Console.WriteLine("ldkOOOO0000OOkkkxxdoooooooooooooddxxxkkkkkkkkkkkkkkOOkkxxddxxxxxkkkxxdddooooollllllloooooooolllllooddddxddxxxxxxxxxxxddxdddddollcclllodxxxxxxdddddolcc");
            Console.WriteLine("lokKKKKKKXXKKKK0OOkxxxdddddddddxxkkOOO00000O00000000K00OOkkkOOOOOOOOkxddddddddddddddddddddddddddddddxxkkkkkkkkkkkkkkkkkkxxkkkxxkkxxxxxkOkxxkkkkkxxxocc");
            Console.WriteLine("clk0KKKKKKXXKKK00OkkxdddddddddxxkkkOOO000000000OO000000OOOOOOOOOOOOkkkxxxdddddddddddddddddddddddddddxxkkkkxkkkkkkkkkkkkkkkkkO00xddlclooxOOkxxkkkxxxdcc");
            
        }
    }
}