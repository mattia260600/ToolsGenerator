using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ToolsGeneratorModel
{
    class Tool
    {
        public Tool(int index, Tool tool)
        {
            Index = index;
            
        }

        public Tool(XElement general, IEnumerable<XElement> allParameters)
        {
            _general = general;
            _allParameters = new List<XElement>(allParameters);
        }

        public int Index { get; }
        public string Name { get; }

        private XElement _general;
        private List<XElement> _allParameters;
        

    }
}
