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
    public partial class MonitorPara : Form
    {
        public MonitorPara()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MonitorParaInsertOrEditData monitorParaInsertOrEditData = new MonitorParaInsertOrEditData();
            monitorParaInsertOrEditData.ShowDialog();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtn_insert_Click(object sender, EventArgs e)
        {
            MonitorParaInsertOrEditData monitorParaInsertOrEditData = new MonitorParaInsertOrEditData();
            monitorParaInsertOrEditData.ShowDialog();
        }
    }
}
