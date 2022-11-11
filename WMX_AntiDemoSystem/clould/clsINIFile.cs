using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//Directroy를 만들기 위해서 쓰기위한 사용
using System.Runtime.InteropServices;//ini파일관리
using System.Windows.Forms;

namespace WMX_Anti
{
    class clsINIFile
    {
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,
            string key, string def, StringBuilder retVal, int size, string filePath);
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,
            string key, string val, string filePath);

        //ini File Read
        /// <summary>
        /// INI File Read(str)
        /// </summary>
        /// <param name="section"></param>
        /// <param name="key"></param>
        /// <param name="iniFilePath"></param>
        /// <returns></returns>


        // File/Folder 생성(using System.IO;//Directroy를 만들기 위해서 쓰기위한 사용)
        public static void NewMakeFileFolder(string FilePatch, string FileName, string FileExtension)
        {
            //파일 생성
            //string sFile = FilePatch + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + "#" + filename + ".ini";
            string sFile = FilePatch + "\\" + FileName + FileExtension;

            try
            {
                //Folder 생성
                //string currentdirectory = Directory.GetCurrentDirectory();
                if (!Directory.Exists(FilePatch))
                {
                    Directory.CreateDirectory(FilePatch);
                }

                //파일 생성
                if (!File.Exists(sFile))
                {
                    using (StreamWriter sw = File.CreateText(sFile))
                    {
                    }
                }
            }
            catch
            {
                MessageBox.Show(sFile + "File or Directory Create Error", "Error Display", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //frmError ErrorForm = new frmError();  // 에러폼 정의       
                //cpPublicData.General.sErrorMsgLog = "File or Directory Create Error" + "Error Display";
                //ErrorForm.ShowDialog();

            }
        }

        // Folder 생성(using System.IO;//Directroy를 만들기 위해서 쓰기위한 사용)
        public static void NewMakeFolder(string FilePatch)
        {
            try
            {
                //Folder 생성
                //string currentdirectory = Directory.GetCurrentDirectory();
                if (!Directory.Exists(FilePatch))
                {
                    Directory.CreateDirectory(FilePatch);
                }
            }
            catch
            {
                MessageBox.Show(FilePatch + " Folder Create Error", "Error Display", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //frmError ErrorForm = new frmError();  // 에러폼 정의  
                //cpPublicData.General.sErrorMsg = " Folder Create Error" + "Error Display";
                //ErrorForm.ShowDialog();
            }
        }
        // (폴더가 존재할때)File만 생성(using System.IO;//Directroy를 만들기 위해서 쓰기위한 사용)
        public static void NewMakeFile(string FileFullName)
        {
            //파일 생성(파일경로를 포함함 파일 생성(폴더는 존재해야함)
            try
            {
                //파일 생성
                if (!File.Exists(FileFullName))
                {

                    using (StreamWriter sw = File.CreateText(FileFullName))
                    {
                    }
                }
            }
            catch
            {
                MessageBox.Show(FileFullName + "File Create Error", "Error Display", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //frmError ErrorForm = new frmError();  // 에러폼 정의  
                //cpPublicData.General.sErrorMsg = "File Create Error" + "Error Display";                
                //ErrorForm.ShowDialog();
            }
        }

        // INI 값 읽기
        public static String GetValue(String section, String key, String iniFilePath)
        {
            try
            {
                StringBuilder sbTemp = new StringBuilder(255);
                int i = GetPrivateProfileString(section, key, "", sbTemp, 255, iniFilePath);
                return sbTemp.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("[" + ex.Message + "]");
                return "Error";
            }
        }
        // INI 값 설정 
        public static bool SetValue(String section, String key, String value, String iniFilePath)
        {
            try
            {
                WritePrivateProfileString(section, key, value, iniFilePath);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("[" + ex.Message + "]");
                return false;
            }
        }

    }
}
