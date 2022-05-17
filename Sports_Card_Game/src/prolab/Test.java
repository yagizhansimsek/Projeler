
package prolab;

import java.awt.Color;
import java.awt.Dimension;
import java.awt.Image;
import java.util.ArrayList;
import java.util.Random;
import javax.swing.ImageIcon;
import javax.swing.JButton;


public class Test {
    CediOsman bcard1;
    JamesHarden bcard2;
    KobeBryant bcard3;
    LeBronJames bcard4;
    MagicJohnson bcard5;
    MichaelJordan bcard6;
    StephenCurry bcard7;
    StephenCurry bcard8;
    
    CristianoRonaldo fcard1;
    LionelMessi fcard2;
    LukaModric fcard3;
    MuhammedSalah fcard4;
    NeymarSuarez fcard5;
    SergioRamos fcard6;
    WayneRooney fcard7;
    ZlatanIbrahimovic fcard8;
    
    public JButton GenerateBCards(JButton temp,int index){
       
        switch(index){
            case 0:
                bcard1 = new  CediOsman();
                bcard1.sporcuIsim = "Cedi Osman ";
                bcard1.sporcuTakim = "Cleveland ";
                bcard1.fileName = "bco.png";
                bcard1.sporcuPuani = 85;
                bcard1.ikilik =95;
                bcard1.serbestAtis =70;
                bcard1.ucluk=80;
                temp.putClientProperty("sporcuIsim", String.valueOf(bcard1.sporcuIsim));
                temp.putClientProperty("sporcuPuan", String.valueOf(bcard1.sporcuPuani));
                temp.putClientProperty("ikilik", String.valueOf(bcard1.ikilik));
                temp.putClientProperty("ucluk", String.valueOf(bcard1.ucluk));
                temp.putClientProperty("serbestAtis", String.valueOf(bcard1.serbestAtis));
                temp.putClientProperty("CardImage", System.getProperty("user.dir")+"\\src\\prolab\\documents\\"+bcard1.fileName);
                temp.putClientProperty("playerType", String.valueOf("basketbolcu"));
            break;
            case 1:
                bcard2 = new  JamesHarden();
                bcard2.sporcuIsim = "James Harden ";
                bcard2.sporcuTakim = "Houston ";
                bcard2.fileName = "bjh.png";
                bcard2.sporcuPuani = 85;
                bcard2.ikilik =90;
                bcard2.serbestAtis =90;
                bcard2.ucluk=70;
                temp.putClientProperty("sporcuIsim", String.valueOf(bcard2.sporcuIsim));
                temp.putClientProperty("sporcuPuan", String.valueOf(bcard2.sporcuPuani));
                temp.putClientProperty("ikilik", String.valueOf(bcard2.ikilik));
                temp.putClientProperty("ucluk", String.valueOf(bcard2.ucluk));
                temp.putClientProperty("serbestAtis", String.valueOf(bcard2.serbestAtis));
                temp.putClientProperty("CardImage", System.getProperty("user.dir")+"\\src\\prolab\\documents\\"+bcard2.fileName);
                temp.putClientProperty("playerType", String.valueOf("basketbolcu"));
            break;
            case 2:
                bcard3 = new  KobeBryant();
                bcard3.sporcuIsim = "Kobe Bryant ";
                bcard3.sporcuTakim = "Lakers ";
                bcard3.fileName = "bkb.png";
                bcard3.sporcuPuani = 80;
                bcard3.ikilik =80;
                bcard3.serbestAtis =75;
                bcard3.ucluk=85;
                temp.putClientProperty("sporcuIsim", String.valueOf(bcard3.sporcuIsim));
                temp.putClientProperty("sporcuPuan", String.valueOf(bcard3.sporcuPuani));
                temp.putClientProperty("ikilik", String.valueOf(bcard3.ikilik));
                temp.putClientProperty("ucluk", String.valueOf(bcard3.ucluk));
                temp.putClientProperty("serbestAtis", String.valueOf(bcard3.serbestAtis));
                temp.putClientProperty("CardImage", System.getProperty("user.dir")+"\\src\\prolab\\documents\\"+bcard3.fileName);
                temp.putClientProperty("playerType", String.valueOf("basketbolcu"));
            break;
            case 3:
                bcard4 = new  LeBronJames();
                bcard4.sporcuIsim = "LeBron James ";
                bcard4.sporcuTakim = "Lakers ";
                bcard4.fileName = "blj.png";
                bcard4.sporcuPuani = 95;
                bcard4.ikilik =95;
                bcard4.serbestAtis =95;
                bcard4.ucluk=95;
                temp.putClientProperty("sporcuIsim", String.valueOf(bcard4.sporcuIsim));
                temp.putClientProperty("sporcuPuan", String.valueOf(bcard4.sporcuPuani));
                temp.putClientProperty("ikilik", String.valueOf(bcard4.ikilik));
                temp.putClientProperty("ucluk", String.valueOf(bcard4.ucluk));
                temp.putClientProperty("serbestAtis", String.valueOf(bcard4.serbestAtis));
                temp.putClientProperty("CardImage", System.getProperty("user.dir")+"\\src\\prolab\\documents\\"+bcard4.fileName);
                temp.putClientProperty("playerType", String.valueOf("basketbolcu"));
            break;
            case 4:
                bcard5 = new  MagicJohnson();
                bcard5.sporcuIsim = "Magic Johnson ";
                bcard5.sporcuTakim = "Lakers ";
                bcard5.fileName = "bmaj.png";
                bcard5.sporcuPuani = 75;
                bcard5.ikilik =80;
                bcard5.serbestAtis =75;
                bcard5.ucluk=70;  
                temp.putClientProperty("sporcuIsim", String.valueOf(bcard5.sporcuIsim));
                temp.putClientProperty("sporcuPuan", String.valueOf(bcard5.sporcuPuani));
                temp.putClientProperty("ikilik", String.valueOf(bcard5.ikilik));
                temp.putClientProperty("ucluk", String.valueOf(bcard5.ucluk));
                temp.putClientProperty("serbestAtis", String.valueOf(bcard5.serbestAtis));
                temp.putClientProperty("CardImage", System.getProperty("user.dir")+"\\src\\prolab\\documents\\"+bcard5.fileName);
                temp.putClientProperty("playerType", String.valueOf("basketbolcu"));
            break;
            case 5:
                bcard6 = new  MichaelJordan();
                bcard6.sporcuIsim = "Michael Jordan ";
                bcard6.sporcuTakim = "Bulls ";
                bcard6.fileName = "bmj.png";
                bcard6.sporcuPuani = 95;
                bcard6.ikilik =90;
                bcard6.serbestAtis =90;
                bcard6.ucluk=100;
                temp.putClientProperty("sporcuIsim", String.valueOf(bcard6.sporcuIsim));
                temp.putClientProperty("sporcuPuan", String.valueOf(bcard6.sporcuPuani));
                temp.putClientProperty("ikilik", String.valueOf(bcard6.ikilik));
                temp.putClientProperty("ucluk", String.valueOf(bcard6.ucluk));
                temp.putClientProperty("serbestAtis", String.valueOf(bcard6.serbestAtis));
                temp.putClientProperty("CardImage", System.getProperty("user.dir")+"\\src\\prolab\\documents\\"+bcard6.fileName);
                temp.putClientProperty("playerType", String.valueOf("basketbolcu"));
            break;
            case 6:
                bcard7 = new  StephenCurry();
                bcard7.sporcuIsim = "Stephen Curry ";
                bcard7.sporcuTakim = "The Town ";
                bcard7.fileName = "bsc.png";
                bcard7.sporcuPuani = 70;
                bcard7.ikilik =80;
                bcard7.serbestAtis =65;
                bcard7.ucluk=70;
                temp.putClientProperty("sporcuIsim", String.valueOf(bcard7.sporcuIsim));
                temp.putClientProperty("sporcuPuan", String.valueOf(bcard7.sporcuPuani));
                temp.putClientProperty("ikilik", String.valueOf(bcard7.ikilik));
                temp.putClientProperty("ucluk", String.valueOf(bcard7.ucluk));
                temp.putClientProperty("serbestAtis", String.valueOf(bcard7.serbestAtis));
                temp.putClientProperty("CardImage", System.getProperty("user.dir")+"\\src\\prolab\\documents\\"+bcard7.fileName);
                temp.putClientProperty("playerType", String.valueOf("basketbolcu"));
            break;
            case 7:
                bcard8 = new  StephenCurry();
                bcard8.sporcuIsim = "Shaquille Oneal ";
                bcard8.sporcuTakim = "Lakers ";
                bcard8.fileName = "bso.png";
                bcard8.sporcuPuani = 85;
                bcard8.ikilik =85;
                bcard8.serbestAtis =75;
                bcard8.ucluk=90;
                temp.putClientProperty("sporcuIsim", String.valueOf(bcard8.sporcuIsim));
                temp.putClientProperty("sporcuPuan", String.valueOf(bcard8.sporcuPuani));
                temp.putClientProperty("ikilik", String.valueOf(bcard8.ikilik));
                temp.putClientProperty("ucluk", String.valueOf(bcard8.ucluk));
                temp.putClientProperty("serbestAtis", String.valueOf(bcard8.serbestAtis));
                temp.putClientProperty("CardImage", System.getProperty("user.dir")+"\\src\\prolab\\documents\\"+bcard8.fileName);
                temp.putClientProperty("playerType", String.valueOf("basketbolcu"));
            break;
        }
        return temp;
    }
    
    
    public JButton GenerateFCards(JButton temp,int index){
        switch(index){
            case 0:
                fcard1 = new  CristianoRonaldo();
                fcard1.sporcuIsim = "Cristiano Ronaldo ";
                fcard1.sporcuTakim = "Real Madrid ";
                fcard1.fileName = "fcr.png";
                fcard1.sporcuPuani = 88;
                fcard1.penalti =90;
                fcard1.serbestAtis =85;
                fcard1.kaleciKarsiKarsiya=90;
                temp.putClientProperty("sporcuIsim", String.valueOf(fcard1.sporcuIsim));
                temp.putClientProperty("sporcuPuan", String.valueOf(fcard1.sporcuPuani));
                temp.putClientProperty("penalti", String.valueOf(fcard1.penalti));
                temp.putClientProperty("kaleciKarsiKarsiya", String.valueOf(fcard1.kaleciKarsiKarsiya));
                temp.putClientProperty("serbestAtis", String.valueOf(fcard1.serbestAtis));
                temp.putClientProperty("CardImage", System.getProperty("user.dir")+"\\src\\prolab\\documents\\"+fcard1.fileName);
                temp.putClientProperty("playerType", String.valueOf("futbolcu"));
            break;
            case 1:
                fcard2 = new  LionelMessi();
                fcard2.sporcuIsim = "Lionel Messi ";
                fcard2.sporcuTakim = "Barcelona ";
                fcard2.fileName = "flm.png";
                fcard2.sporcuPuani = 86;
                fcard2.penalti =80;
                fcard2.serbestAtis =95;
                fcard2.kaleciKarsiKarsiya=85;
                temp.putClientProperty("sporcuIsim", String.valueOf(fcard2.sporcuIsim));
                temp.putClientProperty("sporcuPuan", String.valueOf(fcard2.sporcuPuani));
                temp.putClientProperty("penalti", String.valueOf(fcard2.penalti));
                temp.putClientProperty("kaleciKarsiKarsiya", String.valueOf(fcard2.kaleciKarsiKarsiya));
                temp.putClientProperty("serbestAtis", String.valueOf(fcard2.serbestAtis));
                temp.putClientProperty("CardImage", System.getProperty("user.dir")+"\\src\\prolab\\documents\\"+fcard2.fileName);
                temp.putClientProperty("playerType", String.valueOf("futbolcu"));
            case 2:
                fcard3 = new  LukaModric();
                fcard3.sporcuIsim = "Luka Modric ";
                fcard3.sporcuTakim = "Real Madrid ";
                fcard3.fileName = "flmr.png";
                fcard3.sporcuPuani = 75;
                fcard3.penalti =70;
                fcard3.serbestAtis =85;
                fcard3.kaleciKarsiKarsiya=75;
                temp.putClientProperty("sporcuIsim", String.valueOf(fcard3.sporcuIsim));
                temp.putClientProperty("sporcuPuan", String.valueOf(fcard3.sporcuPuani));
                temp.putClientProperty("penalti", String.valueOf(fcard3.penalti));
                temp.putClientProperty("kaleciKarsiKarsiya", String.valueOf(fcard3.kaleciKarsiKarsiya));
                temp.putClientProperty("serbestAtis", String.valueOf(fcard3.serbestAtis));
                temp.putClientProperty("CardImage", System.getProperty("user.dir")+"\\src\\prolab\\documents\\"+fcard3.fileName);
                temp.putClientProperty("playerType", String.valueOf("futbolcu"));
            break;
            case 3:
                fcard4 = new  MuhammedSalah();
                fcard4.sporcuIsim = "Muhammed Salah ";
                fcard4.sporcuTakim = "Livirpool ";
                fcard4.fileName = "fms.png";
                fcard4.sporcuPuani = 86;
                fcard4.penalti =85;
                fcard4.serbestAtis =85;
                fcard4.kaleciKarsiKarsiya=90;
                temp.putClientProperty("sporcuIsim", String.valueOf(fcard4.sporcuIsim));
                temp.putClientProperty("sporcuPuan", String.valueOf(fcard4.sporcuPuani));
                temp.putClientProperty("penalti", String.valueOf(fcard4.penalti));
                temp.putClientProperty("kaleciKarsiKarsiya", String.valueOf(fcard4.kaleciKarsiKarsiya));
                temp.putClientProperty("serbestAtis", String.valueOf(fcard4.serbestAtis));
                temp.putClientProperty("CardImage", System.getProperty("user.dir")+"\\src\\prolab\\documents\\"+fcard4.fileName);
                temp.putClientProperty("playerType", String.valueOf("futbolcu"));
            break;
            case 4:
                fcard5 = new  NeymarSuarez();
                fcard5.sporcuIsim = "Neymar Suarez ";
                fcard5.sporcuTakim = "Paris Saint-Germain ";
                fcard5.fileName = "fnm.png";
                fcard5.sporcuPuani = 80;
                fcard5.penalti =80;
                fcard5.serbestAtis =80;
                fcard5.kaleciKarsiKarsiya=80;
                temp.putClientProperty("sporcuIsim", String.valueOf(fcard5.sporcuIsim));
                temp.putClientProperty("sporcuPuan", String.valueOf(fcard5.sporcuPuani));
                temp.putClientProperty("penalti", String.valueOf(fcard5.penalti));
                temp.putClientProperty("kaleciKarsiKarsiya", String.valueOf(fcard5.kaleciKarsiKarsiya));
                temp.putClientProperty("serbestAtis", String.valueOf(fcard5.serbestAtis));
                temp.putClientProperty("CardImage", System.getProperty("user.dir")+"\\src\\prolab\\documents\\"+fcard5.fileName);
                temp.putClientProperty("playerType", String.valueOf("futbolcu"));
            break;
            case 5:
                fcard6 = new  SergioRamos();
                fcard6.sporcuIsim = "Sergio Ramos ";
                fcard6.sporcuTakim = "Real Madrid ";
                fcard6.fileName = "fsr.png";
                fcard6.sporcuPuani = 80;
                fcard6.penalti =80;
                fcard6.serbestAtis =80;
                fcard6.kaleciKarsiKarsiya=80;
                temp.putClientProperty("sporcuIsim", String.valueOf(fcard6.sporcuIsim));
                temp.putClientProperty("sporcuPuan", String.valueOf(fcard6.sporcuPuani));
                temp.putClientProperty("penalti", String.valueOf(fcard6.penalti));
                temp.putClientProperty("kaleciKarsiKarsiya", String.valueOf(fcard6.kaleciKarsiKarsiya));
                temp.putClientProperty("serbestAtis", String.valueOf(fcard6.serbestAtis));
                temp.putClientProperty("CardImage", System.getProperty("user.dir")+"\\src\\prolab\\documents\\"+fcard6.fileName);
                temp.putClientProperty("playerType", String.valueOf("futbolcu"));
            break;
            case 6:
                fcard7 = new  WayneRooney();
                fcard7.sporcuIsim = "Wayne Rooney ";
                fcard7.sporcuTakim = "Derby County FC ";
                fcard7.fileName = "fwr.png ";
                fcard7.sporcuPuani = 82;
                fcard7.penalti =95;
                fcard7.serbestAtis =75;
                fcard7.kaleciKarsiKarsiya=80;
                temp.putClientProperty("sporcuIsim", String.valueOf(fcard7.sporcuIsim));
                temp.putClientProperty("sporcuPuan", String.valueOf(fcard7.sporcuPuani));
                temp.putClientProperty("penalti", String.valueOf(fcard7.penalti));
                temp.putClientProperty("kaleciKarsiKarsiya", String.valueOf(fcard7.kaleciKarsiKarsiya));
                temp.putClientProperty("serbestAtis", String.valueOf(fcard7.serbestAtis));
                temp.putClientProperty("CardImage", System.getProperty("user.dir")+"\\src\\prolab\\documents\\"+fcard7.fileName);
                temp.putClientProperty("playerType", String.valueOf("futbolcu"));
            break;
            case 7:
                fcard8 = new  ZlatanIbrahimovic();
                fcard8.sporcuIsim = "Zlatan Ibrahimovic ";
                fcard8.sporcuTakim = "AC Milan ";
                fcard8.fileName = "fzi.png ";
                fcard8.sporcuPuani = 86;
                fcard8.penalti =80;
                fcard8.serbestAtis =80;
                fcard8.kaleciKarsiKarsiya=75;
                temp.putClientProperty("sporcuIsim", String.valueOf(fcard8.sporcuIsim));
                temp.putClientProperty("sporcuPuan", String.valueOf(fcard8.sporcuPuani));
                temp.putClientProperty("penalti", String.valueOf(fcard8.penalti));
                temp.putClientProperty("kaleciKarsiKarsiya", String.valueOf(fcard8.kaleciKarsiKarsiya));
                temp.putClientProperty("serbestAtis", String.valueOf(fcard8.serbestAtis));
                temp.putClientProperty("CardImage", System.getProperty("user.dir")+"\\src\\prolab\\documents\\"+fcard8.fileName);
                temp.putClientProperty("playerType", String.valueOf("futbolcu"));
            break;
        }
        return temp;
    }
    
    public ArrayList<JButton> makeButton(ArrayList<JButton> Buttons){
        for (int i = 0; i < 16; i++) {
            //System.out.println("i:"+i+" İsim"+Cards[i].sporcuIsim);
            JButton temp = new JButton();
            
            if(i < 8){
            temp = GenerateBCards(temp,i);
            }else{
            temp = GenerateFCards(temp,i-8);
            }
         
            //System.out.println(temp.getClientProperty("CardImage").toString());
            ImageIcon icon = new ImageIcon( temp.getClientProperty("CardImage").toString());
            Image image = icon.getImage();
            image = image.getScaledInstance(140, 200, Image.SCALE_SMOOTH);
            ImageIcon edited = new ImageIcon(image);
            temp.setIcon(edited);
            temp.setAlignmentX(JButton.CENTER_ALIGNMENT);
            temp.setPreferredSize( new Dimension(140,200));
            temp.setBackground(Color.white);
        
            Buttons.add(temp);
        }
        return Buttons;
    }
    
    
    
    public String selectPosition(String playerType){
        Random r=new Random(); //random sınıfı
        int selection=r.nextInt(3)+1;
        if(playerType == "futbolcu"){
            if(selection == 1){
                return "penalti";
            }else if(selection == 2){
                return "kaleciKarsiKarsiya";
            }else if(selection == 3){
                return "serbestAtis";
            }
        }
        else if(playerType == "basketbolcu"){
            if(selection == 1){
                return "ikilik";
            }else if(selection == 2){
                return "ucluk";
            }else if(selection == 3){
                return "serbestAtis";
            }
        }
        return "";
    }
}
