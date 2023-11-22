﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi21_DuAn2
{
    class Robot : Player
    {
        List<int> chooses = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public Robot( char sign='O'): base(sign)
        {

        }
        public int takeTurn()
        {
            Random rd = new Random();
            int index = rd.Next(0, chooses.Count-1);  //lựa chọn index từ 0 -> n-1
            return chooses[index];
        }
        public void removeChoose(int value)
        {
            chooses.Remove(value);  //loại bỏ các giá trị đã được sử dụng
        }
    }
}
