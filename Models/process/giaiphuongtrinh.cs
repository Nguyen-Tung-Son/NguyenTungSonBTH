using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace DemoMVC.Models{
    public class giaiphuongtrinh{
         public string giaiphuongtrinhbacmot(double heSoA,double hesoB){
        string message= "";
        double x ;
         if(heSoA==0){
                if(hesoB==0){
                    message="Phuong tring co vo so nghiem";
                }else{
                     message="Phuong tring vo nghiem";
                }
            }else{
                x= -hesoB/heSoA;
                message="Phuong trinh co nghiem x ="+x;

            }
            return message;
    }
    public string giaiphuongtrinhbachai(double soA,double soB,double soC  ){
        string message="";
        double x1 ;
        double x2;
        double denta = soB*soB-4*soA*soC;

        if(soA==0){
            message = giaiphuongtrinhbacmot(soB, soC);
        }else{
            if(denta < 0){
                message ="Phuong trinh vo nghiem";
            }else if(denta == 0){
                x1= - soB/(soA*2);
                message ="phuong trinh co 1 nghiem x= "+x1;
            }else if(denta > 0){
                x1= ((-soB + Math.Sqrt(denta))/2*soA);
                x2= ((-soB - Math.Sqrt(denta))/2*soA);
                 message ="Phuong trinh co 2 nghiem x1 ="+x1 +"x2="+x2;

            }
        }
        return message;
    }
    }
}