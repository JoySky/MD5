using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Hash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (txtMD5.Text.Trim()==""||txtSHA1.Text.Trim()=="")
            {
                MessageBox.Show("请把文件拖拽到程序界面中进行计算!", "提示");
                return;
            }
            bool isMd5 = false;
            bool isSha1 = false;
            if (txtMD5.Text.ToLower().Trim() == txtCompareMD5.Text.ToLower().Trim())
            {
                isMd5 = true;
            }
            if (txtSHA1.Text.ToLower().Trim() == txtCompareSHA1.Text.ToLower().Trim())
            {
                isSha1 = true;
            }
            if (isMd5==true&&isSha1==true)
            {
                MessageBox.Show("MD5匹配!\nSHA1匹配!","提示");
                return;
            }
            if (isMd5==true&&isSha1==false)
            {
                MessageBox.Show("MD5匹配!\nSHA1不匹配!", "提示");
                return;
            }
            if (isMd5 == false && isSha1 == true)
            {
                MessageBox.Show("MD5不匹配!\nSHA1匹配!", "提示");
                return;
            }
            if (isMd5 == false && isSha1 == false)
            {
                MessageBox.Show("MD5不匹配!\nSHA1不匹配!", "提示");
                return;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请将需要计算MD5以及SHA1的文件直接拖拽到程序界面内即可自动计算!\nCode By JoySky 2014/5/27\n如需帮助,请发送邮件至joysky@outlook.com", "提示");
            return;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string filePath = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            if (Directory.Exists(filePath))
            {
                MessageBox.Show("不支持文件夹计算!", "提示");
                return;
            }
            txtMD5.Text = "正在计算...";
            txtSHA1.Text = "正在计算...";
            txtFilePath.Text = filePath;
            string md5 = MD5File(filePath);
            string sha1 = SHA1File(filePath);
            txtMD5.Text = md5;
            txtSHA1.Text = sha1;
            
        }

        /// <summary>
        /// 计算文件的 MD5 值
        /// </summary>
        /// <param name="fileName">要计算 MD5 值的文件名和路径</param>
        /// <returns>MD5 值16进制字符串</returns>
        public static string MD5File(string fileName)
        {
            return HashFile(fileName, "md5");
        }
        public static string SHA1File(string fileName)
        {
            return HashFile(fileName, "sha1");
        }

        /// <summary>
        /// 计算文件的哈希值
        /// </summary>
        /// <param name="fileName">要计算哈希值的文件名和路径</param>
        /// <param name="algName">算法:sha1,md5</param>
        /// <returns>哈希值16进制字符串</returns>
        public static string HashFile(string fileName, string algName)
        {
            if (!System.IO.File.Exists(fileName))
                return string.Empty;

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            byte[] hashBytes = HashData(fs, algName);
            fs.Close();
            return ByteArrayToHexString(hashBytes);
        }

        /// <summary>
        /// 计算哈希值
        /// </summary>
        /// <param name="stream">要计算哈希值的 Stream</param>
        /// <param name="algName">算法:sha1,md5</param>
        /// <returns>哈希值字节数组</returns>
        public static byte[] HashData(Stream stream, string algName)
        {
            HashAlgorithm algorithm;
            if (algName == null)
            {
                throw new ArgumentNullException("algName 不能为 null");
            }
            if (string.Compare(algName, "sha1", true) == 0)
            {
                algorithm = SHA1.Create();
            }
            else
            {
                if (string.Compare(algName, "md5", true) != 0)
                {
                    throw new Exception("algName 只能使用 sha1 或 md5");
                }
                algorithm = MD5.Create();
            }
            return algorithm.ComputeHash(stream);
        }

        /// <summary>
        /// 字节数组转换为16进制表示的字符串
        /// </summary>
        public static string ByteArrayToHexString(byte[] buf)
        {
            string returnStr = "";
            if (buf != null)
            {
                for (int i = 0; i < buf.Length; i++)
                {
                    returnStr += buf[i].ToString("X2");
                }
            }
            return returnStr;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
