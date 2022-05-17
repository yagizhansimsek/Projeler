package prolab;
public class MuhammedSalah extends Sporcu {

	int sporcuPuani = 0;
        int penalti=0;
        int serbestAtis=0;
        int kaleciKarsiKarsiya=0;
	boolean kartKullanildiMi = false;

	public int getsporcuPuani() {
		return sporcuPuani;
	}
        

	public void setsporcuPuani(int sporcuPuani) {
		this.sporcuPuani = sporcuPuani;
	}

	public MuhammedSalah() {
		super();
                this.sporcuIsim = "Muhammed Salah ";
                this.sporcuTakim = "Livirpool ";
                this.fileName = "fms.png";
		this.sporcuPuani = 86;
                this.penalti =85;
                this.serbestAtis =85;
                this.kaleciKarsiKarsiya=90;
	}

	public MuhammedSalah(String futbolcuAdi, String futbolcuTakim,String fileName,int sporcuPuani) {
		super(futbolcuAdi, futbolcuTakim,fileName,sporcuPuani);
	}

        public int getPenalti() {
            return penalti;
        }

        public int getSerbestAtis() {
            return serbestAtis;
        }

        public void setPenalti(int penalti) {
            this.penalti = penalti;
        }

        public void setSerbestAtis(int serbestAtis) {
            this.serbestAtis = serbestAtis;
        }

        public void setKaleciKarsiKarsiya(int kaleciKarsiKarsiya) {
            this.kaleciKarsiKarsiya = kaleciKarsiKarsiya;
        }

        public int getKaleciKarsiKarsiya() {
            return kaleciKarsiKarsiya;
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
