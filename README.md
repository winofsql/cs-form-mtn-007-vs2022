# cs-form-mtn-007-vs2022

### ファンクションキーの利用
```cs
// *****************************************
// ファンクションキ－
// ( フォームの KeyPreview : True )
// *****************************************
private void Form1_KeyDown(object sender, KeyEventArgs e)
{
    if (this.ヘッド部.Enabled)
    {
        if (e.KeyCode == Keys.F4)
        {
            this.処理区分.Focus();
            this.処理区分.DroppedDown = true;
        }

        if (e.KeyCode == Keys.F6)
        {
            Form2 dialog = new Form2();
            DialogResult result = dialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                // フォーカス処理は戻ってから
                this.社員コード.Focus();
                this.社員コード.SelectAll();
            }
        }
    }

}
```
