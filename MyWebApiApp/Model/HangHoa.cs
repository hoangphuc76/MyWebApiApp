﻿namespace MyWebApiApp.Model
{
    public class HangHoaVM
    {
        public string TenHangHoa { get; set; }
        public double Dongia { get; set; }

    }
    public class HangHoa : HangHoaVM
    {
        public Guid MaHangHoa { get; set;}
    }
}
