/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
*/

namespace MyAsyncFileIOWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private async Task<long> CopyAsync(string FromPath, string ToPath)
        {
            btnSyncCopy.Enabled = false;
            long totalCopied = 0;

            using (FileStream fromStream =
                new FileStream(FromPath, FileMode.Open))
            {
                using (FileStream toStream =
                    new FileStream(ToPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024 * 1024];
                    int nRead = 0;
                    while ((nRead =
                        await fromStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                    {
                        await toStream.WriteAsync(buffer, 0, nRead);
                        totalCopied += nRead;

                        pbCopy.Value =
                            (int)(((double)totalCopied / (double)fromStream.Length)
                                * pbCopy.Maximum);
                    }
                }
            }
            btnSyncCopy.Enabled = true;
            return totalCopied;
        }

        private long CopySync(string FromPath, string ToPath)
        {
            btnAsyncCopy.Enabled = false;
            long totalCopied = 0;

            using (FileStream fromStream =
                new FileStream(FromPath, FileMode.Open))
            {
                using (FileStream toStream =
                    new FileStream(ToPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024 * 1024];
                    int nRead = 0;
                    while ((nRead =
                        fromStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        toStream.Write(buffer, 0, nRead);
                        totalCopied += nRead;

                        pbCopy.Value =
                            (int)(((double)totalCopied / (double)fromStream.Length)
                            * pbCopy.Maximum);
                    }
                }
            }
            btnAsyncCopy.Enabled = true;
            return totalCopied;
        }


        private void btnFindSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtSource.Text = ofd.FileName;
            }
        }

        private void btnFindTarget_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtTarget.Text = sfd.FileName;
            }
        }

        private async void btnAsyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = await CopyAsync(txtSource.Text, txtTarget.Text);
        }

        private async void btnSyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = CopySync(txtSource.Text, txtTarget.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UI 반응 테스트 성공");
        }
    }
}
