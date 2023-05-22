using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using DevExpress.Drawing;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Native;
using DevExpress.Drawing.Printing;

namespace reportMerging {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            PrintHelper p = new PrintHelper(new List<XtraReport> { new XtraReport1(), new XtraReport2()});
            p.CreateDocument();
            p.ShowPreview();
        }
    }
    public class PrintHelper {
        List<XtraReport> reports;
        Link link;
        public PrintHelper(List<XtraReport> reports) {
            this.reports = reports;
            link = new Link(new PrintingSystem());
            int height = 0, width = 0;
            foreach (XtraReport x in reports) {
                height += x.PageHeight;
                width = Math.Max(width, x.PageWidth);
            }
            link.PaperKind = DXPaperKind.Custom;
            link.CustomPaperSize = new Size(width, height);
            link.Margins = new DXMargins(reports.First<XtraReport>().Margins.Left, reports.First<XtraReport>().Margins.Right, reports.First<XtraReport>().Margins.Top, reports.Last<XtraReport>().Margins.Bottom);
            link.CreateDetailArea += link_CreateDetailArea;
        }
        public void CreateDocument() {
            link.CreateDocument();
        }
        public void ShowPreview() {
            link.ShowPreview();
        }
        void link_CreateDetailArea(object sender, CreateAreaEventArgs e) {
            int maxPages = 0;
            foreach (XtraReport x in reports) {
                x.CreateDocument();
                maxPages = Math.Max(maxPages, x.Pages.Count);
            }
            SizeF pageSize = e.Graph.ClientPageSize;
            float sectionHeight = reports != null && reports.Count() > 1 ? pageSize.Height / reports.Count() : 0;
            PanelBrick section;
            for (int pageIndex = 0; pageIndex < maxPages; pageIndex++)
            {
                for (int sectionIndex = 0; sectionIndex < reports.Count; sectionIndex++) {
                    section = new PanelBrick { Size = new SizeF(e.Graph.ClientPageSize.Width, sectionHeight), BorderWidth=0};
                    if (reports[sectionIndex].Pages.Count < pageIndex + 1) {
                        section.Bricks.Add(new LineBrick() {
                            Rect = section.Rect,
                            LineDirection = DevExpress.XtraReports.UI.LineDirection.Slant,
                            ForeColor = Color.Red,
                            LineStyle = DXDashStyle.Dash,
                            BorderWidth = 0
                        });
                        section.Bricks.Add(new LineBrick() {
                            Rect = section.Rect,
                            LineDirection = DevExpress.XtraReports.UI.LineDirection.BackSlant,
                            ForeColor = Color.Red,
                            BackColor = Color.Transparent,
                            LineStyle = DXDashStyle.Dash,
                            BorderWidth = 1,
                            BorderColor = Color.Red,
                            BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash,
                            BorderStyle = BrickBorderStyle.Inset
                        });
                    } else {
                        foreach (Brick brick in ((PSPage)reports[sectionIndex].Pages[pageIndex]).Bricks) {
                            section.Bricks.Add(brick);
                        }
                    }
                    e.Graph.Modifier = BrickModifier.None;
                    e.Graph.Modifier = BrickModifier.Detail;
                    e.Graph.DrawBrick(section);
                }
            }
        }
    }
}
