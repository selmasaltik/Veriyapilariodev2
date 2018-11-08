using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class CircularQueue:IQueue,IHesaplayabilir
    {
        public object[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        public CircularQueue(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        
        public void Insert(object o)
        {
            if (count == size)
                throw new Exception("Queue dolu.");

            if (front == -1)
                front = 0;

           
            if (rear == size - 1)  
            {
                rear = 0;
                Queue[rear] = o;
            }                
            else  
                Queue[++rear] = o;
            
            count++;
        }

        public object Remove()
        {
            if (IsEmpty())
                throw new Exception("Queue boş.");
            
            object temp = Queue[front];
            Queue[front] = null;

            
            if (front == size - 1)
                front = 0; 
            else
                front++;

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
          
            for(int i=0 ; i<20; i++)
            {
                temp += i + 1 + " Numaralı Müşterinin " + Environment.NewLine + "Müşteri no : " + ((Musteri)Queue[i]).Musteri_No.ToString() + Environment.NewLine + "İşlem süresi :" + ((Musteri)Queue[i]).Islem_Suresi.ToString()+ Environment.NewLine + "Toplam İşlem Süresi:" + IslemTamamlama_suresi(((Musteri)Queue[i]).Islem_Suresi) + Environment.NewLine + Environment.NewLine;
            }
            
            return temp;
        }
        public int IslemSuresi=0;
        public int IslemTamamlama_suresi(int sure) 
        {
            IslemSuresi += sure;
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
