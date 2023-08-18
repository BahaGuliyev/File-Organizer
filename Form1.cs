using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fayl_orqanayzer_proqramının_hazırlanması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string uzanti;
        private void button1_Click(object sender, EventArgs e)
        {
            /*using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    //Bir bir fayllara baxis edek
                    foreach (var file in files)
                    {
                        //Faylin uzantisini goturek
                        var ext = System.IO.Path.GetExtension(file);
                        //Text faylları üçün
                        if (ext.Equals(".txt", StringComparison.CurrentCultureIgnoreCase) || ext.Equals(".pdf", StringComparison.CurrentCultureIgnoreCase) || ext.Equals(".doc", StringComparison.CurrentCultureIgnoreCase))
                        {
                            if (!Directory.Exists(fbd.SelectedPath + "\\Mətn Faylları"))
                            {
                                Directory.CreateDirectory(fbd.SelectedPath + "\\Mətn Faylları");
                            }
                            string MoveTo = fbd.SelectedPath + "\\Mətn Faylları\\" + Path.GetFileName(file);
                            File.Move(file, MoveTo);
                        }
                        //Sekiller ucun
                        if (ext.Equals(".img", StringComparison.CurrentCultureIgnoreCase) || ext.Equals(".png", StringComparison.CurrentCultureIgnoreCase) || ext.Equals(".jpg", StringComparison.CurrentCultureIgnoreCase) || ext.Equals(".jpeg", StringComparison.CurrentCultureIgnoreCase) || ext.Equals(".png", StringComparison.CurrentCultureIgnoreCase))
                        {
                            if (!Directory.Exists(fbd.SelectedPath + "\\Şəkillər"))
                            {
                                Directory.CreateDirectory(fbd.SelectedPath + "\\Şəkillər");
                            }
                            string MoveTo = fbd.SelectedPath + "\\Şəkillər\\" + Path.GetFileName(file);
                            File.Move(file, MoveTo);
                        }
                        //Videolar ucun
                        if (ext.Equals(".mp4", StringComparison.CurrentCultureIgnoreCase) || ext.Equals(".mov", StringComparison.CurrentCultureIgnoreCase))
                        {
                            if (!Directory.Exists(fbd.SelectedPath + "\\Videolar"))
                            {
                                Directory.CreateDirectory(fbd.SelectedPath + "\\Videolar");
                            }
                            string MoveTo = fbd.SelectedPath + "\\Videolar\\" + Path.GetFileName(file);
                            File.Move(file, MoveTo);
                        }
                        //Musiqiler ucun
                        if (ext.Equals(".mp3", StringComparison.CurrentCultureIgnoreCase))
                        {
                            if (!Directory.Exists(fbd.SelectedPath + "\\Musiqilər"))
                            {
                                Directory.CreateDirectory(fbd.SelectedPath + "\\Musiqilər");
                            }
                            string MoveTo = fbd.SelectedPath + "\\Musiqilər\\" + Path.GetFileName(file);
                            File.Move(file, MoveTo);
                        }
                    }
                }
            }*/

                if (!string.IsNullOrWhiteSpace(uzanti))
                {
                    string[] files = Directory.GetFiles(uzanti);
                    //Bir bir fayllara baxis edek
                    foreach (var file in files)
                    {
                        //Faylin uzantisini goturek
                        var ext = System.IO.Path.GetExtension(file);
                        //Text faylları üçün
                        if (ext.Equals(".txt", StringComparison.CurrentCultureIgnoreCase) || ext.Equals(".pdf", StringComparison.CurrentCultureIgnoreCase) || ext.Equals(".doc", StringComparison.CurrentCultureIgnoreCase))
                        {
                            if (!Directory.Exists(uzanti + "\\Mətn Faylları"))
                            {
                                Directory.CreateDirectory(uzanti + "\\Mətn Faylları");
                            }
                            string MoveTo = uzanti + "\\Mətn Faylları\\" + Path.GetFileName(file);
                            File.Move(file, MoveTo);
                        }
                        //Sekiller ucun
                        if (ext.Equals(".img", StringComparison.CurrentCultureIgnoreCase) || ext.Equals(".png", StringComparison.CurrentCultureIgnoreCase) || ext.Equals(".jpg", StringComparison.CurrentCultureIgnoreCase) || ext.Equals(".jpeg", StringComparison.CurrentCultureIgnoreCase) || ext.Equals(".png", StringComparison.CurrentCultureIgnoreCase))
                        {
                            if (!Directory.Exists(uzanti + "\\Şəkillər"))
                            {
                                Directory.CreateDirectory(uzanti + "\\Şəkillər");
                            }
                            string MoveTo = uzanti + "\\Şəkillər\\" + Path.GetFileName(file);
                            File.Move(file, MoveTo);
                        }
                        //Videolar ucun
                        if (ext.Equals(".mp4", StringComparison.CurrentCultureIgnoreCase) || ext.Equals(".mov", StringComparison.CurrentCultureIgnoreCase))
                        {
                            if (!Directory.Exists(uzanti + "\\Videolar"))
                            {
                                Directory.CreateDirectory(uzanti + "\\Videolar");
                            }
                            string MoveTo = uzanti + "\\Videolar\\" + Path.GetFileName(file);
                            File.Move(file, MoveTo);
                        }
                        //Musiqiler ucun
                        if (ext.Equals(".mp3", StringComparison.CurrentCultureIgnoreCase))
                        {
                            if (!Directory.Exists(uzanti + "\\Musiqilər"))
                            {
                                Directory.CreateDirectory(uzanti + "\\Musiqilər");
                            }
                            string MoveTo = uzanti + "\\Musiqilər\\" + Path.GetFileName(file);
                            File.Move(file, MoveTo);
                        }
                    }
                }
            }

        DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\");
        private void Form1_Load(object sender, EventArgs e)
        {
            //get a list of the drives
            string[] drives = Environment.GetLogicalDrives();
            foreach (string drive in drives)
            {
                DriveInfo di = new DriveInfo(drive);
                int driveImage;
                
                switch (di.DriveType)    //set the drive's icon
                {
                    case DriveType.CDRom:
                        driveImage = 2;
                        break;
                    case DriveType.Network:
                        driveImage = 0;
                        break;
                    case DriveType.NoRootDirectory:
                        driveImage = 0;
                        break;
                    case DriveType.Unknown:
                        driveImage = 0;
                        break;
                    default:
                        driveImage = 0;
                        break;
                }
                TreeNode node = new TreeNode(drive.Substring(0, 1), driveImage, driveImage);
                node.Tag = drive;

                if (di.IsReady == true)
                    node.Nodes.Add("...");

                dirsTreeView1.Nodes.Add(node);
            }
            dirsTreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(dirsTreeView1_AfterSelect_1);

        }

        private void dirsTreeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
           
        }

        private void dirsTreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
        }

        private void dirsTreeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                {
                    e.Node.Nodes.Clear();

                    //get the list of sub direcotires
                    string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());
                    foreach (string dir in dirs)
                    {
                        DirectoryInfo di = new DirectoryInfo(dir);
                        TreeNode node = new TreeNode(di.Name, 1, 1);
                        try
                        {
                            //keep the directory's full path in the tag for use later
                            node.Tag = dir;

                            //if the directory has sub directories add the place holder
                            if (di.GetDirectories().Count() > 0)
                                node.Nodes.Add(null, "...", 0, 0);
                        }
                        catch (UnauthorizedAccessException)
                        {
                            //display a locked folder icon
                            node.ImageIndex = 1;
                            node.SelectedImageIndex = 1;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "DirectoryLister",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            e.Node.Nodes.Add(node);
                            uzanti = dir;
                            textBox1.Text = dir;
                        }
                    }
                }
            }
        }
    }
}