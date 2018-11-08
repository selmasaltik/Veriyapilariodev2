using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CircularQueue c = new CircularQueue(20);
        PriorityQueue pq = new PriorityQueue(20);
        TersPriority tp = new TersPriority(20);
        private void btnCircularQueue_Click(object sender, EventArgs e)
        {
           txtCircular.Text = c.Display().ToString();
           txtCircularOrtalama.Text = c.Ortalama_sure().ToString();
           
        }

        int circularsure, prioritysure;
        
        public string FIFO_Bekleme()
        {
            c.IslemSuresi = 0;
            string tmp = "";
            for(int i=0; i<20; i++)
            {
                circularsure = 0;
                pq.IslemSuresi = 0;
                circularsure = c.IslemTamamlama_suresi((((Musteri)c.Queue[i]).Islem_Suresi));
                for(int j=0; j<20; j++)
                {
                    prioritysure = pq.IslemTamamlama_suresi((((Musteri)pq.Queue[j]).Islem_Suresi));
                    if ((((Musteri)c.Queue[i]).Musteri_No) == (((Musteri)pq.Queue[j]).Musteri_No))
                    {
                        if (prioritysure < circularsure)
                        {
                            float kazanc=(100*prioritysure)/circularsure;
                            tmp += (((Musteri)pq.Queue[j]).Musteri_No).ToString() + " numaralı muşteri daha az beklemiştir" +Environment.NewLine+
                                "Süreden Kazanç:"+(circularsure-prioritysure).ToString()+" / %"+kazanc.ToString()+Environment.NewLine+Environment.NewLine;
                        }
                        break;
                    }
                }
            }
            return tmp;
        }


        public string FIFO_BeklemeTers()
        {
            c.IslemSuresi = 0;
            string tmp = "";
            for (int i = 0; i < 20; i++)
            {
                circularsure = 0;
                tp.IslemSuresiTers = 0;
                circularsure = c.IslemTamamlama_suresi((((Musteri)c.Queue[i]).Islem_Suresi));
                for (int j = 0; j < 20; j++)
                {
                    prioritysure = tp.IslemTamamlama_suresiTers((((Musteri)tp.Queue[j]).Islem_SuresiTers));
                    if ((((Musteri)c.Queue[i]).Musteri_No) == (((Musteri)tp.Queue[j]).Musteri_No))
                    {
                        if (prioritysure < circularsure)
                        {
                            float kazanc = (100 * prioritysure) / circularsure;
                            tmp += (((Musteri)tp.Queue[j]).Musteri_No).ToString() + " numaralı muşteri daha az beklemiştir" + Environment.NewLine + "Süreden Kazanç:" + (circularsure - prioritysure).ToString() + " / %" + kazanc.ToString() + Environment.NewLine + Environment.NewLine;
                        }
                        break;
                    }
                }
            }
            return tmp;
        }
        private void btnPriorityQueue_Click(object sender, EventArgs e)
        {
            txtPriority.Text = pq.Display().ToString();
            txtPriorityOrtalama.Text = pq.Ortalama_sure().ToString();
            txtBekleme.Text = FIFO_Bekleme().ToString();
            txtTersSirali.Text = tp.DisplayTers().ToString();
            txtPriorityTers.Text = FIFO_BeklemeTers().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //rastgele işlem süresi üretiyoruz
            Random r = new Random();  
            for (int i = 0; i < 20; i++)
            {
                Musteri mus = new Musteri();
                mus.Musteri_No = i + 1;
                mus.Islem_SuresiTers =mus.Islem_Suresi = r.Next(60, 600);
                c.Insert(mus);
                pq.Insert(mus);
                tp.Insert(mus);
            }
        }


        private void txtPriority_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
