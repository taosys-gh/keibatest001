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
    public partial class frmJVLinkDialog : Form
    {
        public frmJVLinkDialog()
        {
            InitializeComponent();
        }

        private frmMain frmOwner;
        //'キャンセルフラグ
        private bool CancelFlag = false;
        //'JVOpen:総読込みファイル数
        private int ReadCount = 0;
        //'JVOpen:総ダウンロードファイル数
        private int DownloadCount = 0;
        //'JVOpen:最後にダウンロードしたファイルのタイムスタンプ
        private string LastFileTimeStamp = null;

        private void cmdStart_Click(object sender, EventArgs e)
        {


            try
            {
                string DataSpec = null;
                //'引数 JVOpen:ファイル識別子
                string FromDate = null;
                //'引数 JVOpen:データ提供日付FROM
                int DataOption = 0;
                //'引数 JVOpen:オプション
                int ReturnCode = 0;
                //'JVLink戻値

                //初期値設定
                tmrJVStatus.Enabled = false;
                ////'タイマー停止
                frmOwner = (frmMain)Owner;
                ////'親フォームを指定
                //CancelFlag = false;
                ////'キャンセルフラグ初期化
                //progressBar1.Value = 0;
                ////'プログレスバー初期化
                //progressBar2.Value = 0;

                //引数設定
                DataSpec = txtDataSpec.Text;
                FromDate = txtFromDate.Text;

                //if (rbtNormal.Checked == true)
                //{
                //    DataOption = 1;
                //}
                //else if (rbtIsthisweek.Checked == true)
                //{
                //    DataOption = 2;
                //}
                //else if (rbtSetup.Checked == true)
                //{
                //    DataOption = 3;
                //}

                //Cursor = Cursors.AppStarting();

                //**********************
                //JVLinkダウンロード処理
                //**********************
                //ReturnCode = frmOwner.axJVLink.JVOpen(DataSpec, FromDate, DataOption, ref ReadCount,ref DownloadCount,out LastFileTimeStamp);
                ReturnCode = frmOwner.axJVLink.JVRTOpen(DataSpec, FromDate);

                //エラー判定
                //'エラー
                if (ReturnCode != 0)
                {
                    txtLog.AppendText("ReturnCode:" + ReturnCode + "\r\n");
                    //終了処理
                    frmOwner.axJVLink.JVClose();
                    //'正常
                }
                else
                {
                    txtLog.AppendText("JVOpen正常終了:" + ReturnCode + "\r\n");
                    txtLog.AppendText("ReadCount:" + ReadCount + " , DownloadCount:" + DownloadCount + "\r\n");

                    //総ダウンロード数をチェック
                    //'総ダウンロード数=０
                    if (DownloadCount == 0)
                    {
                        //プログレスバー100％表示
                        progressBar1.Maximum = 100;
                        //'MAXを100に設定
                        progressBar1.Value = progressBar1.Maximum;
                        //'プログレスバー100％表示
                        Text = "ダウンロード完了";
                        //読込み処理
                        JVReading();
                        //終了処理
                        JVClosing();
                        //'総ダウンロード数が０以上
                    }
                    else
                    {
                        //初期値設定
                        Text = "ダウンロード中・・・";
                        progressBar1.Maximum = DownloadCount;
                        //'プログレスバーのＭＡＸ値設定
                        //タイマー始動：ダウンロード進捗率をプログレスバー表示
                        tmrJVStatus.Enabled = true;
                        //'ダウンロードステータスを監視する
                    }
                }

                //終了
                return;

            }
            catch
            {
                //Debug.WriteLine(Err.Description);
            }

        }


        //------------------------------------------------------------------------------------------------
        //　　読込処理 
        //------------------------------------------------------------------------------------------------
        public void JVReading()
        {
            try
            {
                string Buff = null;
                //'バッファ
                int BuffSize = 0;
                //'バッファサイズ
                string BuffName = null;
                //'バッファ名
                int JVReadingCount = 0;
                //'読込みファイル数
                int ReturnCode = 0;
                //'JVLink戻値
                byte[] bytData = new byte[1];
                //'JVGets用バッファポインタ

                ////初期値設定
                //progressBar2.Maximum = ReadCount;
                //JVReadingCount = 0;
                //progressBar2.Value = 0;
                //Text = "データ読込み中．．．(0/" + ReadCount + ")";

                //バッファ領域確保
                BuffSize = 110000;
                //Buff = new string(BuffSize);

                do
                {
                    //バックグラウンドでの処理
                    System.Windows.Forms.Application.DoEvents();

                    //キャンセルが押されたら処理を抜ける
                    if (CancelFlag == true)
                        return;

                    //**********************
                    //JVLink読込み処理
                    //**********************
                    ReturnCode = frmOwner.axJVLink.JVRead(out Buff, out BuffSize, out BuffName);
                    //ReturnCode = frmOwner.axJVLink.JVGets(ref obj , BuffSize,out BuffName);


                    if (ReturnCode > 0)
                    {
                        //正常
                        //bytData = new byte[1];
                        txtLog.AppendText(Buff + "\r\n [end_>0]");
                    }
                    else if (ReturnCode == -1)
                    {
                        //ファイルの切れ目
                        //ファイル名表示
                        txtLog.AppendText(BuffName + "\r\n [end_-1]");

                    }
                    else if (ReturnCode == 0)
                    {
                        txtLog.AppendText(BuffName + "\r\n [end_0]");
                        break;
                    }
                    else if (ReturnCode < -1)
                    {
                        txtLog.AppendText(BuffName + "\r\n [end_else]");

                        break;
                    }


                    ////エラー判定
                    //switch (ReturnCode)
                    //{
                    //    case  0:
                    //        //'正常

                    //        // JVReadが正常に終了した場合はバッファーの内容を画面に表示します。
                    //        // サンプルプログラムであるため単純に全てのデータを表示していますが、画面表示
                    //        // は時間のかかる処理であるため読み込み処理全体の実行時間が遅くなっています。
                    //        // 必要に応じて下の１行をコメントアウトするか他の処理に置き換えてください。
                    //        //Call frmOwner.PrintOut(Buff)
                    //        frmOwner.PrintOut(System.Text.Encoding.GetEncoding(932).GetString(bytData));
                    //        bytData = new byte[1];

                    //        break;
                    //    case -1:
                    //        //'ファイルの切れ目
                    //        //ファイル名表示
                    //        frmOwner.PrintFilelist(BuffName + ControlChars.CrLf);
                    //        frmOwner.PrintOut("JVRead File :" + ReturnCode + ControlChars.CrLf);
                    //        //プログレスバー表示
                    //        JVReadingCount = JVReadingCount + 1;
                    //        //'カウントアップ
                    //        progressBar2.Value = JVReadingCount;
                    //        Text = "データ読込み中．．．(" + JVReadingCount + "/" + ReadCount + ")";
                    //        break;
                    //    case 0:
                    //        //'全レコード読込み終了(EOF)
                    //        frmOwner.PrintOut("JVRead EndOfFile :" + ReturnCode + ControlChars.CrLf);
                    //        Text = "データ読込み完了(" + JVReadingCount + "/" + ReadCount + ")";
                    //        //終了
                    //        return;

                    //        break;
                    //    case -1:
                    //        //'エラー
                    //        frmOwner.PrintOut("JVReadエラー:" + ReturnCode + ControlChars.CrLf);
                    //        //終了
                    //        return;

                    //        break;
                    //}

                } while (true);
            }
            catch
            {
                //Debug.WriteLine(Err.Description);
            }
        }

        //------------------------------------------------------------------------------------------------
        //　　終了処理
        //------------------------------------------------------------------------------------------------
        private void JVClosing()
        {
            try
            {
                int ReturnCode = 0;
                //'JVLink戻値

                //***************
                //JVLink終了処理
                //***************
                ReturnCode = frmOwner.axJVLink.JVClose();


                ////'エラー
                //if (ReturnCode != 0)
                //{
                //    frmOwner.PrintOut("JVCloseエラー:" + Convert.ToString(ReturnCode) + ControlChars.CrLf);
                //    //'正常
                //}
                //else
                //{
                //    frmOwner.PrintOut("JVClose正常終了:" + Convert.ToString(ReturnCode) + ControlChars.CrLf);
                //}

                //終了
                return;
            }
            catch
            {
                //Debug.WriteLine(Err.Description);
            }
        }
    }
}
