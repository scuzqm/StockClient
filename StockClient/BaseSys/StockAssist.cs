using System.IO;
using System.Net;

namespace STBaseSys
{
    class StockAssist
    {
	   private string m_RecieveDataText;
       public StockAssist()
       {

       }
        public void GetUrlData(int stockId,string url)
        {           
            // Initialize the WebRequest.  
            WebRequest myRequest = WebRequest.Create(url);  
            // Return the response.   
            WebResponse myResponse = myRequest.GetResponse();  
            // Code to use the WebResponse goes here.  
            Stream stream = myResponse.GetResponseStream();
            // Close the response to free resources.  
            myResponse.Close();  

            stream.Position = 0;  
            StreamReader reader = new StreamReader( stream );  
  
            SaveDataToDs(stockId,reader.ReadToEnd());
        }

        private void SaveDataToDs(int stockId,string content)
        {
            RealTimeDataStore ds = DataStoreManager.instance.FindOrBindDataStore<RealTimeDataStore>();
            //to do save data to ds;
        }
    }


}
