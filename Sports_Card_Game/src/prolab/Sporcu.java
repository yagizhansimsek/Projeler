package prolab;
public class Sporcu {

	String sporcuIsim;
        String sporcuTakim;
        String fileName;
        int sporcuPuani = 0;

	public Sporcu(String sporcuIsim, String sporcuTakim,String fileName,int sporcuPuani) {
		this.sporcuIsim = sporcuIsim;
		this.sporcuTakim = sporcuTakim;
                this.fileName = fileName;
                this.sporcuPuani = sporcuPuani;
	}

	public Sporcu() {
		this.sporcuIsim = "Bilinmeyen";
		this.sporcuTakim = "Bilinmeyen";
	}

	public String getsporcuIsim() {
		return sporcuIsim;
	}
                
        public String getsporcuTakim() {
		return sporcuTakim;
	}

	public void setsporcuIsim(String sporcuIsim) {
		this.sporcuIsim = sporcuIsim;
	}

	public void setsporcuTakim(String sporcuTakim) {
		this.sporcuTakim = sporcuTakim;
	}

        public void setFileName(String fileName) {
		this.fileName = fileName;
	}
        public String getFileName() {
		return fileName;
	}
        
        public void setsporcuPuani(int sporcuPuani) {
		this.sporcuPuani = sporcuPuani;
	}
        public int getsporcuPuani() {
		return sporcuPuani;
	}
        
        
        public void sporcuPuani_Goster() {
		System.out.println();
	}
}
