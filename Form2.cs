namespace cs_form_mtn_007_vs2022
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // *****************************************
        // ファンクションキ－
        // ( フォームの KeyPreview : True )
        // *****************************************
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                // このダイアログを閉じる
                this.Close();
                // このダイアログの終了時のフラグ
                this.DialogResult = DialogResult.OK;
                // 参照する為に modifiers を internal に
                ((Form1)this.Owner).社員コード.Text = "0001";
            }
        }


    }
}
