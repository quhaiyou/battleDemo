using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WordCount
{
    public partial class Form1 : Form
    {
        Color m_Color;  
        Font m_Font;         
        public Form1()
        {
   
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {      
            listBoxIput.Items.Clear();
            string strRemove = Regex.Replace(textBoxGet.Text, @"[\p{P}*]", " "); 
            int iMax = 0 ;
            string[] strWordArr = Regex.Split(strRemove, @"\s"); 
            Dictionary<string, int> dicWord2Num = new Dictionary<string, int>();
            foreach (string strTemp in strWordArr)
            {
                if (strTemp.Length > iMax)
                {
                    iMax = strTemp.Length;
                }
                if (strTemp.ToLower() != "")
                {
                    if (!dicWord2Num.ContainsKey(strTemp.ToLower()))
                    {
                        dicWord2Num.Add(strTemp.ToLower(), 1);
                    }
                    else
                    {
                        int iTemp = dicWord2Num[strTemp.ToLower()];
                        dicWord2Num[strTemp.ToLower()] = iTemp + 1;
                    }
              }
            }

            IOrderedEnumerable<KeyValuePair<string,int>> result = dicWord2Num.OrderByDescending(u => u.Value);
             
            foreach (KeyValuePair<string, int> kv in result)
            {
                listBoxIput.Items.Add(kv.Key +strAdd(iMax-kv.Key.Length) + kv.Value);
            }  
        }
        string strAdd(int iLong)
        {
            string str="-----";
            for (int i=0; i < iLong; i++)
            {
                str += "-";
            }
            return str;
        }

        private void listBoxIput_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxGet.Select(0, textBoxGet.Text.Length);
            textBoxGet.SelectionColor = m_Color;
            textBoxGet.SelectionFont = m_Font;
            ListBox lstTemp = sender as ListBox;
            int nIndex = lstTemp.SelectedIndex;
            string strTemp = lstTemp.Items[nIndex] as string;
            string[] strArr = strTemp.Split('-');

            int index = textBoxGet.Find(strArr[0], RichTextBoxFinds.WholeWord);//调用find方法，并设置区分全字匹配  
            int startPos = index;
            int nextIndex = 0;
            while (nextIndex != startPos)//循环查找字符串，并用蓝色加粗12号Times New Roman标记之  
            {
                textBoxGet.SelectionStart = index;
                textBoxGet.SelectionLength = strArr[0].Length;
                textBoxGet.SelectionColor = Color.Blue;
                textBoxGet.SelectionFont = new Font("Times New Roman", (float)12, FontStyle.Bold);
                nextIndex = textBoxGet.Find(strArr[0], index + strArr[0].Length, RichTextBoxFinds.WholeWord);
                if (nextIndex == -1)//若查到文件末尾，则充值nextIndex为初始位置的值，使其达到初始位置，顺利结束循环，否则会有异常。  
                    nextIndex = startPos;
                index = nextIndex;
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_Color = textBoxGet.SelectionColor;
            m_Font = textBoxGet.SelectionFont;
        }
    }
}
