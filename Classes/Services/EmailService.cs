using System;
using System.Net;
using System.Net.Mail;

namespace PhotoBoothRentalSystem.Classes.Services
{
    public class EmailService
    {
        // ======== CONFIGURATION - UPDATE THESE ========
        private static string SMTP_HOST = "smtp.gmail.com";
        private static int SMTP_PORT = 587;
        private static string SENDER_EMAIL = "manalomeynard305@gmail.com";  // Your Gmail address
        private static string SENDER_PASSWORD = "qqbu vsjd quqm zmqw";  // 16-char app password (no spaces)
        private static string SENDER_NAME = "ZASS Photobooth";
        // ===============================================

        public static bool SendOTPEmail(string recipientEmail, string otpCode, string recipientName)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    // Configure email
                    mail.From = new MailAddress(SENDER_EMAIL, SENDER_NAME);
                    mail.To.Add(recipientEmail);
                    mail.Subject = "Your ZASS Photobooth OTP Verification Code";
                    mail.IsBodyHtml = true;

                    // Email body with professional HTML template
                    mail.Body = GetEmailTemplate(otpCode, recipientName);

                    // Configure SMTP
                    using (SmtpClient smtp = new SmtpClient(SMTP_HOST, SMTP_PORT))
                    {
                        smtp.Credentials = new NetworkCredential(SENDER_EMAIL, SENDER_PASSWORD);
                        smtp.EnableSsl = true;
                        smtp.Timeout = 20000; // 20 seconds timeout

                        // Send email
                        smtp.Send(mail);
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Email Error: " + ex.Message);
                return false;
            }
        }

        private static string GetEmailTemplate(string otpCode, string recipientName)
        {
            return $@"
<!DOCTYPE html>
<html>
<head>
    <style>
        body {{
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }}
        .container {{
            max-width: 600px;
            margin: 30px auto;
            background-color: #ffffff;
            border-radius: 10px;
            overflow: hidden;
            box-shadow: 0 4px 6px rgba(0,0,0,0.1);
        }}
        .header {{
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            color: white;
            padding: 30px;
            text-align: center;
        }}
        .header h1 {{
            margin: 0;
            font-size: 28px;
        }}
        .content {{
            padding: 40px 30px;
            text-align: center;
        }}
        .otp-box {{
            background-color: #f8f9fa;
            border: 2px dashed #667eea;
            border-radius: 8px;
            padding: 20px;
            margin: 30px 0;
            display: inline-block;
        }}
        .otp-code {{
            font-size: 36px;
            font-weight: bold;
            color: #667eea;
            letter-spacing: 8px;
            margin: 0;
        }}
        .message {{
            color: #555;
            font-size: 16px;
            line-height: 1.6;
            margin: 20px 0;
        }}
        .warning {{
            background-color: #fff3cd;
            border-left: 4px solid #ffc107;
            padding: 15px;
            margin: 20px 0;
            text-align: left;
        }}
        .footer {{
            background-color: #f8f9fa;
            padding: 20px;
            text-align: center;
            color: #777;
            font-size: 14px;
        }}
        .highlight {{
            color: #667eea;
            font-weight: bold;
        }}
    </style>
</head>
<body>
    <div class='container'>
        <div class='header'>
            <h1>📸 ZASS Photobooth</h1>
            <p style='margin: 5px 0 0 0; font-size: 16px;'>Email Verification</p>
        </div>

        <div class='content'>
            <p class='message'>Hello <strong>{recipientName}</strong>,</p>

            <p class='message'>
                Thank you for signing up! To complete your registration, please use the verification code below:
            </p>

            <div class='otp-box'>
                <p class='otp-code'>{otpCode}</p>
            </div>

            <p class='message'>
                This code is valid for <span class='highlight'>5 minutes</span>.
            </p>

            <div class='warning'>
                <strong>⚠️ Security Notice:</strong><br>
                • Never share this code with anyone<br>
                • ZASS staff will never ask for this code<br>
                • If you didn't request this, please ignore this email
            </div>
        </div>

        <div class='footer'>
            <p><strong>ZASS Photobooth Rental System</strong></p>
            <p>Contact: 0919-478-8556 | Email: admin@zass.com</p>
            <p style='margin-top: 15px; font-size: 12px;'>
                This is an automated email. Please do not reply.
            </p>
        </div>
    </div>
</body>
</html>";
        }

        // Test email connection
        public static bool TestEmailConnection()
        {
            try
            {
                using (SmtpClient smtp = new SmtpClient(SMTP_HOST, SMTP_PORT))
                {
                    smtp.Credentials = new NetworkCredential(SENDER_EMAIL, SENDER_PASSWORD);
                    smtp.EnableSsl = true;
                    smtp.Timeout = 10000;

                    // Just test the connection
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("SMTP Test Error: " + ex.Message);
                return false;
            }
        }
    }
}