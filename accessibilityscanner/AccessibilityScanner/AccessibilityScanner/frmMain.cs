using AccessibilityScanner.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessibilityScanner
{
    public partial class frmMain : Form
    {
        private HtmlDocument document;
        private IDictionary<HtmlElement, string> elementStyles = new Dictionary<HtmlElement, string>();
        int hoverTime = 0;
        HtmlElement hoveredElement = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            wbrMain.Navigate(txtURL.Text);
        }

        private void txtURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                btnGo.PerformClick();
            }
        }

        private void wbrMain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.document = this.wbrMain.Document;
            this.document.MouseOver += new HtmlElementEventHandler(document_MouseOver);
            this.document.MouseLeave += new HtmlElementEventHandler(document_MouseLeave);
        }

        private void document_MouseLeave(object sender, HtmlElementEventArgs e)
        {
            hoverTimer.Stop();
            hoverTime = 0;
            HtmlElement element = e.FromElement;
            if (this.elementStyles.ContainsKey(element))
            {
                string style = this.elementStyles[element];
                this.elementStyles.Remove(element);
                element.Style = style;
            }
            hoveredElement = null;
        }

        private void document_MouseOver(object sender, HtmlElementEventArgs e)
        {
            hoveredElement = e.ToElement;
            hoverTimer.Start();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.lblElementID.Text =
            this.lblElementType.Text =
            this.lblClasses.Text = 
            this.lblXpath.Text = "";
        }

        private String getXPath(HtmlElement element)
        {
            var savedId = element.Id;
            var uniqueId = Guid.NewGuid().ToString();
            element.Id = uniqueId;

            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(element.Document.GetElementsByTagName("html")[0].OuterHtml);
            element.Id = savedId;

            var node = doc.GetElementbyId(uniqueId);
            return node.XPath;
        }

        private void getAttributes(HtmlElement element)
        {
            this.flpAttributes.Controls.Clear();
            var savedId = element.Id;
            var uniqueId = Guid.NewGuid().ToString();
            element.Id = uniqueId;
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(element.Document.GetElementsByTagName("html")[0].OuterHtml);
            element.Id = savedId;
            var node = doc.GetElementbyId(uniqueId);
            foreach (HtmlAgilityPack.HtmlAttribute attri in node.Attributes)
            {
                ctlAttribute attribute = new ctlAttribute(attri.Name, attri.Value);
                this.flpAttributes.Controls.Add(attribute);
            }
        }

        private void hoverTimer_Tick(object sender, EventArgs e)
        {
            hoverTime++;
            lblHoverTime.Text = hoverTime.ToString();

            if (hoverTime == 3)
            {
                hoverTimer.Stop();
                hoverTime = 0;
                HtmlElement element = hoveredElement;
                if (!this.elementStyles.ContainsKey(element))
                {
                    string style = element.Style;
                    this.elementStyles.Add(element, style);
                    element.Style = style + "; background-color: #ffc;";
                    lblElementID.Text = element.Id ?? "(no id)";
                    lblElementType.Text = element.TagName;
                    lblClasses.Text = element.GetAttribute("className").ToString();
                    lblXpath.Text = getXPath(element);
                    getAttributes(element);
                }
            }
        }
    }
}
