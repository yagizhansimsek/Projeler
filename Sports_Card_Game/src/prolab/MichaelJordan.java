package prolab;
public class MichaelJordan extends Sporcu {

	int sporcuPuani = 0;
        int ikilik=0;
        int ucluk=0;
        int serbestAtis=0;
	boolean kartKullanildiMi = false;

	public int getsporcuPuani() {
		return sporcuPuani;
	}
        

	public void setsporcuPuani(int sporcuPuani) {
		this.sporcuPuani = sporcuPuani;
	}

	public MichaelJordan() {
		super();
                this.sporcuIsim = "Michael Jordan ";
                this.sporcuTakim = "Bulls ";
                this.fileName = "bmj.png";
		this.sporcuPuani = 95;
                this.ikilik =90;
                this.serbestAtis =90;
                this.ucluk=100;
	}

	public MichaelJordan(String basketbolcuAdi, String basketbolcuTakim,String fileName,int sporcuPuani) {
		super(basketbolcuAdi, basketbolcuTakim,fileName,sporcuPuani);
	}

        public int getPenalti() {
            return ikilik;
        }

        public int getSerbestAtis() {
            return serbestAtis;
        }

        public void setPenalti(int ikilik) {
            this.ikilik = ikilik;
        }

        public void setSerbestAtis(int serbestAtis) {
            this.serbestAtis = serbestAtis;
        }

        public void setKaleciKarsiKarsiya(int ucluk) {
            this.ucluk = ucluk;
        }

        public int getKaleciKarsiKarsiya() {
            return ucluk;
        }

        @Override
	public void sporcuPuani_Goster() {
		// TODO Auto-generated method stub
		super.sporcuPuani_Goster();
	}

	public void UsedThisCard() {
		if (kartKullanildiMi == true) {
			System.out.println("This Card Used!");
		} else {
			System.out.println("This Card did not used!");
		}
	}
}
