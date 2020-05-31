using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        class Images
        {
            public class Point
            {
                public int x;
                public int y;
                public int z;
            }

            public class Data
            {
                public int d1;
                public int d2;
            }

            public Point point = new Point(); //大事！！
            public Data data = new Data();//大事！！
        };

        static void Main(string[] args)
        {
            void dump(Dictionary<int, List<Images>> dics)
            {
                foreach(var dic in dics)
                {
                    var key = dic.Key;
                    var lists = dic.Value;

                    Console.Write($"key = {key}\n");
                    foreach(var item in lists.Select((value, index) => new {value,index}))
                    {
                        Console.Write($"list[{item.index}],point.x = {item.value.point.x}\n");
                        Console.Write($"list[{item.index}],point.y = {item.value.point.y}\n");
                        Console.Write($"list[{item.index}],point.z = {item.value.point.z}\n");

                        Console.Write($"list[{item.index}],data.d1 = {item.value.data.d1}\n");
                        Console.Write($"list[{item.index}],data.d2 = {item.value.data.d2}\n");

                    }

                }
            }

            var dicX = new Dictionary<int, List<Images>>();
            var dicY = new Dictionary<int, List<Images>>();

            for (int i = 0; i < 6; i++)
            {
                List<Images> lists = new List<Images>();
                for (int j = 0; j < 10; j++)
                {
                    var aaa = new Images();
                    aaa.point.x = j;
                    aaa.point.y = j;
                    aaa.point.z = j;
                    aaa.data.d1 = j;
                    aaa.data.d2 = j;
                    lists.Add(aaa);
                }
                dicX.Add(i, lists);
            }

            dump(dicX);

            for (int i = 0; i < 3; i++)
            {
                List<Images> lists = new List<Images>();
                for (int j = 100; j < 105; j++)
                {
                    var aaa = new Images();
                    aaa.point.x = j;
                    aaa.point.y = j;
                    aaa.point.z = j;
                    aaa.data.d1 = j;
                    aaa.data.d2 = j;
                    lists.Add(aaa);
                }
                dicY.Add(i, lists);
            }
            dump(dicY);



        }
    }
}
