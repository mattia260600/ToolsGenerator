using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ToolsGeneratorModel;

namespace ToolsGeneratorInfrastructure
{
   public class ToolsRepository
    {
        private readonly string _fullFilePath;

        public ToolsRepository(string fullFilePath)
        {
            this._fullFilePath = fullFilePath;
        }

        public Tools Load()
        {
            Tools tools = new Tools();
            //Aggiungere controllo errori
            XDocument xDocument = XDocument.Load(_fullFilePath);


            return tools;

        }

    }
}
