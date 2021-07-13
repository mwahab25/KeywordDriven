using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeywordDriven.Config;
using KeywordDriven.Utils;
using KeywordDriven.Execution;
using System.IO;
using System.Reflection;

namespace KeywordDriven.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            try
            {
                string projectpath = txt_generallocation.Text + @"\" + txt_projectname.Text;
                string excelpath = projectpath + @"\Creation\Testcases.xlsx";
                string extentreportpath = projectpath + @"\TestResults\index.html";
                string logpath = projectpath + @"\Logs\log.txt";
                string apkpath = projectpath + @"\Resources\" + txt_apkpath.Text;

                ExcelSetting.Locators_Columns_Index(Convert.ToInt32(num_locpageobject.Value), Convert.ToInt32(num_loclocator.Value));
                ExcelSetting.TestCases_Columns_Index(Convert.ToInt32(num_tcid.Value), Convert.ToInt32(num_tctitle.Value), Convert.ToInt32(num_tcdesc.Value), Convert.ToInt32(num_tcrunmode.Value), Convert.ToInt32(num_tcresult.Value));
                ExcelSetting.TestSteps_Columns_Index(Convert.ToInt32(num_tstestcaseid.Value), Convert.ToInt32(num_tsstepno.Value), Convert.ToInt32(num_tsdesc.Value), Convert.ToInt32(num_tspageobject.Value), Convert.ToInt32(num_tsactionkeyword.Value), Convert.ToInt32(num_tsdataset.Value), Convert.ToInt32(num_tsresult.Value));
                
                ExcelManager.SetExcel(excelpath);
                ExtentReporter.SetExtentReporter(extentreportpath);
                Log.SetLogger(logpath);

                DriverSetting.WebDriver(combo_drivertype.Text, Convert.ToDouble(num_timeout.Text), Convert.ToDouble(num_navtimeout.Text), Convert.ToBoolean(combo_headless.Text));
                DriverSetting.AndroidDriver(txt_devicename.Text, txt_udid.Text, txt_platformversion.Text, apkpath);

                DriverScript.Execute_TestCases();

                ExtentReporter.Flush();
                ExcelManager.SaveCloseExcel();

                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_selectlocation_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

                DialogResult result = folderBrowserDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txt_generallocation.Text = folderBrowserDialog1.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_setup_Click(object sender, EventArgs e)
        {
            //File.WriteAllBytes(txt_excelpath.Text, Properties.Resources.TestCases);

            try
            {
                if (txt_generallocation.Text != "" && txt_projectname.Text != "")
                {
                    string projectpath = txt_generallocation.Text + @"\" + txt_projectname.Text;
                    string creationpath = projectpath + @"\Creation";
                    string resourcespath = projectpath + @"\Resources";
                    string reportpath = projectpath + @"\TestResults";
                    string logpath = projectpath + @"\Logs";


                    Directory.CreateDirectory(projectpath);
                    Directory.CreateDirectory(creationpath);
                    Directory.CreateDirectory(resourcespath);
                    Directory.CreateDirectory(reportpath);
                    Directory.CreateDirectory(logpath);

                    var assemblyPath = Assembly.GetExecutingAssembly().Location;
                    var assemblyParentPath = Path.GetDirectoryName(assemblyPath);

                    string fileName = "TestCases.xlsx";
                    string sourcePath = assemblyParentPath;


                    string sourceFile = Path.Combine(sourcePath, fileName);
                    string destFile = Path.Combine(creationpath, fileName);

                    File.Copy(sourceFile, destFile, true);

                    btn_Execute.Enabled = true;
                    btn_setup.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Please insert project location!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_checkproject_Click(object sender, EventArgs e)
        {
            string projectpath = txt_generallocation.Text + @"\" + txt_projectname.Text;
            string creationpath = projectpath + @"\Creation";

            string fileName = "TestCases.xlsx";
            string destFile = Path.Combine(creationpath, fileName);

            if (Directory.Exists(projectpath))
            {
                if (Directory.Exists(creationpath))
                {
                    if(File.Exists(destFile))
                    {
                        btn_setup.Enabled = false;
                        btn_Execute.Enabled = true;
                    }
                    else
                    {
                        btn_setup.Enabled = true;
                        btn_Execute.Enabled = false;
                    }
                }
                else
                {
                    btn_setup.Enabled = true;
                    btn_Execute.Enabled = false;
                }
            }
            else
            {
                btn_setup.Enabled = true;
                btn_Execute.Enabled = false;
            }
        }
    }
}
