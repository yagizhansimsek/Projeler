package prolab;
public class SergioRamos extends Sporcu {

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

	public SergioRamos() {
		super();
                this.sporcuIsim = "Sergio Ramos ";
                this.sporcuTakim = "Real Madrid ";
                this.fileName = "fsr.png";
		this.sporcuPuani = 80;
                this.penalti =80;
                this.serbestAtis =80;
                this.kaleciKarsiKarsiya=80;
	}

	public SergioRamos(String futbolcuAdi, String futbolcuTakim,String fileName,int sporcuPuani) {
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
