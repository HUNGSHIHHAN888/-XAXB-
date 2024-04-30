namespace 視窗版本的XAXB_遊戲
{
    public partial class Form1 : Form
    {
        private XaXbEngine xaxb;//宣告一個名為xaxb的XaXbEngine物件
        private int counter;//宣告一個整數變數，叫做counter，用於計算玩家的猜測次數
        public Form1()
        {
            InitializeComponent();
            xaxb = new XaXbEngine();//創建一個新的XaXbEngine物件，命名為xaxb
            counter = 0;//初始化計數器由0開始計算
            luckyNumberLabel.Text = "請輸入不重複的三個數字(0~9) :  ";//在XAXB遊戲視窗上提醒玩家輸入的資料訊息
        }
        private void button1_Click(object sender, EventArgs e)//「檢測」按鈕事件處理方法
        {
            string usernumber = this.userInputTextBox.Text;//宣告一個字串叫usernumber，獲取玩家輸入的數字，顯示在userInputTextBox
            if (xaxb.IsLegal(usernumber))//如果輸入的數字是合法的
            {
                counter++;//計數器加1
                string result = xaxb.GetResult(usernumber);//宣告一個字串叫result，並獲取猜測結果
                resultLabel.Text = $"{usernumber} : {result}，猜測次數 : {counter}";//在resultLabel顯示猜測結果和猜測次數
                historyListBox.Items.Add($"第{counter}次 : {usernumber}········{result}");//將每次的猜測結果紀錄到historyListBox
                if (result == "3A0B")//如果猜測結果為3A0B
                {
                    historyListBox.Items.Add("恭喜你，猜對了!");//在historyListBox上顯示恭喜玩家的訊息
                    submitButton.Enabled = false;//如果猜對了禁止使用「檢測」按鈕，並且遊戲結束
                }
            }
            else//如果輸入的數字是不合法的
            {
                MessageBox.Show("輸入的資料重複, 或長度不對!! 請重新輸入!!");//顯示錯誤訊息讓玩家重新輸入數字
            }
        }
        public class XaXbEngine//定義一個類別叫做XaXbEngine
        {
            string luckynum;//宣告一個字串變數叫做luckynum，用於存儲幸運數字
            public XaXbEngine()
            {
                Random random = new Random();//創建一個Random物件，並命名為random，用於產生隨機數字
                int[] tem = new int[3];//創一個大小為3的整數陣列
                tem[0] = random.Next(0, 9);//隨機產生第一個數字
                tem[1] = random.Next(0, 9);//隨機產生第二個數字
                tem[2] = random.Next(0, 9);//隨機產生第三個數字
                while (tem[0] == tem[1] ^ tem[1] == tem[2] ^ tem[0] == tem[2])//確保三個數字不重複
                {
                    tem[1] = random.Next(0, 9);//重新產生第二個數字
                    tem[2] = random.Next(0, 9);//重新產生第三個數字
                }
                luckynum = $"{tem[0]}{tem[1]}{tem[2]}";//將隨機產生的三個數字組合成幸運數字
            }
            public bool SetLuckyNumber(String newLuckyNum)//設置幸運數字的方法
            {
                if (IsLegal(newLuckyNum))//如果新的幸運數字合法
                {
                    this.luckynum = newLuckyNum;//設置新的幸運數字
                    return true;//回傳設置成功
                }
                else//如果如果新的幸運數字不合法
                {
                    return false;//回傳設置不成功
                }
            }
            public string GetLuckyNumber()//獲取幸運數字的方法
            {
                return this.luckynum;//回傳幸運數字
            }
            public Boolean IsLegal(String theNumber)//檢查數字是否合法的方法
            {
                char[] tem = theNumber.ToCharArray();//將輸入的數字轉換為字元陣列

                if (tem.Length == 3)//如果數字長度為3
                {
                    if (tem[0] != tem[1] ^ tem[1] != tem[2] ^ tem[0] != tem[2])//如果三個數都不相同
                    {
                        return true;//回傳數字合法
                    }
                    else//如果數字有重複的
                    {
                        return false;//回傳數字不合法
                    }
                }
                else//如果數字長度不為3
                {
                    return false;//回傳數字不合法
                }
            }
            public string GetResult(String userNumber)//獲取猜測結果的方法
            {
                char[] user = userNumber.ToCharArray();//將玩家輸入的數字轉換為字元陣列
                char[] ans = this.luckynum.ToCharArray();//將幸運數字轉換為字元陣列
                int a = 0;//宣告一個整數變數a，用於紀錄輸入正確位置的數字數量
                int b = 0;//宣告一個整數變數b，用於紀錄輸入錯誤位置但包含在幸運數字中的數字數量
                for (int i = 0; i < user.Length; i++)//檢測玩家輸入的每個數字
                {
                    for (int j = 0; j < ans.Length; j++)//檢測幸運數字的每個數字
                    {
                        if (user[i] == ans[j])//如果玩家猜測的數字與幸運數字相同
                        {
                            if (i == j)//如果位置也一樣
                            {
                                a++;//a會加1
                            }
                            else//如果位置不一樣但是是包含在幸運數字中的數字
                            {
                                b++;//b會加1
                            }
                        }
                    }
                }
                return $"{a}A{b}B";//回傳猜測結果
            }
            public Boolean IsGameover(String userNumber)//檢查遊戲是否結束的方法
            {
                if (GetResult(userNumber) == "3A0B")//如果猜測結果為3A0B
                {
                    return true;//返回遊戲並結束
                }
                else//如果猜測結果不為3A0B
                {
                    return false;//返回遊戲並且還沒結束
                }
            }
        }
    }
}