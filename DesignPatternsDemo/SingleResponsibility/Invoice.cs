using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class Invoice
    {
        public long InvoiceAmount { get; set; }
        public DateTime InvoiceDate { get; set; }

        private ILogger logger;
        private MailSender mailSender;

        public Invoice()
        {
            logger = new Logger();
            mailSender = new MailSender();
        }

        public void AddInvoice()
        {
            try
            {
                logger.Info("Add method Start");
                // Here we need to write the Code for adding invoice
                // Once the Invoice has been added, then send the  mail
                mailSender.EMailFrom = "emailfrom@xyz.com";
                mailSender.EMailTo = "emailto@xyz.com";
                mailSender.EMailSubject = "Single Responsibility Princile";
                mailSender.EMailBody = "A class should have only one reason to change";
                mailSender.SendEmail();
            }
            catch (Exception ex)
            {
                logger.Error("Error Occurred while Generating Invoice", ex);
            }
        }
        public void DeleteInvoice()
        {
            try
            {
                //Here we need to write the Code for Deleting the already generated invoice
                logger.Info("Delete Invoice Start at @" + DateTime.Now);
            }
            catch (Exception ex)
            {
                logger.Error("Error Occurred while Deleting Invoice", ex);
            }
        }
    }
}
