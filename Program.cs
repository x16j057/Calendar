using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*現在の日時から
             * 今月のカレンダーを画面に表示するプログラム
             */
            DateTime dateNow = DateTime.Now;
            //現在の年、月を表示する
            Console.Write("{0}年{1}月\n", dateNow.Year, dateNow.Month);
            //Console.ReadLine();
            //現在の年月の１日を取得する
            DateTime dateFirst = DateTime.Parse(string.Format("{0}/{1}/1", dateNow.Year, dateNow.Month));
           // DisplayCalendar(dateFirst);
            Console.ReadLine();
        }

        //1月分のカレンダーを画面に表示するパラメータ
        static void DisplayCalendar(DateTime dateFirst)
        {
            int week;
            int month = dateFirst.Month;

            //曜日タイトルの表示
            Console.Write("--------------------\n");
            Console.Write("日 月 火 水 木 金 土\n");

            //一日の開始位置まで空白を表示する
            for (week = 0; week < (int)dateFirst.DayOfWeek; week++)
                Console.Write("   ");

            //月の終わりの日まで１週間ごとに日にちを表示する
            while(month == dateFirst.Month)
            {
                for(; week < (int)dateFirst.Month; week++)
                {
                    Console.Write("{0、2}", dateFirst.Day);
                    dateFirst = dateFirst.AddDays(1);//翌日に
                }
                Console.Write("\n");
                week = 0;
            }
        }
    }
}
