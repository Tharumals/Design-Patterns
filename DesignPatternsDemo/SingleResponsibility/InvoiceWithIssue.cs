using System.Net.Mail;

namespace SingleResponsibility
{
    //Class with Principle issue
    public class InvoiceWithIssue
    {
        public long InvoiceAmount { get; set; }
        public DateTime InvoiceDate { get; set; }

        public void AddInvoice()
        {
            try
            {
                // Here we need to write the Code for adding invoice
                // Once the Invoice has been added, then send the  mail
                MailMessage message = new MailMessage("EMailFrom", "EmailTo", "EmailSubject", "EmailBody");
                this.SendInvoiceEmail(message);
            }
            catch (Exception ex)
            {
                //Error Logging
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
        public void DeleteInvoice()
        {
            try
            {
                //Here we need to write the Code for Deleting the already generated invoice
            }
            catch (Exception ex)
            {
                //Error Logging
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }

        public void SendInvoiceEmail(MailMessage mailMessage)
        {
            try
            {

            }
            catch (Exception ex)
            {
            }
        }
    }
}
