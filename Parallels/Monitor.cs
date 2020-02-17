using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Parallels
{
    public partial class Monitor : Form
    {
        public static int thr_quantity = 0;
        public static bool th_pause = false;
        public static bool running = true;
        public Monitor()
        {
            InitializeComponent();
            Task.Factory.StartNew(delegate
            {
                while (true) { this.view_quantity(thr_quantity); Thread.Sleep(100); }
            });
        }
        public void start_load(int[] ipfrom, int[] ipto, int thrq)
        {
            int[] ip_range = new int[4];
            button1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            if (ipfrom == null)
            {
                ip_range[0] = 0;
                ip_range[1] = 0;
                ip_range[2] = 0;
                ip_range[3] = 0;
            }
            else
                ip_range = ipfrom;
            int n = thrq;
            int k = 0;
            String host;
            Thread[] t = new Thread[n + 1];
            Task.Factory.StartNew(delegate {
                while (running)
                {
                    Thread.Sleep(500);
                    BeginInvoke((MethodInvoker)delegate
                    {
                        if (thr_quantity < n && !th_pause)
                        {
                            for (int i = 0; i < n && running; i++)
                            {
                                if (t[i] != null && t[i].ThreadState == ThreadState.Aborted)
                                {
                                    t[i] = null;
                                }
                                if (t[i] == null || t[i].ThreadState == ThreadState.Stopped || t[i].ThreadState == ThreadState.Unstarted)
                                {
                                    host = "http://" + ip_range[0] + "." + ip_range[1] + "." + ip_range[2] + "." + ip_range[3];
                                    dataGridView1.Rows.Add(k.ToString(), host, "Processing", "");
                                    t[i] = new Thread(() => HTTP_GET(host, k));
                                    t[i].Start();
                                    for (int p = 3; p > 0; p--)
                                    {
                                        if (ip_range[p] > ipto[p])
                                        {
                                            ip_range[p] = 0;
                                            ip_range[p - 1]++;
                                        }
                                        if (ip_range[0] > ipto[0])
                                            running = false;
                                    }
                                    ip_range[3]++;
                                    k = k + 1;
                                    thr_quantity = thr_quantity + 1;
                                }
                                else if (t[i].ThreadState != ThreadState.Stopped || t[i].ThreadState != ThreadState.Unstarted)
                                {
                                    t[i].Join();
                                }
                            }
                        }
                    });
                }

            });

        }
        public void view_quantity(int d)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                thrqnt.Text = d.ToString();
            });
        }
        public void success(int i)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                for (int l = 0; l <= 3; l++)
                    dataGridView1.Rows[i].Cells[l].Style.BackColor = Color.Green;
                dataGridView1.Rows[i].Cells[2].Value = "Connected";
            });
        }
        public void failed(int i, string message)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                for (int l = 0; l <= 3; l++)
                    dataGridView1.Rows[i].Cells[l].Style.BackColor = Color.Red;
                dataGridView1.Rows[i].Cells[2].Value = "Failed to Connect!";
                dataGridView1.Rows[i].Cells[3].Value = "" + message;
            });
        }
        public async void HTTP_GET(string host, int count)
        {
            var TARGETURL = host;
            try
            {
                HttpClientHandler handler = new HttpClientHandler();
                HttpClient client = new HttpClient(handler);

                var byteArray = Encoding.ASCII.GetBytes("admin:admin");
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                HttpResponseMessage response = null;
                HttpContent content = null;
                response = await client.GetAsync(TARGETURL);
                content = response.Content;
                string result = await content.ReadAsStringAsync();
                if (result != null && result.Length > 0)
                {
                    success(count);
                }
            }
            catch (HttpRequestException exc)
            {
                failed(count, exc.Message);

            }
            catch (TaskCanceledException exc)
            {
                failed(count, exc.Message);
            }
            thr_quantity--;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            th_pause = th_pause ? false : true;
        }

    }
}



