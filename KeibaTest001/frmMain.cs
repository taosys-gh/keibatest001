using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeibaTest001
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();


            try
            {
                string sid = null;
                //'引数 JVInit:ソフトウェアID
                int ReturnCode = 0;
                //'戻値

                //引数設定
                sid = "UNKNOWN";
                //***************
                //JVLink初期化
                //***************
                //※※※ JVInitは JVLinkメソッド使用前(但し、JVSetUIProPertiesを除く)に呼出す
                ReturnCode = axJVLink.JVInit(sid);

                //エラー判定
                //'エラー
                if (ReturnCode != 0)
                {
                   lblMesage.Text = "JVInitエラー:" + ReturnCode.ToString();
                    //終了
                    return;
                    //'正常
                }
                else
                {
                    lblMesage.Text = "JVInit正常終了:" + ReturnCode.ToString();
                }
            }
            catch (Exception ex)
            {
                lblMesage.Text = "異常終了:" + ex;
            }

        }

        private void cmdJVLinkDialog_Click(object sender, EventArgs e)
        {
            try
            {
                //JVLinkコントロールパネルを開く
                frmJVLinkDialog frmDialog = default(frmJVLinkDialog);
                frmDialog = new frmJVLinkDialog();
                frmDialog.ShowDialog(this);
                //'オーナーウィンドウに自画面を指定

                frmDialog.Dispose();
                frmDialog = null;

                //終了
                return;
            }
            catch
            {
            }
        }
    }
}
