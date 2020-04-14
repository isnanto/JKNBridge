using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKNBridge.ApotikOnline
{
    public class ResponseSEP
    {

        [JsonProperty("noSep")]
        public string NoSep { get; set; }

        [JsonProperty("faskesasalresep")]
        public string Faskesasalresep { get; set; }

        [JsonProperty("nmfaskesasalresep")]
        public string Nmfaskesasalresep { get; set; }

        [JsonProperty("nokartu")]
        public string Nokartu { get; set; }

        [JsonProperty("namapeserta")]
        public string Namapeserta { get; set; }

        [JsonProperty("jnskelamin")]
        public string Jnskelamin { get; set; }

        [JsonProperty("tgllhr")]
        public string Tgllhr { get; set; }

        [JsonProperty("pisat")]
        public string Pisat { get; set; }

        [JsonProperty("kdjenispeserta")]
        public string Kdjenispeserta { get; set; }

        [JsonProperty("nmjenispeserta")]
        public string Nmjenispeserta { get; set; }

        [JsonProperty("kodebu")]
        public string Kodebu { get; set; }

        [JsonProperty("namabu")]
        public string Namabu { get; set; }

        [JsonProperty("tglsep")]
        public string Tglsep { get; set; }

        [JsonProperty("tglplgsep")]
        public string Tglplgsep { get; set; }

        [JsonProperty("kdjnspelayanan")]
        public string Kdjnspelayanan { get; set; }

        [JsonProperty("jnspelayanan")]
        public string Jnspelayanan { get; set; }

        [JsonProperty("kddiag")]
        public string Kddiag { get; set; }

        [JsonProperty("nmdiag")]
        public string Nmdiag { get; set; }

        [JsonProperty("kdpoli")]
        public string Kdpoli { get; set; }

        [JsonProperty("poli")]
        public string Poli { get; set; }

        [JsonProperty("flagprb")]
        public string Flagprb { get; set; }

        [JsonProperty("namaprb")]
        public string Namaprb { get; set; }

        [JsonProperty("kodedokter")]
        public string Kodedokter { get; set; }

        [JsonProperty("namadokter")]
        public string Namadokter { get; set; }
    }

    public class SEP
    {

        [JsonProperty("metaData")]
        public MetaData MetaData { get; set; }

        [JsonProperty("response")]
        public ResponseSEP Response { get; set; }
    }
}
