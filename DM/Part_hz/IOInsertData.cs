using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DM
{
    public partial class IOInsertData : Form
    {

        //表单高度
        private float FormHeight;
        //表单宽度
        private float FormWidth;

        private AdaptFont adaptFont = new AdaptFont();
        Form2 form2 = new Form2();
        public IOInsertData()
        {
            InitializeComponent();

            
        }

        

        
        private void IOInsertData_Load(object sender, EventArgs e)
        {
            //自适应大小
            FormWidth = this.Width;
            FormHeight = this.Height;
            adaptFont.setTag(this);
        }

        private void IOInsertData_Resize(object sender, EventArgs e)
        {
            adaptFont.Resize(this.Width, this.Height, FormWidth, FormHeight, this);
        }

        private void sbtn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbtn_insert_Click(object sender, EventArgs e)
        {
            string filePath = "Data Source=" + "D:\\test.db;Version=3;";
            IOInformationEntity ioInfo = new IOInformationEntity();
            ioInfo.IoName = txt_ioname.Text;
            ioInfo.TrueText = txt_truetext.Text;
            ioInfo.FalseText = txt_falsetext.Text;
            ioInfo.IoType = Convert.ToInt32(cmbox_iotype.Text);
            ioInfo.Control = Convert.ToInt32(cmbox_control.Text);
            ioInfo.Addr1 = txt_addr1.Text;
            ioInfo.Addr2 = txt_addr2.Text;
            form2.InsertData(filePath, "t_ios", ioInfo);
            this.Close();


            MessageBox.Show("添加数据成功！");
            
            //form1.ShowDialog();
        }

       
    }
}
