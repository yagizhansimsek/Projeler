package prolab;
import java.awt.*;
import java.awt.event.ActionEvent;
import javax.swing.*;

public class MainPage extends JFrame{
    
    int ScreenWidth=300;
    int ScreenHeight=300;

    public MainPage(){
        ImageIcon icon = new ImageIcon( System.getProperty("user.dir")+"\\src\\prolab\\documents\\football.png");
        JPanel panel = new JPanel();
        panel.setBackground(Color.white);
        getContentPane().add(panel);
        panel.setLayout(new GridBagLayout());
        
        GridBagConstraints gbc = new GridBagConstraints();
        gbc.gridwidth = GridBagConstraints.REMAINDER;
        gbc.anchor = GridBagConstraints.NORTH;
        
        gbc.anchor = GridBagConstraints.CENTER;
        gbc.fill = GridBagConstraints.HORIZONTAL;
        

        anasayfa(panel,gbc);
        setBackground(Color.black);
        setTitle("Sporcu Kart Oyunu");
        setSize(ScreenWidth,ScreenHeight);
        setLocationRelativeTo(null);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setIconImage(icon.getImage());
        
    }
    
    public void  anasayfa(JPanel panel,GridBagConstraints gbc){
        JButton btn1 = new JButton("Oyuna Başla");
        btn1.setBackground(Color.BLACK);
        btn1.setForeground(Color.WHITE);
        JButton btn2 = new JButton("Çıkış");
        btn2.setBackground(Color.BLACK);
        btn2.setForeground(Color.WHITE);
        
        btn1.addActionListener((ActionEvent e) -> {
            setVisible(false);
            GameArena game = new  GameArena();
            game.setVisible(true);
        });
        
        panel.add(new JLabel("<html><font size='6' color='green'>Sporcu Kart</font><font size='6' color='black'> Oyunu</font><br/><br/></html>"),gbc);
        panel.add(btn1,gbc);
        panel.add(new JLabel("<html><br/></html>"),gbc);
        panel.add(btn2,gbc);


    }
   
    public static void main(String[] args) {
        SwingUtilities.invokeLater(new Runnable() {

            @Override
            public void run() {
               MainPage gui = new MainPage();
               gui.setVisible(true);
        }
        });
    }
}
