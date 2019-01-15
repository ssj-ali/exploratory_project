using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Geometry;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using Autodesk.AutoCAD.EditorInput;
namespace PluginCsv
{
    public class Class1
    {
        [CommandMethod("BHL")]
        public void BHL()
        {
            var BHL = new Form1();
            BHL.Show();

        }

    }
}
