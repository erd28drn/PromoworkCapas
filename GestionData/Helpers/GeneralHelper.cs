using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace GestionData.Helpers
{
    public static class GeneralHelper
    {

        #region VALIDAR EMAIL
        public static bool ValidarEmail(string emails)
        {
            if (string.IsNullOrEmpty(emails))
            {
                return false;
            }

            try
            {
                var lstEmail = emails.Split(';').ToList();
                foreach (var email in lstEmail)
                {
                    new MailAddress(email.Trim());
                }
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (ArgumentNullException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion VALIDAR EMAIL

    }
}
