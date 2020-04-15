using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
namespace backgroundworker
{
   public class FileFactory
    {  public static bool savefile(List<Danhmuc>CSDL,string path)
        {
            try {
                FileStream fs = new FileStream(path, FileMode.Create);
                BinaryFormatter BFT = new BinaryFormatter();
                BFT.Serialize(fs, CSDL);
                fs.Close();
                return true;


            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<Danhmuc> openfile(string path)
        {
            List<Danhmuc> CSDL = new List<Danhmuc>();
            try
            {   
                FileStream fs = new FileStream(path, FileMode.Open);
                BinaryFormatter BFT = new BinaryFormatter();
               Object data= BFT.Deserialize(fs);
         
                CSDL = data as List<Danhmuc>;

                fs.Close();
                return CSDL;


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
