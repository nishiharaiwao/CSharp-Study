using System;
using System.Collections.Generic;
using System.Linq;

namespace DeepCopy
{

    public class 選手情報
    {

        public class 選手
        {
            string 名前 { get; set; }
            int 年齢 { get; set; }
            public 選手(string name, int age)
            {
                名前 = name;
                年齢 = age;
            }
            public 選手(選手 p)
            {
                名前 = p.名前;
                年齢 = p.年齢;
            }
        }

        public class 所属
        {
            string 名前 { get; set; }
            int 番号 { get; set; }
            public 所属(string name, int number)
            {
                名前 = name;
                番号 = number;
            }

            public 所属(所属 s)
            {
                名前 = s.名前;
                番号 = s.番号;
            }
        }

        public 選手 player { get; set; }
        public 所属 info { get; set; }

        public 選手情報(選手 playerInfo,所属 clubInfo)
        {
            player = playerInfo;
            info = clubInfo;
        }
        public 選手情報(選手情報 i)
        {
            player = i.player;
            info = i.info;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var tourdefranc1998 = new Dictionary<int, 選手情報>();
            tourdefranc1998.Add(1, new 選手情報(new 選手情報.選手(name: "マルコ・パンターニ", age:30), new 選手情報.所属("ビアンキ", 19981)));
            tourdefranc1998.Add(2, new 選手情報(new 選手情報.選手(name: "ヤン・ウルリッヒ", 　age:20), new 選手情報.所属("テレコム", 19982)));
            tourdefranc1998.Add(3, new 選手情報(new 選手情報.選手(name: "ボビー・ジュリック", age:25), new 選手情報.所属("コフィディス", 19983)));

            var tourdefranc2018 = new Dictionary<int, 選手情報>();
            tourdefranc2018.Add(1, new 選手情報(new 選手情報.選手(name: "ゲラント・トーマス", age: 30), new 選手情報.所属("チームスカイ",20181)));
            tourdefranc2018.Add(2, new 選手情報(new 選手情報.選手(name: "トム・デュムラン", age: 20), new 選手情報.所属("チーム・サンウェブ", 20182)));
            tourdefranc2018.Add(3, new 選手情報(new 選手情報.選手(name: "クリス・フルーム", age: 25), new 選手情報.所属("チームスカイ", 20183)));


        }
    }
}
