using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Office.Core;
using PPT = Microsoft.Office.Interop.PowerPoint;

namespace PptxVolumeEditorApp
{
    public partial class Form1 : Form
    {
        string orgFileName="";
        string modifiedFileName = "";

        public Form1()
        {
            InitializeComponent();
        }



        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (! File.Exists(orgFileName))
            {
                return;
            }

            try
            {

                var file = new PPT.Application().Presentations.Open(orgFileName, MsoTriState.msoTrue, MsoTriState.msoFalse, MsoTriState.msoFalse);

                foreach (PPT.Slide slide in file.Slides)
                {
                    foreach (PPT.Shape shape in slide.Shapes)
                    {
                        if (shape.Type == MsoShapeType.msoMedia)
                        {
                            if (shape.MediaType == PPT.PpMediaType.ppMediaTypeMovie || shape.MediaType == PPT.PpMediaType.ppMediaTypeSound)
                            {
                                if (checkBoxVolume.Checked == true)
                                {
                                    shape.MediaFormat.Volume = (float)numericUpDownVolume.Value / 100.0f;
                                }
                                if (radioButtonUnmuteAll.Checked == true)
                                {
                                    shape.MediaFormat.Muted = false;
                                }
                                else if (radioButtonMuteAll.Checked == true)
                                {
                                    shape.MediaFormat.Muted = true;
                                }

                            }
                        }
                    }

                }


                file.SaveAs(modifiedFileName);

                file.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string tmpFileName = files[files.Length - 1];
            orgFileName = tmpFileName;
            modifiedFileName = System.IO.Path.GetDirectoryName(tmpFileName) + "\\" + System.IO.Path.GetFileNameWithoutExtension(tmpFileName) + "_Modified" + System.IO.Path.GetExtension(tmpFileName);

            labelOrgFileName.Text = System.IO.Path.GetFileName(orgFileName); ;
            labelModifiedFileName.Text = System.IO.Path.GetFileName(modifiedFileName);
        }
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
