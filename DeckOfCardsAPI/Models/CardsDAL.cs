using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DeckOfCardsAPI.Models
{
    public class CardsDAL
    {
        public CardsModel GetData()
        {
            string key = "jes44pi8e6tp";
            string url = $"https://deckofcardsapi.com/api/deck/{key}/draw/?count=5";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string JSON = reader.ReadToEnd();

            CardsModel result = JsonConvert.DeserializeObject<CardsModel>(JSON);

            return result;
        }
    }
}
