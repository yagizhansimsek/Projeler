package prolab;

import java.util.ArrayList;
import javax.swing.JButton;


public class Kullanıcı extends Oyuncu{
    
        public Kullanıcı() {
            super();
            this.kartListesi = new ArrayList<JButton>();
            this.oyuncuID = "2 ";
            this.oyuncuAdi = "Kullancıı ";
            this.Skor = 0;
	}

	public Kullanıcı(String oyuncuID, String oyuncuAdi,int Skor) {
		super(oyuncuID, oyuncuAdi,Skor);
	}

        
        @Override
	public int kartSec() {
		// TODO Auto-generated method stub
		//super.sporcuPuani_Goster();
                return 0;
	}
}
