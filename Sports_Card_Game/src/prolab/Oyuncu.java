package prolab;

import java.util.ArrayList;
import javax.swing.JButton;


public abstract class Oyuncu {
        ArrayList<JButton> kartListesi;
        String oyuncuID;
        String oyuncuAdi;
        
        int Skor=0;
        
        public String getoyuncuAdi() {
                return oyuncuAdi;
        }
        public void setoyuncuAdi(String playerName) {
                oyuncuAdi = playerName;
        }
        public String getoyuncuID() {
                return oyuncuID;
        }
        public void setoyuncuID(String playerID) {
                oyuncuID = playerID;
        }
        public int getScore() {
                return Skor;
        }
        public void setScore(int Skor) {
                this.Skor = Skor;
        }

        public ArrayList<JButton> getKartListesi() {
            return kartListesi;
        }

        public void setKartListesi(ArrayList<JButton> kartListesi) {
            this.kartListesi = kartListesi;
        }

        public Oyuncu(String oyuncuID, String oyuncuAdi,int Skor) {
		this.oyuncuID = oyuncuID;
		this.oyuncuAdi = oyuncuAdi;
                this.Skor = Skor;
	}

	public Oyuncu() {
		this.oyuncuID = "Bilinmeyen";
		this.oyuncuAdi = "Bilinmeyen";
	}
        
        public void SkorGoster() {
		System.out.println();
	}
        
        public int kartSec(){
            return 0;
        }
}
