package prolab;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.util.ArrayList;
import javax.swing.*;
import java.util.Random; 

public class GameArena extends JFrame{
    
    int ScreenWidth=1500;
    int ScreenHeight=910;
    String top = BorderLayout.PAGE_START;
    String center  = BorderLayout.CENTER;
    public static int COM_SCORE =0;
    public static int PLAYER_SCORE =0;
    private int secim;
    protected ArrayList<JButton> computer1_cards = new ArrayList<JButton>();
    protected ArrayList<JButton> computer2_cards = new ArrayList<JButton>();
    private int Hamle =0;
    private String LastPlayerType="";
    
    public GameArena(){
        ImageIcon icon = new ImageIcon( System.getProperty("user.dir")+"\\src\\prolab\\documents\\button.png");
        JPanel panel = new JPanel();        
        panel.setBackground(Color.white);
        getContentPane().add(panel);
        
        LayoutManager layout = new BoxLayout(panel, BoxLayout.Y_AXIS);
        Box boxes[] = new Box[6];
        
        int[] size={50,200,310,200,50,30};
        ArrayList<JPanel> panels = new ArrayList<JPanel>();
        

        for(int i=0;i<6;i++){
            JPanel temp = new JPanel();
            temp.setPreferredSize(new Dimension(ScreenWidth, size[i] ));
            temp.setBackground(Color.black);
            panels.add(temp);
        }
        
        for(int i=0;i<6;i++){
            boxes[i] = Box.createHorizontalBox();
            boxes[i].createGlue();
            panel.add(boxes[i]);
            boxes[i].add(panels.get(i));
        }

        ArrayList<JPanel> center = CenterLayout(panels);
            
        anasayfa(panels,icon,center);
        setTitle("Sporcu Kart Oyunu");
        setSize(ScreenWidth,ScreenHeight);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setIconImage(icon.getImage());
        
    }
    
    public ArrayList<JPanel> CenterLayout(ArrayList<JPanel> panels){
           
        int[] center_size={25,0,25,200,0,25};
        LayoutManager center_layout = new BoxLayout(panels.get(2), BoxLayout.Y_AXIS);
        ArrayList<JPanel> center_elements = new ArrayList<JPanel>();
        Box center_boxes[] = new Box[center_size.length];
        
        
        for(int i=0;i<center_size.length;i++){
            JPanel temp = new JPanel();
            temp.setPreferredSize(new Dimension(ScreenWidth, center_size[i] ));
            temp.setBackground(Color.black);
            center_elements.add(temp);
        }
        
        for(int i=0;i<center_size.length;i++){
            center_boxes[i] = Box.createHorizontalBox();
            center_boxes[i].createGlue();
            panels.get(2).add(center_boxes[i]);
            center_boxes[i].add(center_elements.get(i));
        }

        return center_elements;
    }
    
    public void savas(JButton player_btn,ArrayList<JPanel> center,ArrayList<JButton> Buttons,ArrayList<JPanel> panels){

        Random rand = new Random();
        JButton computer_btn;
        int computer_secim = -1 ;
                
        while(true){
            computer_secim = (int)rand.nextInt(computer1_cards.size());

            computer_btn = computer1_cards.get(computer_secim);
            if(player_btn.getClientProperty("playerType").toString() == computer_btn.getClientProperty("playerType").toString()){
                break;
            }
        }
        
        
       
        ImageIcon Closed_Card = new ImageIcon( System.getProperty("user.dir")+"\\src\\prolab\\documents\\button.png");
        String WarCard1_Name = player_btn.getClientProperty("sporcuIsim").toString();
        ImageIcon  icon1 = new ImageIcon( player_btn.getClientProperty("CardImage").toString());
        Image image1 = icon1.getImage();
        image1 = image1.getScaledInstance(140, 200, Image.SCALE_SMOOTH);
        ImageIcon edited1 = new ImageIcon(image1);

        
        JButton WarCard1 = new JButton();
                
        WarCard1.setAlignmentX(JButton.CENTER_ALIGNMENT);
        WarCard1.setPreferredSize( new Dimension(140,200));
        WarCard1.setBackground(Color.white);
        WarCard1.setIcon(Closed_Card);

        String WarCard2_Name = computer_btn.getClientProperty("sporcuIsim").toString();
        
        ImageIcon icon2 = new ImageIcon( computer_btn.getClientProperty("CardImage").toString());
        Image image2 = icon2.getImage();
        image2 = image2.getScaledInstance(140, 200, Image.SCALE_SMOOTH);
        ImageIcon edited2 = new ImageIcon(image2);
        

        JButton WarCard2 = new JButton();
        WarCard2.setIcon(Closed_Card);
        WarCard2.setAlignmentX(JButton.CENTER_ALIGNMENT);
        WarCard2.setPreferredSize( new Dimension(140,200));
        WarCard2.setBackground(Color.white);

        center.get(3).add(WarCard2);
        center.get(3).add(WarCard1);

        WarCard1.setIcon(edited1);
        WarCard2.setIcon(edited2);

        
        Test gameInfo = new Test();
        String position = gameInfo.selectPosition(player_btn.getClientProperty("playerType").toString());
        System.out.println(player_btn.getClientProperty("playerType").toString());
        System.out.println(position);
        int WarCard1_DamagePoint  = Integer.valueOf(player_btn.getClientProperty(position).toString());
        
        int WarCard2_DamagePoint  = Integer.valueOf(computer_btn.getClientProperty(position).toString());
        //System.out.println(position + "WC1:"+WarCard1_DamagePoint+" WC2"+WarCard2_DamagePoint );
        if(WarCard1_DamagePoint > WarCard2_DamagePoint){
            PLAYER_SCORE +=10;
            panels.get(3).remove(player_btn);
            panels.get(3).repaint();
            panels.get(1).remove(computer_btn);
            panels.get(1).repaint();
            LastPlayerType = player_btn.getClientProperty("playerType").toString();
            computer1_cards.remove(computer_secim);
            center.get(2).removeAll();
            center.get(2).add(new JLabel("<html><font size='5' color='white'/>-Savaş Alanı-(Pozisyon:"+position+")</font></html>"));
            
        }else if(WarCard2_DamagePoint > WarCard1_DamagePoint){
            COM_SCORE +=10;
            panels.get(3).remove(player_btn);
            panels.get(3).repaint();
            panels.get(1).remove(computer_btn);
            panels.get(1).repaint();
            LastPlayerType = player_btn.getClientProperty("playerType").toString();
            computer1_cards.remove(computer_secim);
            center.get(2).removeAll();
            center.get(2).repaint();
            center.get(2).add(new JLabel("<html><font size='5' color='white'/>-Savaş Alanı-(Pozisyon:"+position+")</font></html>"));
            center.get(2).repaint();
        }else if(WarCard2_DamagePoint == WarCard1_DamagePoint){
            if(computer1_cards.size() != 1){
                System.out.println("Kartların Pozisyon Güçleri Aynı!Tekrar Deneyiniz");
                center.get(2).removeAll();
                center.get(2).repaint();
                center.get(2).add(new JLabel("<html><font size='5' color='white'/>-Savaş Alanı-(Pozisyon:"+position+")</font></html>"));
                center.get(2).repaint();
            }else{
                while(true){
                    position = gameInfo.selectPosition(player_btn.getClientProperty("playerType").toString());

                    WarCard1_DamagePoint  = Integer.valueOf(player_btn.getClientProperty(position).toString());
                    WarCard2_DamagePoint  = Integer.valueOf(computer_btn.getClientProperty(position).toString());
                    //System.out.println(position + "WC1:"+WarCard1_DamagePoint+" WC2"+WarCard2_DamagePoint );
                    if(WarCard1_DamagePoint > WarCard2_DamagePoint){
                        PLAYER_SCORE +=10;
                        panels.get(3).remove(player_btn);
                        panels.get(3).repaint();
                        panels.get(1).remove(computer_btn);
                        panels.get(1).repaint();
                        LastPlayerType = player_btn.getClientProperty("playerType").toString();
                        computer1_cards.remove(computer_secim);
                        center.get(2).removeAll();
                        center.get(2).repaint();
                        center.get(2).add(new JLabel("<html><font size='5' color='white'/>-Savaş Alanı-(Pozisyon:"+position+")</font></html>"));
                        center.get(2).repaint();
                        break;
                    }else if(WarCard2_DamagePoint > WarCard1_DamagePoint){
                        COM_SCORE +=10;
                        panels.get(3).remove(player_btn);
                        panels.get(3).repaint();
                        panels.get(1).remove(computer_btn);
                        panels.get(1).repaint();
                        LastPlayerType = player_btn.getClientProperty("playerType").toString();
                        computer1_cards.remove(computer_secim);
                        center.get(2).removeAll();
                        center.get(2).repaint();
                        center.get(2).add(new JLabel("<html><font size='5' color='white'/>-Savaş Alanı-(Pozisyon:"+position+")</font></html>"));
                        center.get(2).repaint();
                        break;
                    }
                }
            }
        }
        center.get(3).invalidate();


        write_score(panels);
    }
    
    public void write_score(ArrayList<JPanel> panels){
        panels.get(0).removeAll();
        panels.get(4).removeAll();
        JLabel comLabel = new  JLabel("<html><font size='7' color='white'>"+COM_SCORE+"</font></html>");
        JLabel playerLabel = new  JLabel("<html><font size='7' color='white'>"+PLAYER_SCORE+"</font></html>");
        panels.get(0).add(new JLabel("<html><font size='7' color='white'/>-Bilgisyar-PUAN:</font></html>"));
        panels.get(0).add(comLabel);
        panels.get(4).add(new JLabel("<html><font size='7' color='white'/>-Kullanıcı-PUAN:</font></html>"));
        panels.get(4).add(playerLabel);
    }
   
    
    public void  anasayfa(ArrayList<JPanel> panels,ImageIcon icon,ArrayList<JPanel> center){
        ArrayList<JButton> Buttons = new  ArrayList<JButton>();
        
        write_score(panels);
        
        center.get(2).add(new JLabel("<html><font size='5' color='white'/>-Savaş Alanı-</font></html>"));

        Test gameInfo = new Test();
        Buttons  = gameInfo.makeButton(Buttons);
        
        int[] sira = new int[16];

        Random rand = new Random(); 

        boolean check =true;
        
        int ilk8_futbolcu=0;
        int ilk8_basketbolcu=0;
        for(int i=0;i<16;i++){
            while(true){

                int gen_kart = rand.nextInt(16); 
                String position = Buttons.get(gen_kart).getClientProperty("playerType").toString();
                //System.out.println("girdim i:"+i+"Posisit "+position+" ilk8_futbolcu: "+ilk8_futbolcu+" ilk8_basketbolcu: "+ilk8_basketbolcu);
                if(i< 8 && ilk8_futbolcu < 4 || i< 8 && ilk8_basketbolcu < 4){
                    if(position == "futbolcu" && ilk8_futbolcu <4){
                        check=true;
                        
                        for (int j = 0; j < i; j++) {
                            if(sira[j] == gen_kart){
                                check = false;
                            }
                        }
                        if(check){
                            sira[i] = gen_kart;
                            ilk8_futbolcu++;
                            System.out.println("1->i:"+i+"sira[i]: "+gen_kart+" Isim:"+Buttons.get(gen_kart).getClientProperty("sporcuIsim").toString()+" Type:"+position +" ilk_8_basketbolcu: "+ilk8_basketbolcu+" ilk_8_futbolcu: "+ilk8_futbolcu);
                            break;
                        }
                    }else if(position == "basketbolcu" && ilk8_basketbolcu <4){
                        check=true;
                        
                        for (int j = 0; j < i; j++) {
                            if(sira[j] == gen_kart){
                                check = false;
                            }
                        }
                        if(check){
                            sira[i] = gen_kart;
                            ilk8_basketbolcu++;
                            System.out.println("2->i:"+i+"sira[i]: "+gen_kart+" Isim:"+Buttons.get(gen_kart).getClientProperty("sporcuIsim").toString()+" Type:"+position +" ilk_8_basketbolcu: "+ilk8_basketbolcu+" ilk_8_futbolcu: "+ilk8_futbolcu);
                            break;
                        }
                    }else{
                        continue;
                    }
                    
                }else{
                    check=true;
                    for (int j = 0; j < i; j++) {
                        if(sira[j] == gen_kart){
                            check = false;
                        }
                    }
                    if(check){
                        sira[i] = gen_kart;
                        System.out.println("3->i:"+i+"sira[i]: "+gen_kart+" Isim:"+Buttons.get(gen_kart).getClientProperty("sporcuIsim").toString()+" Type:"+position +" ilk_8_basketbolcu: "+ilk8_basketbolcu+" ilk_8_futbolcu: "+ilk8_futbolcu);
                        break;
                    }
                }
                
                
            }   
        }

        for(int i=0;i<16;i++){
            if(i<8){
                JButton player_btn = Buttons.get(sira[i]);
                final ArrayList<JButton> buttons = Buttons;
                Buttons.get(sira[i]).addActionListener((ActionEvent e) ->{center.get(3).removeAll();
                String playerType = player_btn.getClientProperty("playerType").toString();
                    if(playerType != LastPlayerType){
                        savas(player_btn,center,buttons,panels);
                    }
                });
                panels.get(3).add(Buttons.get(sira[i]));
            }else if( i>=8 && i<16){
                computer1_cards.add(Buttons.get(sira[i]));
                String WarCard1_Name = Buttons.get(i).getClientProperty("sporcuIsim").toString();
                //System.out.println(WarCard1_Name+": "+i);
                Buttons.get(sira[i]).setIcon(icon);
                panels.get(1).add(Buttons.get(sira[i]));
            }
        }
        
    }
   

}
