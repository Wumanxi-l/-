using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 点餐管理系统
{
    public partial class ToEmail : Form
    {
        public ToEmail()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 邮件发送方法
        /// </summary>
        /// <param name="toMial">收件人邮箱</param>
        /// <param name="fromMial">发件人邮箱</param>
        /// <param name="userID">发件人邮箱帐号 如QQ邮箱 为QQ号码 </param>
        /// <param name="userPwd">发件人邮箱受权码</param>
        /// <param name="serverAddress">邮件服务地址 如QQ邮箱服务地址为smtp.qq.com</param>
        /// <param name="subject">邮件主题</param>
        /// <param name="body">邮件内容</param>
        /// <returns></returns>
        public bool MailSender(string toMial, string fromMial, string userID, string userPwd, string serverAddress, string subject, string body)
        {
            try
            {
                //创建一个邮件对像
                MailMessage mailObject = new MailMessage();
                //设置发件人
                mailObject.From = new MailAddress(fromMial);
                //设置收件人
                mailObject.To.Add(new MailAddress(toMial));

                //设置邮件主题
                mailObject.SubjectEncoding = Encoding.UTF8;
                mailObject.Subject = subject;

                //设置邮件内容
                mailObject.BodyEncoding = Encoding.UTF8;//编码
                mailObject.Body = body;

                //创建一个发送邮件的对像 
                SmtpClient smtpClient = new SmtpClient()
                {
                    // 设置超时时间，单位为毫秒，这里设置为30秒（可根据实际网络情况调整）
                    Timeout = 30000,
                    // 启用SSL加密协议（很多邮箱要求，比如QQ邮箱等，根据实际情况调整）
                    EnableSsl = true
                };
                //服务地址  如QQ邮箱  smtp.qq.com
                smtpClient.Host = serverAddress;
                //帐号和受权码
                smtpClient.Credentials = new NetworkCredential(userID, userPwd);
                smtpClient.Send(mailObject);
                MessageBox.Show("发送成功！");
                return true;
            }
            catch (SmtpException smtpEx)
            {
                // 针对SmtpException进行更详细的错误提示处理，便于排查邮件服务器相关问题
                MessageBox.Show($"邮件发送失败，原因可能是：{smtpEx.Message}。请检查邮件服务器配置、网络连接以及邮箱账号授权等信息是否正确。");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"发生未知错误：{ex.Message}");

            }
            return false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            // 先对必要的输入框内容进行非空等简单验证（可根据实际需求完善更严格的验证逻辑）
            if (string.IsNullOrEmpty(txtToMial.Text) || string.IsNullOrEmpty(txtFromMail.Text) ||
                string.IsNullOrEmpty(txtUserId.Text) || string.IsNullOrEmpty(txtUserPwd.Text) ||
                string.IsNullOrEmpty(txtServerAddress.Text) || string.IsNullOrEmpty(txtSubject.Text) ||
                string.IsNullOrEmpty(txtBody.Text))
            {
                MessageBox.Show("请确保所有邮件相关信息输入完整！");
                return;
            }
            MailSender(txtToMial.Text, txtFromMail.Text, txtUserId.Text, txtUserPwd.Text, txtServerAddress.Text, txtSubject.Text, txtBody.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

