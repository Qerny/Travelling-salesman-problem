using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Algoritm
    {
        private int size;

        private int[] way;

        private int min_way;

        private int[,] matrix;

        public Algoritm(int n, int[,] matr)
        {
            this.size = n;
            this.matrix = matr;
            this.way = new int[n];
        }

        //строка для вывода кратчайшего пути
        public string getAllWay()
        {
            string res = "";
            for (int i = 0; i < size; i++)
                if (i != size - 1)
                    res = res + way[i].ToString() + " - ";
                else
                    res = res + way[i].ToString() + " - " + way[0].ToString();
            return res;
        }

        //вывод расстояния для кратчайшего пути
        public int getWay()
        {
            return min_way;
        }


        /*Работа с алгоритмами*/

        //меняем местами два элемента
        private void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        //первая перестановка
        private void MakeFirst(ref int[] P)
        {
            for (int i = 0; i < size; i++)
                P[i] = i + 1;
        }

        //получение следующей перестановки для лексикографического алгоритма
        private bool GetNext(int[] P)
        {
            // получаем первую перестановку
            int i, j;
            i = size - 1;

            while (i > 0 && P[i] < P[i - 1])
                i--;

            if (i == 0)
                return false;
            j = size - 1;

            while (P[j] < P[i - 1])
                j--;

            Swap(ref P[i - 1], ref P[j]);
            for (j = 0; j < (size - i) / 2 - 1; j++)
                Swap(ref P[i + j], ref P[size - 1 - j]);
            return true;
        }

        /* Ищем длину каждого маршрута  */
        private void FindMinWay(int[] P)
        {
            int my_way = 0;

            /* подсчёт пути */
            for (int i = 0; i < size; i++)
                if (i == size - 1)
                    my_way = my_way + matrix[P[i] - 1, P[0] - 1];
                else
                    my_way = my_way + matrix[P[i] - 1, P[i + 1] - 1];

            /* если путь меньше прошлого, то перезаписываем маршрут и значение */
            if (min_way > my_way)
            {
                min_way = my_way;
                Array.Copy(P, way, size);
            }
        }


        /* Получение номера по перестановке */
        private int GetNumByP(int [] P)
        {
            HashSet<int> hs = new HashSet<int>();
            int j, sq, sc;
            sc = 1;
            for (int i = 0; i < size; i++)
            {
                j = 1;
                sq = 0;
                while (j < P[i])
                {
                    if (!hs.Contains(j))
                        sq++;
                    j++;
                }
                hs.Add(P[i]);
                sc = sc + CountP(size - i - 1) * sq;
            }
            return sc;
        }


        /* Количество перестановок формула p = n!*/
        private int CountP(int n)
        {
            int cnt = 1;
            for (int i = 1; i <= n; i++)
                cnt = cnt * i;
            return cnt;
        } 

        /* Лексикографический алгорим для перестановок */
        public string Leks()
        {
            min_way = 10000;

            /*засекаем время*/
            System.Diagnostics.Stopwatch sw1 = new System.Diagnostics.Stopwatch();
            sw1.Start();

            /* первая перестановка */
            int[] P = new int[size];
            MakeFirst(ref P);

            /* пока перестановка НЕпоследняя, считаем путь для каждой, ищем кратчайший*/
            do
            {
                FindMinWay(P);
            }
            while (GetNext(P));
            /* стоп-время */
            sw1.Stop();
            return (sw1.ElapsedMilliseconds / 100.0).ToString();
        }


        /* Алгоритм случайных перестановок */
        public string Rand()
        {
            min_way = 10000;
            /* Засекаем время */
            System.Diagnostics.Stopwatch sw2 = new System.Diagnostics.Stopwatch();
            sw2.Start();

            /* Чтобы рандом был максимально разным!!)))*/
            Random rand = new Random((DateTime.Now.Millisecond));

            /* Храним случайные перестановки в сете */
            HashSet<int> hset = new HashSet<int>();
        
            /* Создаем первую перестановку */
            int[] P = new int[size];
            MakeFirst(ref P);

            /* Количество перестановок */
            int cntP = CountP(size);

            /* Пока сет не заполнен всеми перестановками */
            while (hset.Count < cntP)
            {
                /* Подсчет пути для перестановки */
                FindMinWay(P);

                /* Добавление номера перестановки в сет */
                hset.Add(GetNumByP(P));

                /* Генерация новой случайной перестановки */
                if (hset.Count < cntP)
                {
                    while (hset.Contains(GetNumByP(P)))
                    {
                        for (int k = size - 1; k >= 1; k--)
                        {
                            //int l = rand.Next(0, k);
                            int l = rand.Next(0, size);
                            Swap(ref P[l], ref P[k]);
                        }
                    }
                }
            }
            /* Стоп-время */
            sw2.Stop();
            return (sw2.ElapsedMilliseconds / 100.0).ToString();
        }

        public bool getNextChange(int[] P)
        {
            return true;
        }
    }
}
