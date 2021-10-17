using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evidencija_Putnog_Troska
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void UNOS_Click(object sender, EventArgs e)
        {
            string filePath = "D:\\Izvjesce.xlsx";


            FileInfo file = new FileInfo(filePath);

            using (ExcelPackage excelPackage = new ExcelPackage(file))
            {

                //string mjesecGodina = MjesecGodina.Text;
                //string[] result = mjesecGodina.Split('/');
                //int mjesec = int.Parse(result[0]);
                //int godina = int.Parse(result[1]);


                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];

                int dan = 1;
                int mjesec = Convert.ToInt32(MJESEC.Value);
                int godina = Convert.ToInt32(GODINA.Value);
                DateTime datum = new DateTime(godina, mjesec, 1);

                worksheet.Cells["C5"].Value = IME.Text;
                worksheet.Cells["A9"].Value = mjesec + "/" + godina;

                decimal brDana = BrDana.Value;
                for (int i = 0; i < brDana; i++)
                {
                    worksheet.Cells[10 + i, 1].Value = (dan + i) + "." + mjesec + "." + godina + ".";
                    worksheet.Cells[10 + i, 2].Value = KM_Dolazak.Value;
                    worksheet.Cells[10 + i, 3].Value = KM_Odlazak.Value;
                    worksheet.Cells[10 + i, 4].Value = PrijevoznoSredtsvo.Text;
                    worksheet.Cells[10 + i, 5].Value = IME.Text;

                }
                worksheet.Cells[38, 3].Value = DATUM.Value;
                worksheet.Cells[39, 3].Value = Naknada.Value;

                excelPackage.Save();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "D:\\Izvjesce.xlsx";


            FileInfo file = new FileInfo(filePath);

            using (ExcelPackage excelPackage = new ExcelPackage(file))
            {

                


                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];

               

                worksheet.Cells["C5"].Value = null;
                worksheet.Cells["A9"].Value = null;

                
                for (int i = 0; i < 24; i++)
                {
                    worksheet.Cells[10 + i, 1].Value = null;
                    worksheet.Cells[10 + i, 2].Value = null;
                    worksheet.Cells[10 + i, 3].Value = null;
                    worksheet.Cells[10 + i, 4].Value = null;
                    worksheet.Cells[10 + i, 5].Value = null;

                }
                worksheet.Cells[38, 3].Value = null;
                worksheet.Cells[39, 3].Value = null;

                excelPackage.Save();


            }


        }
    }
}
