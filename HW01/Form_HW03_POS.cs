using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW01
{
    public partial class Form_HW03_POS : Form
    {
        public Form_HW03_POS()
        {
            InitializeComponent();
        }
        //使用字典，儲存購物清單數量
        Dictionary<string, int> dicAmountList = new Dictionary<string, int>()
        {
            {"啤酒Beer", 0},
            {"龍舌蘭Tequila", 0},
            {"威士忌Whisky", 0},
            {"紅酒Wine", 0}
        };
        //使用字典，儲存物品價格
        Dictionary<string, int> dicPriceList = new Dictionary<string, int>()
        {
            {"啤酒Beer", 120},
            {"龍舌蘭Tequila", 180},
            {"威士忌Whisky", 350},
            {"紅酒Wine", 320}
        };

        int totalPrice;

        // 下單後，清空list，讀取字典內的數量和價格，寫回list
        void barBuy()
        {
            string ShopList = "";
            totalPrice = 0;
            Dictionary<string, int>.ValueCollection valueNum = dicAmountList.Values;
            Dictionary<string, int>.KeyCollection valueKey = dicAmountList.Keys;
            foreach (string keyword in valueKey)
            {
                int cupNum = dicAmountList[keyword];
                if(cupNum == 0)
                {
                    continue;
                }
                else
                {
                    int cupPrice = dicPriceList[keyword];
                    int sumPrice = cupNum * cupPrice;
                    totalPrice += sumPrice;
                    ShopList += keyword + " x" + cupNum + ",共NT$ " + sumPrice + "元\n";
                }
                labelShopListShow.Text = ShopList;
                labelPriceShow.Text = "NT$ " + totalPrice;
                
            }
        }

        private void btnMBeer_Click(object sender, EventArgs e)
        {
            dicAmountList["啤酒Beer"] += 1;            
            barBuy();
        }

        private void btnMTequila_Click(object sender, EventArgs e)
        {
            dicAmountList["龍舌蘭Tequila"] += 1;
            barBuy();
        }

        private void btnMWisky_Click(object sender, EventArgs e)
        {
            dicAmountList["威士忌Whisky"] += 1;
            barBuy();
        }

        private void btnMWine_Click(object sender, EventArgs e)
        {
            dicAmountList["紅酒Wine"] += 1;
            barBuy();
        }

        //清空字典內的數量，並顯示尚未點餐
        private void btnCleanList_Click(object sender, EventArgs e)
        {            
            dicAmountList["啤酒Beer"] = 0;
            dicAmountList["龍舌蘭Tequila"] = 0;
            dicAmountList["威士忌Whisky"] = 0;
            dicAmountList["紅酒Wine"] = 0;
            totalPrice = 0;
            labelShopListShow.Text = "尚未點餐";
            labelPriceShow.Text = "NT$ " + totalPrice;
        }

        private void btnPayCash_Click(object sender, EventArgs e)
        {
            if (totalPrice == 0)
            {
                MessageBox.Show("尚未點餐!", "確認付款",MessageBoxButtons.OK ,MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("總金額: NT$ " + totalPrice, "確認付款", MessageBoxButtons.YesNo);
            }
        }

        private void btnPayCredit_Click(object sender, EventArgs e)
        {
            if (totalPrice == 0)
            {
                MessageBox.Show("尚未點餐!", "確認付款", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                double disCount = totalPrice * 0.9;
                MessageBox.Show("總金額: NT$ " + totalPrice + "\n折扣金額: NT$ " + disCount, 
                    "確認付款", MessageBoxButtons.YesNo);
            }
        }
    }
}
