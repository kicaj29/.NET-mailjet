using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailJet.Client;

namespace MailJetSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            MailJetClient client = new MailJetClient("a", "a");
            client.SendMessage(new System.Net.Mail.MailMessage("jacek.kowalski@dieboldnixdorf.com", "filip.gibki@dieboldnixdorf.com", "test", "test body"));

        }

        private void btnSendMailTemplate_Click(object sender, EventArgs e)
        {
            MailJetClient client = new MailJetClient("a", "a");
            var template = client.GetTemplate("JacekFirstTemplate");
            var response = client.SendTemplateMessage(template.Data[0].ID, new MailAddress("marcin.piliszczuk@dieboldnixdorf.com"),
                new MailAddress("jacek.kowalski@dieboldnixdorf.com"), "mail with template", null);
        }

        private void btnTemplateWithVariable_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> p = new Dictionary<string, object>();
            p.Add("test181017122112updated", "SUPER_VALUE");

            MailJetClient client = new MailJetClient("a", "a");
            var template = client.GetTemplate("JacekTemplate1");
            var response = client.SendTemplateMessage(template.Data[0].ID,                 
                new MailAddress("jacek.kowalski@dieboldnixdorf.com"),
                new MailAddress("marcin.piliszczuk@dieboldnixdorf.com"),
                "mail with template", p);

        }


    }
}
