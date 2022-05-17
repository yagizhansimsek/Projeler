/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package yazlan2.pkg2;

import java.util.Random;
import java.util.concurrent.locks.Lock;
import java.util.concurrent.locks.ReentrantLock;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author YağızhanŞimşek
 */
public class Yazlan22{


     public static boolean ac2 = false;
     public static boolean ac3 = false;
     public static boolean ac4 = false;
     public static boolean ac5 = false;
     public static int temp0 = 1;
     public static int temp1 = 1;
     public static int temp2 = 1;
     public static int temp3 = 1;
     public static int temp4 = 1;
     public static int sınır = 20;
     public static int sınır1 = 20;
     public static int sınır2 = 20;
     public static int sınır3 = 20;
     public static int sınır4 = 20;
     public static int alt = 1000000;
     public static int alt1 = 1000000;
     public static int alt2 = 1000000;
     public static int alt3 = 1000000;
     public static int alt4 = 1000000;     
     public static int Atmp1=0;
     public static int Atmp2=0;
     public static int Atmp3=0;
     public static int Atmp4=0;
     public static int Atmp5=0;
     
     public static int hedef=0;
     public static int hedef1=0;
     public static int hedef2=0;
     public static int hedef3=0;
     public static int hedef4=0;
     
     public static int direction1=0;
     public static int direction2=0;
     public static int direction3=0;
     public static int direction4=0;
     public static int direction5=0;
     
     public static int müşteri_sayisi = 0;
     public static int alınan_müşteri = 0;
     public static int çıkan_müşteri = 0;
     public static int  kapasite = 10;
     public static Random random = new Random();
     public static int randomdeger1;
     public static int sayac = 1;
     public static int Atoplam=0;
     public static int Atoplam1=0;
     public static int Atoplam2=0;
     public static int Atoplam3=0;
     public static int Atoplam4=0;
     public static Lock kilit= new ReentrantLock();
     public static Lock kilit2= new ReentrantLock();
     public static Lock kilit3= new ReentrantLock();
     public static Lock kilit4= new ReentrantLock();
     
     public static int[] gidilmekistenenkat = new int[5];     
     public static int[][]katvekuyruk=new int [5][2];
     //katvekuyruk 0 = kuyrukatama katvekuyruk 1=kattakisi

   
     public static void main(String[] args) {  
         for(int i=0 ;i<5; i++)
         {for(int j=0 ;i<5; i++){
             katvekuyruk[i][j]=0;
         }
         }
         
          for(int i : gidilmekistenenkat)
         {
             gidilmekistenenkat[i]=0;
         }
         
          
        Thread Avmgiriş = new Thread(new Runnable() {

            @Override
            public  void run() {   
                while(true)
                {
                try {
                    Thread.sleep(500); // threadi yarım saniye uyut
                    
                } catch (InterruptedException ex) {
                    Logger.getLogger(Yazlan22.class.getName()).log(Level.SEVERE, null, ex);
                }
                    alınan_müşteri=1+random.nextInt(9); // 1 ile 10 arasında insan al
                    katvekuyruk[0][1]+=alınan_müşteri; // 0. kata alacağın için bu katta ata.  
                    müşteri_sayisi+=alınan_müşteri; // toplam müşteri sayısını alınan müşteri kadar yap
                    
                    for(int i=0;i<alınan_müşteri;i++) // tüm alunan müşteriler için bir defa
                    {
                        randomdeger1=1+random.nextInt(4); //1 ile 4 arasında (4 dahil) random değer ata
                        katvekuyruk[0][0]++;//0. katta olduğu için 0. kat kuyruğuna ata
                        gidilmekistenenkat[randomdeger1]++; // gitmek istenilen kattaki insanları 1 arttır.
                    }
                    
                    
              }
            }
        });
        
        Thread Avmçıkış = new Thread(new Runnable() {

            @Override
            public void run() {
                while(true)
                {
                try {
                    Thread.sleep(1000); // 1 saniyede bir çalışsın
                    
                } catch (InterruptedException ex) {
                    Logger.getLogger(Yazlan22.class.getName()).log(Level.SEVERE, null, ex);
                }
                
                çıkan_müşteri = 1+random.nextInt(4); // 1 ile 4 arasındaki insanları çıkartmak için random belirle                
                
                  for(int i=0;i<çıkan_müşteri;i++) // çımak isteyen tüm müşteriler için
                    {
                        randomdeger1=random.nextInt(5); // hangi kattan çıkarmak istediğini yazdır. 1 ile 5 arasında
                        if(katvekuyruk[randomdeger1][1]>katvekuyruk[randomdeger1][0]) // eğer kattaki kişi sayısı kuyruktaki kişi sayısından fazla ise
                        {
                            katvekuyruk[randomdeger1][0]++; // o kattaki insanı, o katın kuyruğuna sok kuyruğa sok
                            gidilmekistenenkat[0]++; // çıkacakları için 0. kata gitmek isteyecekler.
                            
                        }
                        else
                        {
                           i--;
                        }
                    }
                  if(çıkan_müşteri<=katvekuyruk[0][1]) // çıkması gereken müşteri sayısı hali hazırda 0. katta varsa, bu müşterileri çıkart
                  {   
                      katvekuyruk[0][1]-=çıkan_müşteri;
                      müşteri_sayisi-=çıkan_müşteri;
                      
                  }
                }
            }
        });
        
        Thread kontrol = new Thread(new Runnable() {
                   
            @Override
            public void run() {
                int sayac=0;
                kilit.lock();
                kilit2.lock();
                kilit3.lock();
                kilit4.lock(); 
               while(true)
               {   

                   
                   try {
                       Thread.sleep(300);
                   } catch (InterruptedException ex) {
                       Logger.getLogger(Yazlan22.class.getName()).log(Level.SEVERE, null, ex);
                   }
                   
                   
                   
                   System.out.println(" 0.floor :"+(katvekuyruk[0][1]+katvekuyruk[0][0])+" queue: "+katvekuyruk[0][0]);
                   System.out.println(" 1.floor :"+(katvekuyruk[1][1]+katvekuyruk[1][0])+" queue: "+katvekuyruk[1][0]);
                   System.out.println(" 2.floor :"+(katvekuyruk[2][1]+katvekuyruk[2][0])+" queue: "+katvekuyruk[2][0]);
                   System.out.println(" 3.floor :"+(katvekuyruk[3][1]+katvekuyruk[3][0])+" queue: "+katvekuyruk[3][0]);
                   System.out.println(" 4.floor :"+(katvekuyruk[4][1]+katvekuyruk[4][0])+" queue: "+katvekuyruk[4][0]);
                   System.out.println("exit count : "+çıkan_müşteri);
                   çıkan_müşteri=0;
                   
                   ///////////////////ASANSÖR 1 İÇİN
                   System.out.println("Active : TRUE ");
                   System.out.println("                        mode : working");
                   System.out.println("                        floor :"+Atmp1);
                   System.out.println("                        destination :"+hedef);
                   if(direction1==-1)
                   {
                       System.out.println("                           direction : DOWN");
                   }
                   else if(direction1==1)
                   {
                       System.out.println("                           direction : UP");
                   }
                   else if(direction1==0)
                   {
                       System.out.println("                           direction : SAME FLOOR");
                   }
                   System.out.println("                           capacity : 10");
                   System.out.println("                           count_inside : "+Atoplam);
                   
                    ///////////////////ASANSÖR 2 İÇİN
                   if(sayac>=1)
                   {
                   System.out.println("Active : TRUE ");
                   System.out.println("                           mode : working");
                   }
                   else if(sayac==0)
                   {
                       System.out.println("Active : FALSE ");
                       System.out.println("                           mode : idle");
                   }
                   System.out.println("                           floor :"+Atmp2);
                   System.out.println("                           destination :"+hedef1);
                   if(direction2==-1)
                   {
                       System.out.println("                           direction : DOWN");
                   }
                   else if(direction2==1)
                   {
                       System.out.println("                           direction : UP");
                   }
                   else if(direction2==0)
                   {
                       System.out.println("                           direction : SAME FLOOR");
                   }
                   System.out.println("                           capacity : 10");
                   System.out.println("                           count_inside : "+Atoplam1);
                   
                   ///////////////////ASANSÖR 3 İÇİN
                   if(sayac>=2)
                   {
                   System.out.println("Active : TRUE ");
                   System.out.println("                           mode : working");
                   }
                   else if(sayac==1 || sayac==0)
                   {
                       System.out.println("Active : FALSE ");
                       System.out.println("                           mode : idle");
                   }
                   System.out.println("                           floor :"+Atmp3);
                   System.out.println("                           destination :"+hedef2);
                   if(direction3==-1)
                   {
                       System.out.println("                           direction : DOWN");
                   }
                   else if(direction3==1)
                   {
                       System.out.println("                           direction : UP");
                   }
                   else if(direction3==0)
                   {
                       System.out.println("                           direction : SAME FLOOR");
                   }
                   System.out.println("                           capacity : 10");
                   System.out.println("                           count_inside : "+Atoplam2);
                   
                    ///////////////////ASANSÖR 4 İÇİN
                   if(sayac>=3)
                   {
                   System.out.println("Active : TRUE ");
                   System.out.println("                           mode : working");
                   }
                   else if(sayac==2 || sayac==1 || sayac==0)
                   {
                       System.out.println("Active : FALSE ");
                       System.out.println("                           mode : idle");
                   }
                   System.out.println("                           floor :"+Atmp4);
                   System.out.println("                           destination :"+hedef3);
                   if(direction4==-1)
                   {
                       System.out.println("                           direction : DOWN");
                   }
                   else if(direction4==1)
                   {
                       System.out.println("                           direction : UP");
                   }
                   else if(direction4==0)
                   {
                       System.out.println("                           direction : SAME FLOOR");
                   }
                   System.out.println("                           capacity : 10");
                   System.out.println("                           count_inside : "+Atoplam3);
                   
                   ///////////////////ASANSÖR 5 İÇİN
                   if(sayac>=4)
                   {
                   System.out.println("Active : TRUE ");
                   System.out.println("                           mode : working");
                   }
                   else if(sayac==3 || sayac==2 || sayac==1 || sayac==0)
                   {
                       System.out.println("Active : FALSE ");
                       System.out.println("                           mode : idle");
                   }
                   System.out.println("                           floor :"+Atmp5);
                   System.out.println("                           destination :"+hedef4);
                   if(direction5==-1)
                   {
                       System.out.println("                           direction : DOWN");
                   }
                   else if(direction5==1)
                   {
                       System.out.println("                           direction : UP");
                   }
                   else if(direction5==0)
                   {
                       System.out.println("                           direction : SAME FLOOR");
                   }
                   System.out.println("                           capacity : 10");
                   System.out.println("                           count_inside : "+Atoplam4);
                   ////////////////////////////////////////////////////////////

                   if(katvekuyruk[0][0]+ katvekuyruk[1][0]+katvekuyruk[2][0]+ katvekuyruk[3][0]+ katvekuyruk[4][0]>=20&& sayac==0)
                           {
                     
                       kilit.unlock();
                       sayac++;
                       ac2=true;
                       
                       if(katvekuyruk[0][0]>=sınır)
                       {
                           temp0++;
                           sınır+=sınır;
                           alt=10;         
                       }
                       else if(katvekuyruk[1][0]>=sınır1)
                       {
                           temp1++;
                           sınır1+=sınır1;
                           alt1=10;
                       }
                       else if(katvekuyruk[2][0]>=sınır2)
                       {
                           temp2++;
                           sınır2+=sınır2;
                           alt2=10;
                       }
                       else if(katvekuyruk[3][0]>=sınır3)
                       {
                           temp3++;
                           sınır3+=sınır3;
                           alt3=10;
                       }
                       else if(katvekuyruk[4][0]>=sınır4)
                       {
                           temp4++;
                           sınır4+=sınır4;
                           alt4=10;
                       }
                   }
                   
                  else if(katvekuyruk[0][0]+ katvekuyruk[1][0]+katvekuyruk[2][0]+ katvekuyruk[3][0]+ katvekuyruk[4][0]>=40&& sayac==1)
                   {   
                       kilit2.unlock();
                       sayac++;
                       ac3=true;
                       if(katvekuyruk[0][0]>=sınır)
                       {
                           temp0++;
                           sınır+=sınır;
                           alt=10;         
                       }
                       else if(katvekuyruk[1][0]>=sınır1)
                       {
                           temp1++;
                           sınır1+=sınır1;
                           alt1=10;
                       }
                       else if(katvekuyruk[2][0]>=sınır2)
                       {
                           temp2++;
                           sınır2+=sınır2;
                           alt2=10;
                       }
                       else if(katvekuyruk[3][0]>=sınır3)
                       {
                           temp3++;
                           sınır3+=sınır3;
                           alt3=10;
                       }
                       else if(katvekuyruk[4][0]>=sınır4)
                       {
                           temp4++;
                           sınır4+=sınır4;
                           alt4=10;
                       } sınır4+=sınır4;
                       
                   }
                  else if(katvekuyruk[0][0]+ katvekuyruk[1][0]+katvekuyruk[2][0]+ katvekuyruk[3][0]+ katvekuyruk[4][0]>=60&& sayac==2)
                   {
                       kilit3.unlock();
                       sayac++;
                       ac4=true;
                       if(katvekuyruk[0][0]>=sınır)
                       {
                           temp0++;
                           
                           sınır+=sınır;
                           alt=10;         
                       }
                       else if(katvekuyruk[1][0]>=sınır1)
                       {
                           temp1++;
                           sınır1+=sınır1;
                           alt1=10;
                       }
                       else if(katvekuyruk[2][0]>=sınır2)
                       {
                           temp2++;
                           sınır2+=sınır2;
                           alt2=10;
                       }
                       else if(katvekuyruk[3][0]>=sınır3)
                       {
                           temp3++;
                           sınır3+=sınır3;
                           alt3=10;
                       }
                       else if(katvekuyruk[4][0]>=sınır4)
                       {
                           temp4++;
                           sınır4+=sınır4;
                           alt4=10;
                       }
                        
                   }
                 else  if(katvekuyruk[0][0]+ katvekuyruk[1][0]+katvekuyruk[2][0]+ katvekuyruk[3][0]+ katvekuyruk[4][0]>=80&& sayac==3)
                   {  
                   
                       kilit4.unlock();
                       sayac++;
                       ac5=true;
                      
                       if(katvekuyruk[0][0]>=sınır)
                       {
                           temp0++;
                           sınır+=sınır;
                           alt=10;         
                       }
                       else if(katvekuyruk[1][0]>=sınır1)
                       {
                           temp1++;
                           sınır1+=sınır1;
                           alt1=10;
                       }
                       else if(katvekuyruk[2][0]>=sınır2)
                       {
                           temp2++;
                           sınır2+=sınır2;
                           alt2=10;
                       }
                       else if(katvekuyruk[3][0]>=sınır3)
                       {
                           temp3++;
                           sınır3+=sınır3;
                           alt3=10;
                       }
                       else if(katvekuyruk[4][0]>=sınır4)
                       {
                           temp4++;
                           sınır4+=sınır4;
                           alt4=10;
                       }
                        
                   } 
                   if(katvekuyruk[0][0]+ katvekuyruk[1][0]+katvekuyruk[2][0]+ katvekuyruk[3][0]+ katvekuyruk[4][0]<50){
                       kilit4.lock();
                   }
                   if(katvekuyruk[0][0]+ katvekuyruk[1][0]+katvekuyruk[2][0]+ katvekuyruk[3][0]+ katvekuyruk[4][0]<40){
                       kilit3.lock();
                   }
                   if(katvekuyruk[0][0]+ katvekuyruk[1][0]+katvekuyruk[2][0]+ katvekuyruk[3][0]+ katvekuyruk[4][0]<30){
                       kilit2.lock();
                   }
                   if(katvekuyruk[0][0]+ katvekuyruk[1][0]+katvekuyruk[2][0]+ katvekuyruk[3][0]+ katvekuyruk[4][0]<20){
                       kilit.lock();
                   }
               }
            }
        });
        
        Thread Asansör1 = new Thread(new Runnable() {
           
            @Override
            public void run() {
                
               while(true)
         {          for(int i = 0 ; i<5 ; i++){
                     if(gidilmekistenenkat[i]>0 )
                        {  
                                hedef=i;
                                
                            if(hedef-Atmp1<0)
                            {
                                direction1=-1;
                            }
                            else if(hedef-Atmp1>0)
                            {
                                direction1=1;
                            }
                            else
                            {
                                direction1=0;
                            }
                                
                            try {
                        Thread.sleep(Math.abs(Atmp1-i)*200);
                        } catch (InterruptedException ex) {
                            Logger.getLogger(Yazlan22.class.getName()).log(Level.SEVERE, null, ex);
                        }
                            
                            Atmp1=i;
                            
                            if(gidilmekistenenkat[i]>10 && Atoplam==10 && katvekuyruk[i][1]>10)
                            {
                                katvekuyruk[i][1]+=10;
                                gidilmekistenenkat[i]-=10;
                                Atoplam=0;
                            }
                            else if(gidilmekistenenkat[i]>10 && Atoplam<10)
                            {
                                katvekuyruk[i][1]+=Atoplam;
                                gidilmekistenenkat[i]-=Atoplam;
                                Atoplam=0;
                            }
                            else if(gidilmekistenenkat[i]<10 && Atoplam==10)
                             {
                                katvekuyruk[i][1]+=gidilmekistenenkat[i];
                                gidilmekistenenkat[i]-=0;
                                Atoplam-=gidilmekistenenkat[i];
                            } 
                            else if(gidilmekistenenkat[i]<10 && Atoplam<10 && Atoplam<gidilmekistenenkat[i])
                            {
                                katvekuyruk[i][1]+=Atoplam;
                                gidilmekistenenkat[i]-=Atoplam;
                                Atoplam=gidilmekistenenkat[i]-Atoplam;
                            }
                            else if(gidilmekistenenkat[i]<10 && Atoplam<10 && Atoplam>=gidilmekistenenkat[i])
                            {
                                katvekuyruk[i][1]+=gidilmekistenenkat[i];
                                gidilmekistenenkat[i]-=gidilmekistenenkat[i];
                                Atoplam=Atoplam-gidilmekistenenkat[i];
                            }
                           
                        }
                        
                    
                       
                        //bindirme işlemi
                        if(katvekuyruk[i][0]+Atoplam<=10 && katvekuyruk[i][0]>0 && katvekuyruk[i][1]>0 && katvekuyruk[i][1]>=katvekuyruk[i][0])
                        { 
                           
                            Atoplam+=katvekuyruk[i][0];
                            katvekuyruk[i][1]-=katvekuyruk[i][0]; 
                            katvekuyruk[i][0]-=0;
                            
                        }
                        else if(katvekuyruk[i][0]+Atoplam>10 &&katvekuyruk[i][0]>0 && katvekuyruk[i][1]>0 && katvekuyruk[i][1]>=katvekuyruk[i][0])
                        {
                            katvekuyruk[i][0]-=(10-Atoplam);
                            katvekuyruk[i][1]-=(10-Atoplam);
                            Atoplam=10;
                        }
                        
                    
         }
             }  
            }
        });
        
        Thread Asansör2 = new Thread(new Runnable() {

            @Override
            public void run() {
                
                 synchronized(kilit)
        {
                while(true)
                { 
                    //1 den 4. kata
                    for(int i = 0 ; i<5 ; i++) // asansör
                    {   
                        hedef1=i;
                                
                            if(hedef1-Atmp2<0)
                            {
                                direction2=-1;
                            }
                            else if(hedef1-Atmp1>0)
                            {
                                direction2=1;
                            }
                            else
                            {
                                direction2=0;
                            }
                        
                        
                        if(gidilmekistenenkat[i]>0 )
                        {  
                             try {
                        Thread.sleep(Math.abs(Atmp2-i)*200);
                        } catch (InterruptedException ex) {
                            Logger.getLogger(Yazlan22.class.getName()).log(Level.SEVERE, null, ex);
                        }
                            
                            Atmp2=i;
                            
                            if(gidilmekistenenkat[i]>10 && Atoplam1==10 && katvekuyruk[i][1]>10)
                            {
                                katvekuyruk[i][1]+=10;
                                gidilmekistenenkat[i]-=10;
                                Atoplam1=0;
                            }
                            else if(gidilmekistenenkat[i]>10 && Atoplam1<10)
                            {
                                katvekuyruk[i][1]+=Atoplam1;
                                gidilmekistenenkat[i]-=Atoplam1;
                                Atoplam1=0;
                            }
                            else if(gidilmekistenenkat[i]<10 && Atoplam1==10)
                             {
                                katvekuyruk[i][1]+=gidilmekistenenkat[i];
                                gidilmekistenenkat[i]-=0;
                                Atoplam1-=gidilmekistenenkat[i];
                            } 
                            else if(gidilmekistenenkat[i]<10 && Atoplam1<10 && Atoplam1<gidilmekistenenkat[i])
                            {
                                katvekuyruk[i][1]+=Atoplam1;
                                gidilmekistenenkat[i]-=Atoplam1;
                                Atoplam1=gidilmekistenenkat[i]-Atoplam1;
                            }
                            else if(gidilmekistenenkat[i]<10 && Atoplam1<10 && Atoplam1>=gidilmekistenenkat[i])
                            {
                                katvekuyruk[i][1]+=gidilmekistenenkat[i];
                                gidilmekistenenkat[i]-=gidilmekistenenkat[i];
                                Atoplam1=Atoplam1-gidilmekistenenkat[i];
                            }
                           
                        }
                          //bindirme işlemi
                        if(katvekuyruk[i][0]+Atoplam1<=10 && katvekuyruk[i][0]>0 && katvekuyruk[i][1]>0 && katvekuyruk[i][1]>=katvekuyruk[i][0])
                        { 
                           
            
                            Atoplam1+=katvekuyruk[i][0];
                            katvekuyruk[i][1]-=katvekuyruk[i][0]; 
                            katvekuyruk[i][0]-=0;
                        }
                        else if(katvekuyruk[i][0]+Atoplam1>10 && katvekuyruk[i][0]>0 && katvekuyruk[i][1]>0 && katvekuyruk[i][1]>=katvekuyruk[i][0])
                        {
            
                            katvekuyruk[i][0]-=(10-Atoplam1);
                            katvekuyruk[i][1]-=(10-Atoplam1);
                            Atoplam1=10;
                        }
                        
                      
                    }
                    
                }
        }
            }
        });
        
        Thread Asansör3 = new Thread(new Runnable() {

            @Override
            public void run() {
                synchronized(kilit2)
        {
                 while(true)
                { 
                    //1 den 4. kata
                    for(int i = 0 ; i<5 ; i++) // asansör
                    {   
                        hedef2=i;
                                
                            if(hedef2-Atmp3<0)
                            {
                                direction3=-1;
                            }
                            else if(hedef2-Atmp3>0)
                            {
                                direction3=1;
                            }
                            else
                            {
                                direction3=0;
                            }
                        //indirme
                        if(gidilmekistenenkat[i]>0 )
                        {  
                             try {
                        Thread.sleep(Math.abs(Atmp3-i)*200);
                        } catch (InterruptedException ex) {
                            Logger.getLogger(Yazlan22.class.getName()).log(Level.SEVERE, null, ex);
                        }
                            
                            Atmp3=i;
                            
                            if(gidilmekistenenkat[i]>10 && Atoplam2==10 && katvekuyruk[i][1]>10)
                            {
                                katvekuyruk[i][1]+=10;
                                gidilmekistenenkat[i]-=10;
                                Atoplam2=0;
                            }
                            else if(gidilmekistenenkat[i]>10 && Atoplam2<10)
                            {
                                katvekuyruk[i][1]+=Atoplam2;
                                gidilmekistenenkat[i]-=Atoplam2;
                                Atoplam2=0;
                            }
                            else if(gidilmekistenenkat[i]<10 && Atoplam2==10)
                             {
                                katvekuyruk[i][1]+=gidilmekistenenkat[i];
                                gidilmekistenenkat[i]-=0;
                                Atoplam2-=gidilmekistenenkat[i];
                            } 
                            else if(gidilmekistenenkat[i]<10 && Atoplam2<10 && Atoplam2<gidilmekistenenkat[i])
                            {
                                katvekuyruk[i][1]+=Atoplam2;
                                gidilmekistenenkat[i]-=Atoplam2;
                                Atoplam2=gidilmekistenenkat[i]-Atoplam2;
                            }
                            else if(gidilmekistenenkat[i]<10 && Atoplam2<10 && Atoplam2>=gidilmekistenenkat[i])
                            {
                                katvekuyruk[i][1]+=gidilmekistenenkat[i];
                                gidilmekistenenkat[i]-=gidilmekistenenkat[i];
                                Atoplam2=Atoplam2-gidilmekistenenkat[i];
                            }
                           
                        }
                         //bindirme işlemi
                        if(katvekuyruk[i][0]+Atoplam2<=10 && katvekuyruk[i][0]>0 && katvekuyruk[i][1]>0 && katvekuyruk[i][1]>=katvekuyruk[i][0])
                        { 
                           

                            Atoplam2+=katvekuyruk[i][0];
                            katvekuyruk[i][1]-=katvekuyruk[i][0]; 
                            katvekuyruk[i][0]-=0;
                        }
                        else if(katvekuyruk[i][0]+Atoplam2>10 && katvekuyruk[i][0]>0 && katvekuyruk[i][1]>0 && katvekuyruk[i][1]>=katvekuyruk[i][0])
                        {

                            katvekuyruk[i][0]-=(10-Atoplam2);
                            katvekuyruk[i][1]-=(10-Atoplam2);
                            Atoplam2=10;
                        }
                        
                      
                    }
                    
                }
        }
            }
        });
         
        Thread Asansör4 = new Thread(new Runnable() {

            @Override
            public void run() {
                synchronized(kilit3)
        {
                 while(true)
                { 
                    //1 den 4. kata
                    for(int i = 0 ; i<5 ; i++) // asansör
                    {   
                        
                        hedef3=i;
                                
                            if(hedef3-Atmp4<0)
                            {
                                direction4=-1;
                            }
                            else if(hedef3-Atmp4>0)
                            {
                                direction4=1;
                            }
                            else
                            {
                                direction4=0;
                            }
                         //indirme
                        if(gidilmekistenenkat[i]>0 )
                        {  
                             try {
                        Thread.sleep(Math.abs(Atmp4-i)*200);
                        } catch (InterruptedException ex) {
                            Logger.getLogger(Yazlan22.class.getName()).log(Level.SEVERE, null, ex);
                        }
                            
                            Atmp4=i;
                            
                            if(gidilmekistenenkat[i]>10 && Atoplam3==10 && katvekuyruk[i][1]>10)
                            {
                                katvekuyruk[i][1]+=10;
                                gidilmekistenenkat[i]-=10;
                                Atoplam3=0;
                            }
                            else if(gidilmekistenenkat[i]>10 && Atoplam3<10)
                            {
                                katvekuyruk[i][1]+=Atoplam3;
                                gidilmekistenenkat[i]-=Atoplam3;
                                Atoplam3=0;
                            }
                            else if(gidilmekistenenkat[i]<10 && Atoplam3==10)
                             {
                                katvekuyruk[i][1]+=gidilmekistenenkat[i];
                                gidilmekistenenkat[i]-=0;
                                Atoplam3-=gidilmekistenenkat[i];
                            } 
                            else if(gidilmekistenenkat[i]<10 && Atoplam3<10 && Atoplam3<gidilmekistenenkat[i])
                            {
                                katvekuyruk[i][1]+=Atoplam3;
                                gidilmekistenenkat[i]-=Atoplam3;
                                Atoplam3=gidilmekistenenkat[i]-Atoplam3;
                            }
                            else if(gidilmekistenenkat[i]<10 && Atoplam3<10 && Atoplam3>=gidilmekistenenkat[i])
                            {
                                katvekuyruk[i][1]+=gidilmekistenenkat[i];
                                gidilmekistenenkat[i]-=gidilmekistenenkat[i];
                                Atoplam3=Atoplam3-gidilmekistenenkat[i];
                            }
                           
                        }  
                         //bindirme işlemi
                        if(katvekuyruk[i][0]+Atoplam3<=10 && katvekuyruk[i][0]>0 && katvekuyruk[i][1]>0 && katvekuyruk[i][1]>=katvekuyruk[i][0])
                        { 
                           
 
                            Atoplam3+=katvekuyruk[i][0];
                            katvekuyruk[i][1]-=katvekuyruk[i][0]; 
                            katvekuyruk[i][0]-=0;
                        }
                        else if(katvekuyruk[i][0]+Atoplam3>10 && katvekuyruk[i][0]>0 && katvekuyruk[i][1]>0 && katvekuyruk[i][1]>=katvekuyruk[i][0])
                        {
      
                            katvekuyruk[i][0]-=(10-Atoplam3);
                            katvekuyruk[i][1]-=(10-Atoplam3);
                            Atoplam3=10;
                        }
                     
                    }
                    
                    }
        }
            }
        });

        Thread Asansör5 = new Thread(new Runnable() {

            @Override
            public void run() {
                 synchronized(kilit4)
        {
                while(true)
                { 
                    //1 den 4. kata
                    for(int i = 0 ; i<5 ; i++) // asansör
                    {   
                        hedef4=i;
                                
                            if(hedef4-Atmp1<0)
                            {
                                direction5=-1;
                            }
                            else if(hedef4-Atmp5>0)
                            {
                                direction5=1;
                            }
                            else
                            {
                                direction5=0;
                            }
                        
                        //indirme
                        if(gidilmekistenenkat[i]>0 )
                        {  
                             try {
                        Thread.sleep(Math.abs(Atmp5-i)*200);
                        } catch (InterruptedException ex) {
                            Logger.getLogger(Yazlan22.class.getName()).log(Level.SEVERE, null, ex);
                        }
                            
                            Atmp5=i;
                            
                            if(gidilmekistenenkat[i]>10 && Atoplam4==10 && katvekuyruk[i][1]>10)
                            {
                                katvekuyruk[i][1]+=10;
                                gidilmekistenenkat[i]-=10;
                                Atoplam4=0;
                            }
                            else if(gidilmekistenenkat[i]>10 && Atoplam4<10)
                            {
                                katvekuyruk[i][1]+=Atoplam4;
                                gidilmekistenenkat[i]-=Atoplam4;
                                Atoplam4=0;
                            }
                            else if(gidilmekistenenkat[i]<10 && Atoplam4==10)
                             {
                                katvekuyruk[i][1]+=gidilmekistenenkat[i];
                                gidilmekistenenkat[i]-=0;
                                Atoplam4-=gidilmekistenenkat[i];
                            } 
                            else if(gidilmekistenenkat[i]<10 && Atoplam4<10 && Atoplam4<gidilmekistenenkat[i])
                            {
                                katvekuyruk[i][1]+=Atoplam4;
                                gidilmekistenenkat[i]-=Atoplam4;
                                Atoplam4=gidilmekistenenkat[i]-Atoplam4;
                            }
                            else if(gidilmekistenenkat[i]<10 && Atoplam4<10 && Atoplam4>=gidilmekistenenkat[i])
                            {
                                katvekuyruk[i][1]+=gidilmekistenenkat[i];
                                gidilmekistenenkat[i]-=gidilmekistenenkat[i];
                                Atoplam4=Atoplam4-gidilmekistenenkat[i];
                            }
                           
                        }  
                           //bindirme işlemi
                        if(katvekuyruk[i][0]+Atoplam4<=10 && katvekuyruk[i][0]>0 && katvekuyruk[i][1]>0 && katvekuyruk[i][1]>=katvekuyruk[i][0])
                        { 
                           

                            Atoplam4+=katvekuyruk[i][0];
                            katvekuyruk[i][1]-=katvekuyruk[i][0]; 
                            katvekuyruk[i][0]-=0;
                        }
                        else if(katvekuyruk[i][0]+Atoplam4>10 && katvekuyruk[i][0]>0 && katvekuyruk[i][1]>0 && katvekuyruk[i][1]>=katvekuyruk[i][0])
                        {

                            katvekuyruk[i][0]-=(10-Atoplam4);
                            katvekuyruk[i][1]-=(10-Atoplam4);
                            Atoplam4=10;
                        }
                        

                    }
                    
                }
        }
            }
        });
        
        Avmgiriş.start();
        
        Avmçıkış.start();
        
        kontrol.start();
        
        Asansör1.start();
        
        Asansör2.start();
        
        Asansör3.start();
        
        Asansör4.start();
        
        Asansör5.start();
        
        
    }
    
}