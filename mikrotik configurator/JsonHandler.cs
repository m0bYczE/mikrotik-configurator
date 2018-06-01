using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace mikrotik_configurator
{
    class JsonHandler
    {
        public JsonHandler()
        {
        }

        public JsonObject ReadJson(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }
            String file = File.ReadAllText(path); 
            JsonObject jsonFile = JsonConvert.DeserializeObject<JsonObject>(file); //parsing json to a object for easier acess
            return jsonFile;
        }

        public bool WriteJson(JsonObject json, string path)
        {
            if (File.Exists(path))
            {
               DialogResult result = MessageBox.Show("are you sure you want to overwrite this file?", "file already exists",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                if (result == DialogResult.No)
                {
                    return false;
                }
            }
            String file = JsonConvert.SerializeObject(json);
            File.WriteAllText(path,file);
            return true;
        }
    }
}
