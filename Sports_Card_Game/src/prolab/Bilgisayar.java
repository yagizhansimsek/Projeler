package prolab;

import java.util.ArrayList;
import javax.swing.JButton;


public class Bilgisayar extends Oyuncu{
    
        public Bilgisayar() {
            super();
            this.kartListesi = new ArrayList<JButton>();
            this.oyuncuID = "1 ";
            this.oyuncuAdi = "Bilgisayar ";
            this.Skor = 0;
	}

	public Bilgisayar(String oyuncuID, String oyuncuAdi,int Skor) {
		super(oyuncuID, oyuncuAdi,Skor);
	}

        
        @Override
	public int kartSec() {
		// TODO Auto-generated method stub
		//super.sporcuPuani_Goster();
                return 0;
	}
}
