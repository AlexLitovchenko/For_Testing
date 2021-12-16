using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinCard.bin = Bin.Text;
          ExportExcel();

            Operations oper = new Operations();
            Minus.Visible = true;
            Minus.Text = oper.Write_off();
            Plus.Visible = true;
            Plus.Text = oper.Refill();

        }

        private void Plus_TextChanged(object sender, EventArgs e)
        {

        }

       
       


private void ExportExcel()
        {
        
      
                OpenFileDialog ofd1 = new OpenFileDialog();
        
            ofd1.Title = "Выберите файл базы данных";
            if (!(ofd1.ShowDialog() == DialogResult.OK)) { }

                Excel.Application ObjWorkExcel = new Excel.Application();
                Excel.Workbook ObjWorkBook = ObjWorkExcel.Workbooks.Open(ofd1.FileName);
                Excel.Worksheet ObjWorkSheet = (Excel.Worksheet)ObjWorkBook.Sheets[1];
                var lastCell = ObjWorkSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);
                                                                                                   
                int lastColumn = (int)lastCell.Column;
                int lastRow = (int)lastCell.Row;
               
                var j = 2;
                int i;
                for (i = 0; i < lastRow; i++) 
                {
                    if (BinCard.bin == ObjWorkSheet.Cells[i + 1, j].Text.ToString())
                    {
                        break;
                    }
                }
                BinCard.brand = ObjWorkSheet.Cells[i + 1, 3].Text.ToString();
                BinCard.bank_name = ObjWorkSheet.Cells[i + 1, 4].Text.ToString();
                BinCard.bin_type = ObjWorkSheet.Cells[i + 1, 5].Text.ToString();
                BinCard.bin_level = ObjWorkSheet.Cells[i + 1, 6].Text.ToString();
              BinCard.isocountry = ObjWorkSheet.Cells[i + 1, 7].Text.ToString(); ;
                BinCard.country_iso1 = ObjWorkSheet.Cells[i + 1, 8].Text.ToString();
            BinCard.country_iso2 = ObjWorkSheet.Cells[i + 1, 9].Text.ToString();
            BinCard.country_iso3 = ObjWorkSheet.Cells[i + 1, 10].Text.ToString();

           
            ObjWorkBook.Close(false, Type.Missing, Type.Missing); 
                ObjWorkExcel.Quit(); 
                GC.Collect();
            
}





        }
    }
    
