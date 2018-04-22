using System;
using System.Collections.Generic;
using System.Text;

namespace TwiHighForms
{
    public interface ISaveAndLoad
    {
        void SaveData(string filename, string text);
        string LoadData(string filename);
        bool ClearData(string filename);
    }
}
