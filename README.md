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
 
### F4 : 処理区分を選択して、リストを開く

![image](https://github.com/winofsql/cs-form-mtn-007-vs2022/assets/1501327/8bdc1979-f8d4-4d85-a4dc-ac7502897f18)

### F6 : Form2 をモーダルダイアログとして開く / ESC で閉じる

![image](https://github.com/winofsql/cs-form-mtn-007-vs2022/assets/1501327/ffee1b31-4080-4a5b-9a6a-cebdbdb51d08)

### ステータスバーに社員コードの入力説明を表示する

![image](https://github.com/winofsql/cs-form-mtn-007-vs2022/assets/1501327/d8921e2e-ffe9-45e3-92cb-f2d0ce117bd3)

![image](https://github.com/winofsql/cs-form-mtn-007-vs2022/assets/1501327/74fc74e8-e308-48ca-b69c-5111c03b6f5f)

