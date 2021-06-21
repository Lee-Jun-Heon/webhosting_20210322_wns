using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car0610.Util
{
    class RandData
    {
        string[] name = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
        string[] tel = {"010-1324-5678", "010-4321-5678", "010-3478-1278",
                        "010-4523-1978", "010-7890-2134"};
        string[] address = {"대구시 동구 신암4동", "서울시 동구 신암4동",
                        "부산시 동구 신암4동","인천시 동구 신암4동","광주시 동구 신암4동"};
        string[] model = { "SM6", "쏘나타", "싼타페", "K7", "그랜져" };
        string[] color = { "블랙", "은색", "흰색", "회색", "빨강" };
        int[] year = { 2016, 2017, 2018, 2019, 2020 };
        string[] company = { "삼성르노", "현대", "현대", "기아", "현대" };

        Random r = new Random();

        public string getName()
        {
            return name[r.Next(0, 5)];
        }

        public string getTel()
        {
            return tel[r.Next(0, 5)];
        }

        public string getAddress()
        {
            return address[r.Next(0, 5)];
        }

        public string getModel()
        {
            return model[r.Next(0, 5)];
        }

        public string getColor()
        {
            return color[r.Next(0, 5)];
        }

        public int getYear()
        {
            return year[r.Next(0, 5)];
        }
        
        public string getCompany()
        {
            return company[r.Next(0, 5)];
        }
    }
}
