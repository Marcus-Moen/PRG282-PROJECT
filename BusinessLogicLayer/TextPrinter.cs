using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.BusinessLogicLayer
{
    public class TextPrinter
    {
        private PrintDocument printDocument = new PrintDocument();
        private string textToPrint;
        private Font printFont;
        private int currentCharIndex = 0;

        public TextPrinter(string text)
        {
            textToPrint = text;
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        public void Print()
        {
            try
            {
                printFont = new Font("Arial", 12);
                printDocument.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while printing: " + ex.Message);
            }
        }

        public void ShowPrintPreview()
        {
            try
            {
                printFont = new Font("Arial", 12);
                PrintPreviewDialog previewDialog = new PrintPreviewDialog
                {
                    Document = printDocument,
                    Width = 800,
                    Height = 600
                };
                previewDialog.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while previewing: " + ex.Message);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Define the heading text and font
            string heading = "Summary";
            Font headingFont = new Font("Arial", 16, FontStyle.Bold);

            // Calculate the position for the heading
            float headingX = e.MarginBounds.Left;
            float headingY = e.MarginBounds.Top - headingFont.GetHeight(e.Graphics) - 10; // Adjust to move the heading above the content

            // Draw the heading
            e.Graphics.DrawString(heading, headingFont, Brushes.Black, headingX, headingY);

            // Draw a line below the heading for separation
            e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, headingY + headingFont.GetHeight(e.Graphics) + 2, e.MarginBounds.Right, headingY + headingFont.GetHeight(e.Graphics) + 2);

            // Main content position
            float contentY = e.MarginBounds.Top + headingFont.GetHeight(e.Graphics) + 10;

            float linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics);
            int charsFitted, linesFilled;

            RectangleF printArea = new RectangleF(e.MarginBounds.Left, contentY, e.MarginBounds.Width, e.MarginBounds.Height - headingFont.GetHeight(e.Graphics) - 20);
            e.Graphics.MeasureString(
                textToPrint.Substring(currentCharIndex),
                printFont,
                printArea.Size,
                new StringFormat(),
                out charsFitted,
                out linesFilled
            );

            // Print the main body text
            e.Graphics.DrawString(
                textToPrint.Substring(currentCharIndex, charsFitted),
                printFont,
                Brushes.Black,
                printArea
            );

            currentCharIndex += charsFitted;

            e.HasMorePages = currentCharIndex < textToPrint.Length;

            string footer = $"Time Stamp {DateTime.Now}";
            e.Graphics.DrawString(footer, new Font("Arial", 10, FontStyle.Italic), Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Bottom + 10);
        }
    }
}
