﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi
{
	class RAM : ILinkKien
	{
		float gia;
		string hangSX;
		string tenThietBi;
		string thietBi;
		public string ThietBi { get { return thietBi; } set { thietBi = value; } }
		public float Gia { get { return gia; } set { gia = value; } }
		public string HangSX { get { return hangSX; } set { hangSX = value; } }
		public string TenThietBi { get { return tenThietBi; } set { tenThietBi = value; } }
		public RAM()
		{
		}
		public RAM(string hangSX, string tenTB, float gia)
		{
			ThietBi = "RAM";
			HangSX = hangSX;
			TenThietBi = tenTB;
			Gia = gia;
		}
		public override string ToString() => $"{ThietBi} {HangSX} {TenThietBi} >> Gia = {Gia.ToString("C")}";
	}
}
