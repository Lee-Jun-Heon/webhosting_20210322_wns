using CarFixMgr0611.Handler;
using CarFixMgr0611.Model;
using CarFixMgr0611.Util;
using MaterialSkin.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarFixMgr0611.UI
{
    public partial class ReceiptForm : MaterialForm
    {
        ReceiptAdapter adapter;
        public ReceiptForm()
        {
            InitializeComponent();
        }

        public ReceiptForm(ReceiptAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;

        }

        private void receiptSave_Click(object sender, EventArgs e)
        {
            string name = custName.Text;
            string telH = custTelH.SelectedText;
            string telB = custTelB.Text;
            string year = custYear.SelectedText;
            string month = custMonth.SelectedText;
            string day = custDay.SelectedText;
            string model = carModel.SelectedText;
            string number = carNum.Text;
            string cc = CarCC.SelectedText;
            string caryear = carYear.SelectedText;
            string staffname = staffName.SelectedText;

            /*if (name.Equals("") || telB.Equals("") || number.Equals(""))
            {
                MessageBox.Show("빈칸을 입력하세요", "빈칸", MessageBoxButtons.OK);
                ActiveControl = custName;
                custName.Focus();
                ActiveControl = custTelB;
                custTelB.Focus();
                ActiveControl = carNum;
                carNum.Focus();
                return;
            }
            
            if (telH.Equals(""))
            {
                MessageBox.Show("전화번호 앞자리를 선택하세요", "선택", MessageBoxButtons.OK);
                ActiveControl = custTelH;
                custTelH.Focus();
                return;
            }*/

            string[] arrData = new string[]
            {
                name, telH, telB, year, month, day, model, number, cc, caryear, staffname
            };

            object[] arrObj = new object[]
            {
                custName, custTelH, custTelB, custYear,
                custMonth, custDay, carModel, carNum, CarCC, carYear, staffName
            };

            string[] arrMsg = new string[]
            {
                "빈칸을 입력하세요",
                "전화번호 앞자리를 선택하세요",
                "전화번호 뒷자리를 선택하세요",
                "년도를 선택하세요",
                "월을 선택하세요",
                "일을 선택하세요",
                "차량모델을 선택하세요",
                "차량번호를 입력하세요",
                "배기량을 선택하세요",
                "차량연식을 선택하세요",
                "담당자를 선택하세요"
            };

            for (int i = 0; i < arrData.Length; i++)
            {
                if (arrData[i].Equals("") || arrData[i].Equals("선택"))
                {
                    MessageBox.Show(arrMsg[i], "빈칸", MessageBoxButtons.OK);
                    ActiveControl = arrObj[i] as Control;
                    ActiveControl.Focus();
                    return;
                }
            }

            UICheckBox[] checkBox = new UICheckBox[]
            {
                chk1, chk2, chk3, chk4, chk5, chk6, chk7, chk8, chk9, chk10
            };

            List<RepairItem> itemList = new List<RepairItem>();

            for (int i = RepairTable.ENGINE_OIL; i < RepairTable.ETC_COST + 1; i++)
            {
                if (checkBox[i].Checked)
                {
                    Console.WriteLine("수리항목 : " + checkBox[i].Text);
                    Console.WriteLine("수리비 : " + RepairTable.fixMoney[i]);
                    itemList.Add(new RepairItem(i, checkBox[i].Text, RepairTable.fixMoney[i]));
                }
            }

            if (itemList.Count == 0)
            {
                MessageBox.Show("수리항목을 체크하세요");
                return;
            }
            //한글 입력 체크
            string chkName = Regex.Replace(name, @"[^가-힣]", "");
            if (chkName.Length != name.Length)
            {
                MessageBox.Show("잘못된 이름형식입니다");
                ActiveControl = custName;
                ActiveControl.Focus();
                custName.Text = "";
                return;
            }
            //자리수 체크
            Regex regex = new Regex(@"[가-힣]{3}");
            Match m = regex.Match(name);
            if (m.Success == false)
            {
                MessageBox.Show("이름 자리수가 올바르지 않습니다");
                ActiveControl = custName;
                ActiveControl.Focus();
                custName.Text = "";
                return;
            }

            string telAll = telH + telB;
            if (telAll.Length == 10 || telAll.Length == 11)
            {
                Regex regex2 = new Regex(@"01{1}[01]{1}[0-9]{7,8}");
                Match m2 = regex2.Match(telAll);
                if (m2.Success == false)
                {
                    MessageBox.Show("잘못된 전화번호입니다");
                    return;
                }
            }
            else
            {
                MessageBox.Show("올바른 전화번호 자리수를 입력하세요");
                return;
            }

            MessageBox.Show("고객명 : " + name + "\n" + "전화번호 : " + (telH + telB) + "\n"
              + "생년월일 : " + (year + month + day) + "\n" + "차량모델 : " + model + "\n"
              + "차량번호 : " + number + "\n" + "배기량 : " + cc + "\n" + "차량연식 : " + caryear + "\n"
              + "담당자 : " + staffname, "고객정보", MessageBoxButtons.OK);
            /*console.WriteLine("전화번호 : " + (telH + telB));
            console.WriteLine("생년월일 : " + (year + month + day));
            console.WriteLine("차량모델 : " + model);
            console.WriteLine("차량번호 : " + number);
            console.WriteLine("배기량 : " + cc);
            Console.WriteLine("차량연식 : " + caryear);
            Console.WriteLine("담당자 : " + staffname);*/

            adapter.addReceipt(new Receipt(
                new Customer(name, telH + telB, year + month + day),
                new Car(model, number, cc, caryear),
                DateTime.Now.ToString("yyyy년MM월dd일"),
                staffname, itemList));
        }


        private void receiptClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
