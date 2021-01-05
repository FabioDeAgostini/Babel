using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace BabelRevitAddin
{
    /*
     * setup translate https://cloud.google.com/translate/docs/setup?hl=it 
     * pricing and quota: https://cloud.google.com/translate/pricing
     * translate api guide: https://cloud.google.com/translate/docs/reference/rest/?apix=true
     * https://cloud.google.com/translate/docs/basic/translating-text?hl=it#translate_text_with_model-csharp
     * 
     * 
     */

    public class Babel : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            throw new NotImplementedException();
        }

        public Result OnStartup(UIControlledApplication application)
        {
            throw new NotImplementedException();
        }
    }
}
