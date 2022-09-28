namespace DemoMVC.Models.process
{   
    public class StringProcess  
    {
        public string RemoveRemainingWhiteSpace (string strInput)
            {
                string result = "";
                //Viet code xu ly cac ky tu trang con thua 
                //Xoa bo ky tu trang o dau va cuoi chuoi
                strInput = strInput.Trim();
                //Xoa bo cac ky tu trang con thua o giua chuoi
                int index = strInput.IndexOf(" ");
                while(strInput.IndexOf(" ")>0)
                {
                    strInput = strInput.Replace("  ", " ");
                }
                return result;
            }
    
    }
}
