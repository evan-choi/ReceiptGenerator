using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Web;
using System.Web.UI;

namespace ReceiptGenerator_Web
{
    public partial class ReceiptGenerator : Page
    {
        protected string Name { get; set; }
        protected string Address { get; set; }
        protected string RReg { get; set; }
        protected string Date { get; set; }
        
        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.Name = Server.UrlDecode(Request.Cookies["name"]?.Value);
            this.Address = Server.UrlDecode(Request.Cookies["address"]?.Value);
            this.RReg = Request.Cookies["rreg"]?.Value;
            this.Date = DateTime.Now.ToLastDate().ToString("yyyy-MM-dd");

            chkSave.Checked = Name != null;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            Date = Request.Form["inputDate"];
            Name = Request.Form["i_name"];
            Address = Request.Form["i_address"];
            RReg = Request.Form["i_rreg"];

            if (chkSave.Checked)
            {
                SetCookie("name", Server.UrlEncode(Name));
                SetCookie("address", Server.UrlEncode(Address));
                SetCookie("rreg", RReg);
            }
            else
            {
                SetCookie("name", null);
                SetCookie("address", null);
                SetCookie("rreg", null);
            }

            //byte[] bin = Encoding.Default.GetBytes(DateTime.Now.ToBinary().ToString());

            //string baseDir = "Receipts";
            //string fileName = $"{baseDir}\\{Convert.ToBase64String(bin)}.jpg";

            //Server.MapPath(baseDir).CreateDirectory();

            Bitmap bmp = SWMaestro.ReceiptGenerator.Generate(
                Name,
                Address,
                RReg,
                DateTime.Parse(Date));
            
            //bmp.Save(Server.MapPath(fileName), ImageFormat.Jpeg);
            //Response.Redirect(fileName);

            rimg.Src = $"data:image/jpg;base64,{bmp.ToBase64()}";
            bmp.Dispose();

            sp.Attributes.Add("style", "display:none");
            rimg.Visible = true;
        }

        private void SetCookie(string key, string value)
        {
            if (value != null)
            {
                Response.Cookies[key].Value = value;
                Response.Cookies[key].Expires = DateTime.Now.AddYears(1);
            }
            else
            {
                Response.Cookies[key].Expires = DateTime.Now.AddDays(-1);
            }
        }
    }
}