using Newtonsoft.Json;

namespace JKNBridge.ApplicareLib
{
    public class WsResponse
    {
        [JsonProperty("metadata")]
        public Metadata Metadata;

        [JsonProperty("response")]
        public string Response;
    }

    public class Metadata
    {
        [JsonProperty("code")]
        public string Code;

        [JsonProperty("message")]
        public string Message;

    }
}
