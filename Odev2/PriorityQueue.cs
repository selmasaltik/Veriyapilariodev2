using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class PriorityQueue:IQueue,IHesaplayabilir
    {
        public object[] Queue;
        private int front = -1;
        private int size = 0;
        private int count = 0;

        public PriorityQueue(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(object o)
        {
            if (count == size)
            {
                throw new Exception("Queue is full");
            }

            if (IsEmpty())
            {
                front++;
                Queue[front] = o; 
                count++;
            }
            else 
            {
                int i;
                
                for (i = count - 1; i >= 0; i--)
                {
                    if (((Musteri)o).Islem_Suresi < ((Musteri)Queue[i]).Islem_Suresi)
                        Queue[i + 1] = Queue[i];
                    else
                        break;
                }
                Queue[i + 1] = o;
                front++;
                count++;
            }
        }

        public object Remove()      
        {
            if (this.IsEmpty())
            {
                throw new Exception("Queue is empty...");
            }
            
           
            object temp = Queue[front];
            Queue[front] = null;
            front--;
            count--;
            return temp;
        }

        public object Peek()
        {
            return Queue[front];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public string Display()
        {
            string temp = "";

            for (int i = 0; i < 20; i++)
            {
                temp += i + 1 + " Numaralı Müşterinin " + Environment.NewLine + "Müşteri no : " + ((Musteri)Queue[i]).Musteri_No.ToString() + Environment.NewLine + "İşlem süresi :" + ((Musteri)Queue[i]).Islem_Suresi.ToString() + Environment.NewLine + "Toplam İşlem Süresi:" + IslemTamamlama_suresi(((Musteri)Queue[i]).Islem_Suresi) + Environment.NewLine + Environment.NewLine;
            }

            return temp;
        }

        public int IslemSuresi = 0;
        public int IslemTamamlama_suresi(int QueueiSure)
        {
            IslemSuresi += QueueiSure;
            return IslemSuresi;
        }

        public double Ortalama_sure()
        {
            int IslemSuresi = 0;
            for (int i = 0; i < 20; i++)
            {
                DateTime baslangic = DateTime.Now;
                TimeSpan ts = DateTime.Now.Subtract(baslangic);
                IslemSuresi += ((Musteri)(Queue[i])).Islem_Suresi;
            }

            double Ortalama_Sure = IslemSuresi / 20;

            return Ortalama_Sure;
        }



      

        
    }
}
