using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8_103022300003
{
    class Transfer
    {
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }
    }
    class Confirmation
    {
        public string en { get; set; }
        public string id { get; set; }
    }
    internal class BankTransferConfig
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public List<string> methods { get; set; }
        public Confirmation confirmation { get; set; }


        private const string FilePath = "../../../bank_transfer_config.json";


        public void ReadJSON()
        {
            string json = File.ReadAllText(FilePath);
            var config = JsonSerializer.Deserialize<BankTransferConfig>(json);

            lang = config.lang;
            transfer = config.transfer;
            methods = config.methods;
            confirmation = config.confirmation;
        }

        public void UbahBahasa()
        {
            if (lang.ToLower() == "en")
                lang = "id";
            else
                lang = "en";

            Save();
        }

        private void Save()
        {
            string json = JsonSerializer.Serialize(this, new JsonSerializerOptions{ WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }
    }
}
