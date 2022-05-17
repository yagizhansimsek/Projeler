package yazlab.pkg1;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import javax.swing.*;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Random;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.util.concurrent.TimeUnit;
import static javafx.application.Platform.exit;

class StartGame extends Thread {

    public int DefaultMovement = 3;
    public int DefaultGold = 200;

    public float M = 20; // Sağ-Sol X Ekseni
    public float N = 20;  // Yukarı-Aşağı Y Ekseni
    public String MainPath = "D:\\Projects\\Yazlab-1\\Yazlab-1\\";
    public int Mode = 1;
    public Icon charachterA = new ImageIcon(MainPath + "CharacterA.png");
    public int[] PositionA = {1, 1};
    public int[] PredictedNGA = {0, 0};
    public int[] PropertyA = {5, 5};
    public int TotalGoldA = DefaultGold;
    public int RewardGoldA = 0;
    public int SpendGoldA = 0;
    public int MovementCountA = 0;
    public String TxtA = MainPath + "PlayerA.txt";

    public Icon charachterB = new ImageIcon(MainPath + "CharacterB.png");
    public int[] PositionB = {1, (int) N};
    public int[] PredictedNGB = {0, 0};
    public int[] PropertyB = {5, 10};
    public int TotalGoldB = DefaultGold;
    public int RewardGoldB = 0;
    public int SpendGoldB = 0;
    public int MovementCountB = 0;
    public String TxtB = MainPath + "PlayerB.txt";

    public Icon charachterC = new ImageIcon(MainPath + "CharacterC.png");
    public int[] PositionC = {(int) M, 1};
    public int[] PredictedNGC = {0, 0};
    public int[] PropertyC = {5, 15};
    public int SuperModeArea = 3;
    public int TotalGoldC = DefaultGold;
    public int RewardGoldC = 0;
    public int SpendGoldC = 0;
    public int MovementCountC = 0;
    public String TxtC = MainPath + "PlayerC.txt";

    public Icon charachterD = new ImageIcon(MainPath + "CharacterD.png");
    public int[] PositionD = {(int) M, (int) N};
    public int[] PropertyD = {5, 20};
    public int TotalGoldD = DefaultGold;
    public int RewardGoldD = 0;
    public int SpendGoldD = 0;
    public int MovementCountD = 0;
    public String TxtD = MainPath + "PlayerD.txt";

    Icon icon = new ImageIcon(MainPath + "GameGold.png");
    public int HamleSirasi = 1;
    public int TotalSecretGold = 0;
    public JLabel ScoreBoardA, ScoreBoardB, ScoreBoardC, ScoreBoardD;
    Integer[][] EditedGold, EditedSGold;
    int KalanAltin = 0;
    ArrayList<JButton> GameArea;

    public File playerA, playerB, playerC, playerD;
    public FileWriter AFW, BFW, CFW, DFW;
    public BufferedWriter ABW, BBW, CBW, DBW;

    static Integer[][] addElement(Integer[][] a, Integer[] e) {
        //System.out.println(e[0]+" "+e[1]);
        Integer[][] newArray = new Integer[a.length + 1][3];
        for (int i = 0; i < a.length; i++) {
            newArray[i] = a[i];
            //System.out.println(newArray[i][0]+" "+newArray[i][1]);
        }
        newArray[newArray.length - 1][0] = e[0];
        newArray[newArray.length - 1][1] = e[1];
        newArray[newArray.length - 1][2] = e[2];
        System.out.println(newArray[newArray.length - 1][0] + " " + newArray[newArray.length - 1][1] + " " + newArray[newArray.length - 1][2]);
        return newArray;
    }

    public StartGame(Integer[][] EditedGold, Integer[][] EditedSGold, ArrayList<JButton> GameArea, JLabel ScoreBoardA, JLabel ScoreBoardB, JLabel ScoreBoardC, JLabel ScoreBoardD, int DeftMovement, int DeftMovementPrice, int ANTPrice, int BNTPrice, int CNTPRice, int DNTPrice, int CSuperMode, int DGold, float M, float N) throws IOException {
        this.DefaultMovement = DeftMovement;

        this.PropertyA[0] = DeftMovementPrice;
        this.PropertyA[1] = ANTPrice;

        this.PropertyB[0] = DeftMovementPrice;
        this.PropertyB[1] = BNTPrice;

        this.PropertyC[0] = DeftMovementPrice;
        this.PropertyC[1] = CNTPRice;

        this.PropertyD[0] = DeftMovementPrice;
        this.PropertyD[1] = DNTPrice;

        this.SuperModeArea = CSuperMode;
        this.DefaultGold = DGold;

        this.M = M;
        this.N = N;

        this.EditedGold = EditedGold;
        this.EditedSGold = EditedSGold;
        this.GameArea = GameArea;

        this.ScoreBoardA = ScoreBoardA;
        this.ScoreBoardB = ScoreBoardB;
        this.ScoreBoardC = ScoreBoardC;
        this.ScoreBoardD = ScoreBoardD;

        KalanAltin = this.EditedGold.length + this.EditedSGold.length;
        TotalSecretGold = EditedSGold.length;

        File playerB = new File(TxtB);

        File playerC = new File(TxtC);

        File playerD = new File(TxtD);
    }

    public void isAnyCharachterInOldPosition(int[] OldPosition) {
        if (HamleSirasi != 1 && PositionA[0] == OldPosition[0] && PositionA[1] == OldPosition[1]) {
            GameArea.get((OldPosition[1] - 1) + (OldPosition[0] - 1) * (int) M).setIcon(charachterA);
        }

        if (HamleSirasi != 2 && PositionB[0] == OldPosition[0] && PositionB[1] == OldPosition[1]) {
            GameArea.get((OldPosition[1] - 1) + (OldPosition[0] - 1) * (int) M).setIcon(charachterB);
        }

        if (HamleSirasi != 3 && PositionC[0] == OldPosition[0] && PositionC[1] == OldPosition[1]) {
            GameArea.get((OldPosition[1] - 1) + (OldPosition[0] - 1) * (int) M).setIcon(charachterC);
        }

        if (HamleSirasi != 4 && PositionD[0] == OldPosition[0] && PositionD[1] == OldPosition[1]) {
            GameArea.get((OldPosition[1] - 1) + (OldPosition[0] - 1) * (int) M).setIcon(charachterD);
        }
    }

    public void isAnyNormalGoldInOldPositon(int[] OldPosition, int[] NewPosition) {
        for (int i = 0; i < EditedGold.length; i++) {
            if (EditedGold[i][0] == OldPosition[0] && EditedGold[i][1] == OldPosition[1] && OldPosition != NewPosition) {
                //System.out.println("Girdim-Ben");
                GameArea.get((OldPosition[1] - 1) + (OldPosition[0] - 1) * (int) M).setIcon(icon);
            }
        }
    }

    public static Integer[][] removeElement(Integer[][] arr, int index) {
        if (arr == null
                || index < 0
                || index >= arr.length) {

            return arr;
        }

        Integer[][] anotherArray = new Integer[arr.length - 1][];

        for (int i = 0, k = 0; i < arr.length; i++) {

            if (i == index) {
                continue;
            }

            anotherArray[k++] = arr[i];
        }

        return anotherArray;
    }

    public boolean CheckSecretGold(int[] Position, int Mode) { //Mode-> 0 Normal Mpde -> 1 C Charachter Mode
        System.out.println(Position[0] + "--" + Position[1]);
        if (Mode == 0) {
            for (int i = 0; i < EditedSGold.length; i++) {
                //System.out.println("EditSGoldLength:" + EditedSGold.length);
                if (Position[0] == EditedSGold[i][0] && Position[1] == EditedSGold[i][1]) {
                    if (EditedSGold[i][0] != null && EditedSGold[i][1] != null) {
                        //System.out.println(EditedSGold[i][0] + " " + EditedSGold[i][1] + " " + EditedSGold[i][2]);
                        EditedGold = addElement(EditedGold, EditedSGold[i]);
                        EditedSGold = removeElement(EditedSGold, i);
                        return true;
                    }
                }
            }
        } else if (Mode == 1) {
            boolean status;
            //System.out.println("["+Position[0]+","+Position[1]+"]\n");
            /*for (int l = 0; l < EditedSGold.length; l++) {
                            System.out.print("{"+EditedSGold[l][0]+","+EditedSGold[l][1]+"}-");
                        }*/
            for (int j = -SuperModeArea; j <= SuperModeArea; j++) {
                for (int k = -SuperModeArea; k <= SuperModeArea; k++) {
                    for (int i = 0; i < EditedSGold.length; i++) {
                        if (EditedSGold[i][0] != null && EditedSGold[i][1] != null) {
                            int AreaX = Position[0] + k;
                            int AreaY = Position[1] + j;
                            if (AreaX == EditedSGold[i][0] && AreaY == EditedSGold[i][1]) {
                                //System.out.println("GG:"+EditedSGold[i][0]+" "+EditedSGold[i][1]+" "+EditedSGold[i][2]);

                                EditedGold = addElement(EditedGold, EditedSGold[i]);

                                EditedSGold = removeElement(EditedSGold, i);

                                for (int l = 0; l < EditedSGold.length; l++) {
                                    //System.out.println("EditSGoldLength:" + EditedSGold.length);
                                    //System.out.println("Secret Gold:" + EditedSGold[l][0] + "-" + EditedSGold[l][1]);
                                }

                                Icon icon = new ImageIcon(MainPath + "GameGold.png");
                                GameArea.get((AreaY - 1) + (AreaX - 1) * (int) M).setIcon(icon);
                            }
                        }
                    }
                }
            }
            //System.out.println("\n");
            return false;
        }
        //}
        return false;
    }

    public void Movement(int[] Position, int[] NewPosition, Icon character, int Mode, File player) {
        System.out.println(Position[0] + " " + Position[1]);
        boolean IsSercetGold = false;
        int[] OldPosition = new int[2];

        while (Position[0] != NewPosition[0]) {
            System.out.println("Sağ-Sol");

            try {
                Thread.sleep(500);
            } catch (InterruptedException ex) {
                Logger.getLogger(Game.class.getName()).log(Level.SEVERE, null, ex);
            }

            if (Position[0] < NewPosition[0] && Position[0] <= M) {

                //((PositionA[0]-1)*M+(PositionA[1]-1)+1)
                GameArea.get(((Position[0] - 1) * (int) M + (Position[1] - 1))).setIcon(null);
                if (IsSercetGold) {
                    IsSercetGold = false;
                    GameArea.get((EditedGold[EditedGold.length - 1][1] - 1) + (EditedGold[EditedGold.length - 1][0] - 1) * (int) M).setIcon(icon);
                } else {
                    isAnyNormalGoldInOldPositon(OldPosition, NewPosition);
                    isAnyCharachterInOldPosition(OldPosition);

                }
                OldPosition = Position;
                try (BufferedWriter br = new BufferedWriter(new FileWriter(player, true))) {
                    br.write("(" + Position[0] + "," + Position[1] + ")");
                    br.newLine();
                } catch (IOException e) {
                    System.out.println("Unable to read file " + player.toString());
                }
                Position[0] += 1;
                System.out.println(Position[0] + " " + Position[1]);
                GameArea.get(((Position[0] - 1) * (int) M + (Position[1] - 1))).setIcon(character);
                boolean result = CheckSecretGold(Position, 0);
                if (result == true) {
                    IsSercetGold = true;

                }
            } else if (Position[0] > NewPosition[0] && Position[0] > 0) {
                GameArea.get(((Position[0] - 1) * (int) M + (Position[1] - 1))).setIcon(null);
                if (IsSercetGold) {
                    IsSercetGold = false;
                    GameArea.get((EditedGold[EditedGold.length - 1][1] - 1) + (EditedGold[EditedGold.length - 1][0] - 1) * (int) M).setIcon(icon);
                } else {
                    isAnyNormalGoldInOldPositon(OldPosition, NewPosition);
                    isAnyCharachterInOldPosition(OldPosition);

                }
                OldPosition = Position;
                Position[0] -= 1;
                System.out.println(Position[0] + " " + Position[1]);
                try (BufferedWriter br = new BufferedWriter(new FileWriter(player, true))) {
                    br.write("(" + Position[0] + "," + Position[1] + ")");
                    br.newLine();
                } catch (IOException e) {
                    System.out.println("Unable to read file " + player.toString());
                }
                GameArea.get(((Position[0] - 1) * (int) M + (Position[1] - 1))).setIcon(character);
                boolean result = CheckSecretGold(Position, 0);
                if (result == true) {
                    IsSercetGold = true;
                }
            }
        }

        while (Position[1] != NewPosition[1]) {
            System.out.println("Yukarı-Aşağı");
            try {
                Thread.sleep(500);
            } catch (InterruptedException ex) {
                Logger.getLogger(Game.class.getName()).log(Level.SEVERE, null, ex);
            }

            if (Position[1] < NewPosition[1] && Position[1] % M != 0) { //M*N-1 9 19 29 
                GameArea.get(((Position[0] - 1) * (int) M + (Position[1] - 1))).setIcon(null);
                if (IsSercetGold) {
                    IsSercetGold = false;
                    GameArea.get((EditedGold[EditedGold.length - 1][1] - 1) + (EditedGold[EditedGold.length - 1][0] - 1) * (int) M).setIcon(icon);
                } else {
                    isAnyNormalGoldInOldPositon(OldPosition, NewPosition);
                    isAnyCharachterInOldPosition(OldPosition);

                }
                OldPosition = Position;
                Position[1] += 1;
                System.out.println(Position[0] + " " + Position[1]);
                try (BufferedWriter br = new BufferedWriter(new FileWriter(player, true))) {
                    br.write("(" + Position[0] + "," + Position[1] + ")");
                    br.newLine();
                } catch (IOException e) {
                    System.out.println("Unable to read file " + player.toString());
                }
                GameArea.get(((Position[0] - 1) * (int) M + (Position[1] - 1))).setIcon(character);
                boolean result = CheckSecretGold(Position, 0);
                if (result == true) {
                    IsSercetGold = true;
                }
            } else if (Position[1] > NewPosition[1] && Position[1] % M != M) {
                GameArea.get(((Position[0] - 1) * (int) M + (Position[1] - 1))).setIcon(null);
                if (IsSercetGold) {
                    IsSercetGold = false;
                    GameArea.get((EditedGold[EditedGold.length - 1][1] - 1) + (EditedGold[EditedGold.length - 1][0] - 1) * (int) M).setIcon(icon);
                } else {
                    isAnyNormalGoldInOldPositon(OldPosition, NewPosition);
                    isAnyCharachterInOldPosition(OldPosition);
                }
                OldPosition = Position;
                Position[1] -= 1;
                System.out.println(Position[0] + " " + Position[1]);
                try (BufferedWriter br = new BufferedWriter(new FileWriter(player, true))) {
                    br.write("(" + Position[0] + "," + Position[1] + ")");
                    br.newLine();
                } catch (IOException e) {
                    System.out.println("Unable to read file " + player.toString());
                }
                GameArea.get(((Position[0] - 1) * (int) M + (Position[1] - 1))).setIcon(character);
                boolean result = CheckSecretGold(Position, 0);
                if (result == true) {
                    IsSercetGold = true;
                }
            }
        }

    }

    public int[] Calculate(int CalculateMode, int[] Position) {

        if (CalculateMode == 1) {
            int[] BestGold = new int[3];
            int MinWay = 999999;
            for (int i = 0; i < EditedGold.length; i++) {
                if (EditedGold[i][0] != Position[0] || EditedGold[i][1] != Position[1]) {
                    int Temp = Math.abs(EditedGold[i][0] - Position[0]) + Math.abs(EditedGold[i][1] - Position[1]);
                    if (Temp < MinWay) {
                        MinWay = Temp;
                        BestGold[0] = EditedGold[i][0];
                        BestGold[1] = EditedGold[i][1];
                        BestGold[2] = EditedGold[i][2];
                    }
                }
            }
            return BestGold;
        } else if (CalculateMode == 2) {
            int[] BestGold = new int[3];
            float MaxWin = -999999;

            for (int i = 0; i < EditedGold.length; i++) {
                if (EditedGold[i][0] != Position[0] || EditedGold[i][1] != Position[1]) {
                    float Temp = Math.abs(EditedGold[i][0] - Position[0]) + Math.abs(EditedGold[i][1] - Position[1]);
                    Temp = (float) Math.floor(Temp / DefaultMovement) * PropertyB[0];
                    float Calculated_Temp = EditedGold[i][2] - Temp;
                    //System.out.println(i+":"+Calculated_Temp);
                    if (Calculated_Temp > MaxWin) {
                        MaxWin = Calculated_Temp;
                        BestGold[0] = EditedGold[i][0];
                        BestGold[1] = EditedGold[i][1];
                        BestGold[2] = EditedGold[i][2];
                    }
                }
            }
            //System.out.println("Selected: "+MaxWin);
            return BestGold;
        } else if (CalculateMode == 3) {
            int[] BestGold = new int[2];

            int WayPredictNGA_A = Math.abs(PredictedNGA[0] - PositionA[0]) + Math.abs(PredictedNGA[1] - PositionA[1]);
            int WayPredictNGA_D = Math.abs(PredictedNGA[0] - Position[0]) + Math.abs(PredictedNGA[1] - Position[1]);

            int WayPredictNGB_B = Math.abs(PredictedNGB[0] - PositionB[0]) + Math.abs(PredictedNGB[1] - PositionB[1]);
            int WayPredictNGB_D = Math.abs(PredictedNGB[0] - Position[0]) + Math.abs(PredictedNGB[1] - Position[1]);

            int WayPredictNGC_C = Math.abs(PredictedNGC[0] - PositionC[0]) + Math.abs(PredictedNGC[1] - PositionC[1]);
            int WayPredictNGC_D = Math.abs(PredictedNGC[0] - Position[0]) + Math.abs(PredictedNGC[1] - Position[1]);

            float resultAD = 0;
            float resultBD = 0;
            float resultCD = 0;

            if (WayPredictNGA_D < WayPredictNGA_A) {
                boolean isAvaible = false;
                for (int i = 0; i < EditedGold.length; i++) {
                    if (EditedGold[i][0] == PredictedNGA[0] && EditedGold[i][1] == PredictedNGA[1]) {
                        resultAD = (float) Math.floor(WayPredictNGA_D / DefaultMovement) * PropertyD[0];
                        break;
                    }
                }

                if (isAvaible == false) {
                    resultAD = -1;
                }
            } else {
                resultAD = -1;
            }

            if (WayPredictNGA_D < WayPredictNGB_B) {
                boolean isAvaible = false;
                for (int i = 0; i < EditedGold.length; i++) {
                    if (EditedGold[i][0] == PredictedNGB[0] && EditedGold[i][1] == PredictedNGB[1]) {
                        resultBD = (float) Math.floor(WayPredictNGB_D / DefaultMovement) * PropertyD[0];
                        break;
                    }
                }

                if (isAvaible == false) {
                    resultBD = -1;
                }
            } else {
                resultBD = -1;
            }

            if (WayPredictNGA_D < WayPredictNGC_C) {
                boolean isAvaible = false;
                for (int i = 0; i < EditedGold.length; i++) {
                    if (EditedGold[i][0] != Position[0] || EditedGold[i][1] != Position[1]) {
                        if (EditedGold[i][0] == PredictedNGC[0] && EditedGold[i][1] == PredictedNGC[1]) {
                            resultCD = (float) Math.floor(WayPredictNGC_D / DefaultMovement) * PropertyD[0];
                            break;
                        }
                    }
                }

                if (isAvaible == false) {
                    resultCD = -1;
                }
            } else {
                resultCD = -1;
            }

            if (resultAD != -1 || resultBD != -1 || resultCD != -1) {
                float result = -9999;
                if (result < resultAD) {
                    result = resultAD;
                    BestGold = PredictedNGA;
                }

                if (result < resultBD) {
                    result = resultBD;
                    BestGold = PredictedNGB;
                }

                if (result < resultCD) {
                    result = resultCD;
                    BestGold = PredictedNGC;
                }
            } else {
                BestGold = Calculate(2, Position);
            }
            //System.out.println("Selected: "+MaxWin);
            return BestGold;
        }

        return null;
    }

    public void run() {
        File playerA = new File(TxtA);
        try (BufferedWriter br = new BufferedWriter(new FileWriter(playerA))) {
            br.write("(1,1)");
            br.newLine();
        } catch (IOException e) {
            System.out.println("Unable to read file " + playerA.toString());
        }

        File playerB = new File(TxtB);
        try (BufferedWriter br = new BufferedWriter(new FileWriter(playerB))) {
            br.write("(1," + (int) N + ")");
            br.newLine();
        } catch (IOException e) {
            System.out.println("Unable to read file " + playerB.toString());
        }

        File playerC = new File(TxtC);
        try (BufferedWriter br = new BufferedWriter(new FileWriter(playerC))) {
            br.write("(" + (int) M + ",1)");
            br.newLine();
        } catch (IOException e) {
            System.out.println("Unable to read file " + playerC.toString());
        }

        File playerD = new File(TxtD);
        try (BufferedWriter br = new BufferedWriter(new FileWriter(playerD))) {
            br.write("(" + (int) M + "," + (int) N + ")");
            br.newLine();
        } catch (IOException e) {
            System.out.println("Unable to read file " + playerD.toString());
        }

        int[] BestGoldA = null;
        int[] BestGoldB = null;
        int[] BestGoldC = null;
        int[] BestGoldD = null;

        HamleSirasi = 1;
        while (true) {
            if (TotalGoldA <= 0 && TotalGoldB <= 0 && TotalGoldC <= 0 && TotalGoldD <= 0) {
                System.out.println("Oyun Tamamlanmadı!Kullancıların Altını Bitti");
                String[] PlayerA = new String[]{String.valueOf(TotalGoldA), String.valueOf(MovementCountA), String.valueOf(SpendGoldA), String.valueOf(RewardGoldA)};
                String[] PlayerB = new String[]{String.valueOf(TotalGoldB), String.valueOf(MovementCountB), String.valueOf(SpendGoldB), String.valueOf(RewardGoldB)};
                String[] PlayerC = new String[]{String.valueOf(TotalGoldC), String.valueOf(MovementCountC), String.valueOf(SpendGoldC), String.valueOf(RewardGoldC)};
                String[] PlayerD = new String[]{String.valueOf(TotalGoldD), String.valueOf(MovementCountD), String.valueOf(SpendGoldD), String.valueOf(RewardGoldD)};
                Result resultForm = new Result(PlayerA, PlayerB, PlayerC, PlayerD);
                resultForm.setVisible(true);
                break;
            }

            try {
                Thread.sleep(1000);
            } catch (InterruptedException ex) {
                Logger.getLogger(Game.class.getName()).log(Level.SEVERE, null, ex);
            }
            //System.out.println(EditedGold.length);
            if (HamleSirasi == 1) {
                if (TotalGoldA <= 0) {
                    HamleSirasi = 2;
                    continue;
                }
                if (PredictedNGA[0] == 0 && PredictedNGA[1] == 0) {
                    BestGoldA = Calculate(1, PositionA);
                } else {
                    boolean isAvaible = false;
                    for (int i = 0; i < EditedGold.length; i++) {
                        if (EditedGold[i][0] == PredictedNGA[0] && EditedGold[i][1] == PredictedNGA[1]) {
                            BestGoldA = PredictedNGA;
                            isAvaible = true;
                            break;
                        }
                    }

                    if (isAvaible == false) {
                        BestGoldA = Calculate(1, PositionA);
                    }
                }

                int Temp = Math.abs(BestGoldA[0] - PositionA[0]) + Math.abs(BestGoldA[1] - PositionA[1]);
                MovementCountA += 1;
                float Calculated_Temp = (float) (Math.floor(Temp / DefaultMovement) * PropertyA[0]);
                Calculated_Temp += PropertyA[1];
                RewardGoldA += BestGoldA[2];
                SpendGoldA += Calculated_Temp;

                TotalGoldA = TotalGoldA + BestGoldA[2] - (int) Calculated_Temp;
                //System.out.println("A"+Calculated_Temp+" Reward:"+BestGoldA[2]+" Total:"+TotalGoldA);

                if (EditedGold.length == 0) {
                    String[] PlayerA = new String[]{String.valueOf(TotalGoldA), String.valueOf(MovementCountA), String.valueOf(SpendGoldA), String.valueOf(RewardGoldA)};
                    String[] PlayerB = new String[]{String.valueOf(TotalGoldB), String.valueOf(MovementCountB), String.valueOf(SpendGoldB), String.valueOf(RewardGoldB)};
                    String[] PlayerC = new String[]{String.valueOf(TotalGoldC), String.valueOf(MovementCountC), String.valueOf(SpendGoldC), String.valueOf(RewardGoldC)};
                    String[] PlayerD = new String[]{String.valueOf(TotalGoldD), String.valueOf(MovementCountD), String.valueOf(SpendGoldD), String.valueOf(RewardGoldD)};
                    Result resultForm = new Result(PlayerA, PlayerB, PlayerC, PlayerD);
                    resultForm.setVisible(true);
                    System.out.println("Oyun Bitti!");
                    break;
                }

                ScoreBoardA.setText("A:" + String.valueOf(TotalGoldA));
                //System.out.println(PositionA[0]+"-"+PositionA[1]+"/"+NearestGold[0]+"-"+NearestGold[1]);
                Movement(PositionA, BestGoldA, charachterA, 0, playerA);
                PositionA = BestGoldA;
                for (int i = 0; i < EditedGold.length; i++) {
                    if (EditedGold[i][0] == BestGoldA[0] && EditedGold[i][1] == BestGoldA[1]) {
                        Integer[][] copyArray = new Integer[EditedGold.length - 1][];
                        System.arraycopy(EditedGold, 0, copyArray, 0, i);
                        System.arraycopy(EditedGold, i + 1, copyArray, i, EditedGold.length - i - 1);
                        EditedGold = copyArray;
                    }
                }
                PredictedNGA = Calculate(1, PositionA);

                HamleSirasi = 2;
            } else if (HamleSirasi == 2) {
                if (TotalGoldB <= 0) {
                    HamleSirasi = 3;
                    continue;
                }
                if (PredictedNGB[0] == 0 && PredictedNGB[1] == 0) {
                    BestGoldB = Calculate(2, PositionB);
                } else {
                    boolean isAvaible = false;
                    for (int i = 0; i < EditedGold.length; i++) {
                        if (EditedGold[i][0] == PredictedNGB[0] && EditedGold[i][1] == PredictedNGB[1]) {
                            BestGoldB = PredictedNGB;
                            isAvaible = true;
                            break;
                        }
                    }

                    if (isAvaible == false) {
                        BestGoldB = Calculate(2, PositionB);
                    }
                }

                int Temp = Math.abs(BestGoldB[0] - PositionB[0]) + Math.abs(BestGoldB[1] - PositionB[1]);
                MovementCountB += 1;
                float Calculated_Temp = (float) (Math.floor(Temp / DefaultMovement) * PropertyB[0]);
                Calculated_Temp += PropertyB[1];
                RewardGoldB += BestGoldB[2];
                TotalGoldB = TotalGoldB + BestGoldB[2] - (int) Calculated_Temp;
                SpendGoldB += Calculated_Temp;
                //System.out.println("B"+Calculated_Temp+" Reward:"+BestGoldB[2]+" Total:"+TotalGoldB);

                if (EditedGold.length == 0) {
                    String[] PlayerA = new String[]{String.valueOf(TotalGoldA), String.valueOf(MovementCountA), String.valueOf(SpendGoldA), String.valueOf(RewardGoldA)};
                    String[] PlayerB = new String[]{String.valueOf(TotalGoldB), String.valueOf(MovementCountB), String.valueOf(SpendGoldB), String.valueOf(RewardGoldB)};
                    String[] PlayerC = new String[]{String.valueOf(TotalGoldC), String.valueOf(MovementCountC), String.valueOf(SpendGoldC), String.valueOf(RewardGoldC)};
                    String[] PlayerD = new String[]{String.valueOf(TotalGoldD), String.valueOf(MovementCountD), String.valueOf(SpendGoldD), String.valueOf(RewardGoldD)};
                    Result resultForm = new Result(PlayerA, PlayerB, PlayerC, PlayerD);
                    resultForm.setVisible(true);
                    System.out.println("Oyun Bitti!");
                    break;
                }

                ScoreBoardB.setText("B:" + String.valueOf(TotalGoldB));
                //System.out.println(PositionA[0]+"-"+PositionA[1]+"/"+NearestGold[0]+"-"+NearestGold[1]);
                Movement(PositionB, BestGoldB, charachterB, 0, playerB);
                PositionB = BestGoldB;
                for (int i = 0; i < EditedGold.length; i++) {
                    if (EditedGold[i][0] == BestGoldB[0] && EditedGold[i][1] == BestGoldB[1]) {
                        Integer[][] copyArray = new Integer[EditedGold.length - 1][];
                        System.arraycopy(EditedGold, 0, copyArray, 0, i);
                        System.arraycopy(EditedGold, i + 1, copyArray, i, EditedGold.length - i - 1);
                        EditedGold = copyArray;
                    }
                }
                //System.out.println("GoldLength:" + EditedGold.length);
                PredictedNGB = Calculate(2, PositionB);
                /*System.out.print(PositionB[0] + "," + PositionB[1] + "-");
                System.out.print(PredictedNGB[0] + "," + PredictedNGB[1] + "(B)-P ");
                for (int i = 0; i < EditedGold.length; i++) {
                    System.out.print("(" + EditedGold[i][0] + "," + EditedGold[i][1] + ") ");
                }
                System.out.println("");*/
                HamleSirasi = 3;
            } else if (HamleSirasi == 3) {
                if (TotalGoldC <= 0) {
                    HamleSirasi = 4;
                    continue;
                }

                boolean result = CheckSecretGold(PositionC, 1);
                if (PredictedNGC[0] == 0 && PredictedNGC[1] == 0) {
                    BestGoldC = Calculate(2, PositionC);

                } else {
                    boolean isAvaible = false;
                    for (int i = 0; i < EditedGold.length; i++) {
                        if (EditedGold[i][0] == PredictedNGC[0] && EditedGold[i][1] == PredictedNGC[1]) {
                            BestGoldC = PredictedNGC;
                            isAvaible = true;
                            break;
                        }
                    }

                    if (isAvaible == false) {
                        BestGoldC = Calculate(2, PositionC);
                    }
                }

                int Temp = Math.abs(BestGoldC[0] - PositionC[0]) + Math.abs(BestGoldC[1] - PositionC[1]);
                MovementCountC += 1;
                float Calculated_Temp = (float) (Math.floor(Temp / DefaultMovement) * PropertyC[0]);
                Calculated_Temp += PropertyC[1];
                RewardGoldC += BestGoldC[2];
                TotalGoldC = TotalGoldC + BestGoldC[2] - (int) Calculated_Temp;
                SpendGoldC += Calculated_Temp;
                //System.out.println("C"+Calculated_Temp+" Reward:"+BestGoldC[2]+" Total:"+TotalGoldC);

                if (EditedGold.length == 0) {
                    String[] PlayerA = new String[]{String.valueOf(TotalGoldA), String.valueOf(MovementCountA), String.valueOf(SpendGoldA), String.valueOf(RewardGoldA)};
                    String[] PlayerB = new String[]{String.valueOf(TotalGoldB), String.valueOf(MovementCountB), String.valueOf(SpendGoldB), String.valueOf(RewardGoldB)};
                    String[] PlayerC = new String[]{String.valueOf(TotalGoldC), String.valueOf(MovementCountC), String.valueOf(SpendGoldC), String.valueOf(RewardGoldC)};
                    String[] PlayerD = new String[]{String.valueOf(TotalGoldD), String.valueOf(MovementCountD), String.valueOf(SpendGoldD), String.valueOf(RewardGoldD)};
                    Result resultForm = new Result(PlayerA, PlayerB, PlayerC, PlayerD);
                    resultForm.setVisible(true);
                    System.out.println("Oyun Bitti!");
                    break;
                }

                ScoreBoardC.setText("C:" + String.valueOf(TotalGoldC));
                //System.out.println(PositionA[0]+"-"+PositionA[1]+"/"+NearestGold[0]+"-"+NearestGold[1]);
                Movement(PositionC, BestGoldC, charachterC, 1, playerC);
                PositionC = BestGoldC;
                for (int i = 0; i < EditedGold.length; i++) {
                    if (EditedGold[i][0] == BestGoldC[0] && EditedGold[i][1] == BestGoldC[1]) {
                        Integer[][] copyArray = new Integer[EditedGold.length - 1][];
                        System.arraycopy(EditedGold, 0, copyArray, 0, i);
                        System.arraycopy(EditedGold, i + 1, copyArray, i, EditedGold.length - i - 1);
                        EditedGold = copyArray;
                    }
                }
                //System.out.println("GoldLength:" + EditedGold.length);
                PredictedNGC = Calculate(2, PositionC);
                /*System.out.print(PositionC[0] + "," + PositionC[1] + "-");
                System.out.print(PredictedNGC[0] + "," + PredictedNGC[1] + "(C)-P ");
                for (int i = 0; i < EditedGold.length; i++) {
                    System.out.print("(" + EditedGold[i][0] + "," + EditedGold[i][1] + ") ");
                }
                System.out.println("");*/
                HamleSirasi = 4;
            } else if (HamleSirasi == 4) {
                if (TotalGoldD <= 0) {
                    HamleSirasi = 1;
                    continue;
                }

                BestGoldD = Calculate(3, PositionD);

                /*System.out.print(BestGoldD[0] + "," + BestGoldD[1] + "(D)-N ");
                for (int i = 0; i < EditedGold.length; i++) {
                    System.out.print("(" + EditedGold[i][0] + "," + EditedGold[i][1] + ") ");
                }
                System.out.println("");*/
                int Temp = Math.abs(BestGoldD[0] - PositionD[0]) + Math.abs(BestGoldD[1] - PositionD[1]);
                MovementCountD += 1;
                float Calculated_Temp = (float) (Math.floor(Temp / DefaultMovement) * PropertyD[0]);
                Calculated_Temp += PropertyD[1];
                RewardGoldD += BestGoldD[2];
                TotalGoldD = TotalGoldD + BestGoldD[2] - (int) Calculated_Temp;
                SpendGoldD += Calculated_Temp;
                //System.out.println("D"+Calculated_Temp+" Reward:"+BestGoldD[2]+" Total:"+TotalGoldD);

                if (EditedGold.length == 0) {
                    String[] PlayerA = new String[]{String.valueOf(TotalGoldA), String.valueOf(MovementCountA), String.valueOf(SpendGoldA), String.valueOf(RewardGoldA)};
                    String[] PlayerB = new String[]{String.valueOf(TotalGoldB), String.valueOf(MovementCountB), String.valueOf(SpendGoldB), String.valueOf(RewardGoldB)};
                    String[] PlayerC = new String[]{String.valueOf(TotalGoldC), String.valueOf(MovementCountC), String.valueOf(SpendGoldC), String.valueOf(RewardGoldC)};
                    String[] PlayerD = new String[]{String.valueOf(TotalGoldD), String.valueOf(MovementCountD), String.valueOf(SpendGoldD), String.valueOf(RewardGoldD)};
                    Result resultForm = new Result(PlayerA, PlayerB, PlayerC, PlayerD);
                    resultForm.setVisible(true);
                    System.out.println("Oyun Bitti!");
                    break;
                }

                ScoreBoardD.setText("D:" + String.valueOf(TotalGoldD));
                //System.out.println(PositionA[0]+"-"+PositionA[1]+"/"+NearestGold[0]+"-"+NearestGold[1]);
                Movement(PositionD, BestGoldD, charachterD, 0, playerD);

                PositionD = BestGoldD;
                for (int i = 0; i < EditedGold.length; i++) {
                    if (EditedGold[i][0] == BestGoldD[0] && EditedGold[i][1] == BestGoldD[1]) {
                        Integer[][] copyArray = new Integer[EditedGold.length - 1][];
                        System.arraycopy(EditedGold, 0, copyArray, 0, i);
                        System.arraycopy(EditedGold, i + 1, copyArray, i, EditedGold.length - i - 1);
                        EditedGold = copyArray;
                    }
                }
                //System.out.println("GoldLength:" + EditedGold.length);
                HamleSirasi = 1;
            }
        }
    }

}

public class Game extends Thread {

    public static float M = 10; // Sağ-Sol X Ekseni
    public static float N = 10;  // Yukarı-Aşağı Y Ekseni
    public static float AltinOrani = 20;
    public static float GizliAltinOrani = 10;
    public static int ScreenWidth = 0;
    public static int ScreenHeight = 0;
    public static Integer[] Altinlar;
    public static Integer[] Gizli_Altinlar;

    public static Integer[][] EditedGold;
    public static Integer[][] EditedSGold;
    public static ArrayList<JButton> GameArea;

    public static String MainPath = "D:\\Projects\\Yazlab-1\\Yazlab-1\\";

    public static JLabel ScoreBoardA, ScoreBoardB, ScoreBoardC, ScoreBoardD;
    public static int DefaultGold = 200;

    public static int DeftMovement = 3;
    public static int DeftMovementPrice = 5;
    public static int ANTPrice = 20;
    public static int BNTPrice = 10;
    public static int CNTPrice = 3;
    public static int DNTPrice = 5;
    public static int CSuperMode = 3;
    public static int DGold;

    public void SetSettings(int[] GameArea, int GoldRate, int SecretGoldRate, int DeftMovement, int DeftMovementPrice, int ANTPrice, int BNTPrice, int CNTPRice, int DNTPrice, int CSuperMode, int DGold) {
        this.M = GameArea[0];
        this.N = GameArea[1];
        this.AltinOrani = GoldRate;
        this.GizliAltinOrani = SecretGoldRate;

        this.DeftMovement = DeftMovement;
        this.DeftMovementPrice = DeftMovementPrice;
        this.ANTPrice = ANTPrice;
        this.BNTPrice = BNTPrice;
        this.CNTPrice = CNTPRice;
        this.DNTPrice = DNTPrice;
        this.CSuperMode = CSuperMode;
        this.DGold = DGold;

        Altinlar = new Integer[(int) (M * N / 100 * AltinOrani)];
        Gizli_Altinlar = new Integer[(int) (M * N / 100 * AltinOrani / 100 * GizliAltinOrani)];

        EditedGold = new Integer[Altinlar.length][3];
        EditedSGold = new Integer[Gizli_Altinlar.length][3];
    }

    public static void Start() {
        int[] PositionA = {1, 1};
        int[] PositionB = {1, (int) N};
        int[] PositionC = {(int) M, 1};
        int[] PositionD = {(int) M, (int) N};

        ArrayList<JButton> GameArea = new ArrayList<JButton>();
        //System.out.println(Gizli_Altinlar.length);
        int bulunan = 0;
        Random rand = new Random();

        while (bulunan != M * N / 100 * AltinOrani) {
            boolean tryagain = false;
            int random = rand.nextInt((int) M * (int) N);
            for (int i = 0; i < bulunan; i++) {
                if (Altinlar[i] == random) {
                    tryagain = true;
                    break;
                }
            }

            if (tryagain == true || random == ((PositionA[0] - 1) * M + (PositionA[1] - 1) + 1) || random == ((PositionB[0] - 1) * M + (PositionB[1] - 1) + 1) || random == ((PositionC[0] - 1) * M + (PositionC[1] - 1) + 1) || random == ((PositionD[0] - 1) * M + (PositionD[1] - 1) + 1)) {
                continue;
            } else {
                Altinlar[bulunan] = random;
                bulunan++;
            }
        }

        int x = 0;
        boolean isSame = false;
        while (x != Gizli_Altinlar.length) {
            isSame = false;
            int random = rand.nextInt((int) (M * N / 100 * AltinOrani));
            for (int t = 0; t < x; t++) {
                if (Gizli_Altinlar[t] == random) {
                    isSame = true;
                    break;
                }
            }
            if (!isSame) {
                Gizli_Altinlar[x] = Altinlar[random];
                x++;
            }
        }

        JFrame f = new JFrame();

        JPanel p = new JPanel();

        Icon gold = new ImageIcon(MainPath + "GameGold.png");
        Icon sgold = new ImageIcon(MainPath + "SGameGold.png");
        int sayac = 0;
        int CounterEG = 0;
        int CounterESG = 0;
        for (int i = 0; i < M; i++) { //X
            for (x = 0; x < N; x++) { //Y
                sayac += 1;
                JButton button = null;
                if (sayac != ((PositionA[0] - 1) * M + (PositionA[1] - 1) + 1) && sayac != ((PositionB[0] - 1) * M + (PositionB[1] - 1) + 1) && sayac != ((PositionC[0] - 1) * M + (PositionC[1] - 1) + 1) && sayac != ((PositionD[0] - 1) * M + (PositionD[1] - 1) + 1)) {
                    boolean isGold = false;
                    int t = 0;
                    for (t = 0; t < Altinlar.length; t++) {
                        if (Altinlar[t] == sayac) {
                            isGold = true;
                            int[] Golds = {5, 10, 15, 20};
                            int random2 = rand.nextInt((int) (4));
                            EditedGold[CounterEG][0] = i + 1;
                            EditedGold[CounterEG][1] = x + 1;
                            EditedGold[CounterEG][2] = Golds[random2];
                            //System.out.println("Normal-->"+Altinlar[t] + " <->  "+EditedGold[CounterEG][0] + " " +EditedGold[CounterEG][1]);
                            CounterEG++;
                        }
                    }
                    if (isGold) {
                        boolean isSecretGold = false;
                        for (int k = 0; k < Gizli_Altinlar.length; k++) {

                            if (Gizli_Altinlar[k] == sayac) {
                                isSecretGold = true;
                                EditedSGold[CounterESG][0] = i + 1;
                                EditedSGold[CounterESG][1] = x + 1;
                                EditedSGold[CounterESG][2] = EditedGold[CounterEG - 1][2];
                                //System.out.println("Gizli--->" + " <->  "+EditedSGold[CounterESG][0] + " " +EditedSGold[CounterESG][1]);
                                CounterESG++;
                                EditedGold = Arrays.copyOf(EditedGold, EditedGold.length - 1);
                                CounterEG--;
                                break;
                            }
                        }
                        if (isSecretGold == false) {
                            button = new JButton(gold);
                        } else {
                            button = new JButton(sgold);
                        }
                    } else {
                        button = new JButton();
                    }

                } else {

                    /*System.out.println("Sayac"+sayac);
                    System.out.println("A:"+((PositionA[0]-1)*M+(PositionA[1]-1)+1));
                    System.out.println("B:"+((PositionB[0]-1)*M+(PositionB[1]-1)+1));
                    System.out.println("C:"+((PositionC[0]-1)*M+(PositionC[1]-1)+1));
                    System.out.println("D:"+((PositionD[0]-1)*M+(PositionD[1]-1)+1));*/
                    Icon charachterA = new ImageIcon(MainPath + "CharacterA.png");
                    Icon charachterB = new ImageIcon(MainPath + "CharacterB.png");
                    Icon charachterC = new ImageIcon(MainPath + "CharacterC.png");
                    Icon charachterD = new ImageIcon(MainPath + "CharacterD.png");

                    if (sayac == (PositionA[0] - 1) * M + (PositionA[1] - 1) + 1) {
                        button = new JButton(charachterA);
                    } else if (sayac == (PositionB[0] - 1) * M + (PositionB[1] - 1) + 1) {
                        button = new JButton(charachterB);
                    } else if (sayac == (PositionC[0] - 1) * M + (PositionC[1] - 1) + 1) {
                        button = new JButton(charachterC);
                    } else if (sayac == (PositionD[0] - 1) * M + (PositionD[1] - 1) + 1) {
                        button = new JButton(charachterD);
                    }
                }

                if (i == M - 1 && x == N - 1) {
                    ScreenWidth = i * 40;
                    ScreenHeight = x * 40;
                }

                p.setLayout(null);
                button.setBounds(i * 40, x * 40, 40, 40);
                p.add(button);
                GameArea.add(button);

            }
        }

        JButton HamleYap = new JButton("Oyuna Başla");
        ScoreBoardA = new JLabel();
        ScoreBoardA.setText("A:" + DefaultGold);
        ScoreBoardA.setBounds(ScreenWidth - 240, ScreenHeight + 80, 120, 40);

        ScoreBoardB = new JLabel();
        ScoreBoardB.setText("B:" + DefaultGold);
        ScoreBoardB.setBounds(ScreenWidth - 200, ScreenHeight + 80, 120, 40);

        ScoreBoardC = new JLabel();
        ScoreBoardC.setText("C:" + DefaultGold);
        ScoreBoardC.setBounds(ScreenWidth - 160, ScreenHeight + 80, 120, 40);

        ScoreBoardD = new JLabel();
        ScoreBoardD.setText("D:" + DefaultGold);
        ScoreBoardD.setBounds(ScreenWidth - 120, ScreenHeight + 80, 120, 40);

        HamleYap.setBounds(ScreenWidth - 80, ScreenHeight + 80, 120, 40);
        HamleYap.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                HamleYap.setEnabled(false);
                try {
                    StartGame thread = new StartGame(EditedGold, EditedSGold, GameArea, ScoreBoardA, ScoreBoardB, ScoreBoardC, ScoreBoardD, DeftMovement, DeftMovementPrice, ANTPrice, BNTPrice, CNTPrice, DNTPrice, CSuperMode, DGold, M, N);
                    thread.start();
                } catch (Exception ex) {
                }
            }
        });

        p.add(ScoreBoardA);
        p.add(ScoreBoardB);
        p.add(ScoreBoardC);
        p.add(ScoreBoardD);
        p.add(HamleYap);
        f.add(p);
        f.setDefaultCloseOperation(3);
        f.setSize(ScreenWidth + 60, ScreenHeight + 160);
        f.setVisible(true);

        /*for (int i = 0; i < EditedSGold.length; i++) {
            System.out.println(EditedSGold[i][0]+","+EditedSGold[i][1]);
        }*/
    }
}
