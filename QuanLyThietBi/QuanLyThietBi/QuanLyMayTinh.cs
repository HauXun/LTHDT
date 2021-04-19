﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace QuanLyThietBi
{
	class QuanLyMayTinh
	{
		List<ILinkKien> listLinkKien = new List<ILinkKien>();
		public enum LoaiGia
		{
			GiaMayTinh,
			GiaCPU,
			GiaRAM
		}
		public enum LinkKien
		{
			CPU,
			RAM
		}
		public enum MinMax
		{
			Min,
			Max
		}
		public enum Loai
		{
			HangSX,
			ThietBi
		}
		#region Các hàm chức năng tìm kiếm
		public float Gia(DanhSachMayTinh list, int loaiGia, int minMax)
		{
			switch (minMax)
			{
				case 0:
					switch (loaiGia)
					{
						case 0:
							return list.listMayTinh.Min(x => x.TinhGia());
						case 1:
							return list.listMayTinh.Min(x => x.GiaCPU);
						case 2:
							return list.listMayTinh.Min(x => x.GiaRAM);
					}
					break;
				case 1:
					switch (loaiGia)
					{
						case 0:
							return list.listMayTinh.Max(x => x.TinhGia());
						case 1:
							return list.listMayTinh.Max(x => x.GiaCPU);
						case 2:
							return list.listMayTinh.Max(x => x.GiaRAM);
					}
					break;
				default:
					WriteLine("Co loi gi do da xay ra. Hay kiem tra lai!");
					Read();
					break;
			}
			return 0;
		}
		public DanhSachMayTinh ListMayTinhTheoLoai(DanhSachMayTinh list, int loaiGia, int minMax)
		{
			DanhSachMayTinh result = new DanhSachMayTinh();
			switch (minMax)
			{
				case 0:
					switch (loaiGia)
					{
						case 0:
							result.listMayTinh = list.listMayTinh.Where(x => x.TinhGia() == Gia(list, 0, 0)).ToList();
							break;
						case 1:
							result.listMayTinh = list.listMayTinh.Where(x => x.GiaCPU == Gia(list, 1, 0)).ToList();
							break;
						case 2:
							result.listMayTinh = list.listMayTinh.Where(x => x.GiaRAM == Gia(list, 2, 0)).ToList();
							break;
					}
					break;
				case 1:
					switch (loaiGia)
					{
						case 0:
							result.listMayTinh = list.listMayTinh.Where(x => x.TinhGia() == Gia(list, 0, 1)).ToList();
							break;
						case 1:
							result.listMayTinh = list.listMayTinh.Where(x => x.GiaCPU == Gia(list, 1, 1)).ToList();
							break;
						case 2:
							result.listMayTinh = list.listMayTinh.Where(x => x.GiaRAM == Gia(list, 2, 1)).ToList();
							break;
					}
					break;
				default:
					WriteLine("Co loi gi do da xay ra. Hay kiem tra lai!");
					Read();
					break;
			}
			return result;
		}
		#endregion
		public void ThemDanhSachTheoLoai(List<string> result, List<string> kieu, int loai)
		{
			foreach (var item in kieu)
			{
				if (!result.Contains(item))
					switch (loai)
					{
						case 0:
							result.Add(item);
							break;
						case 1:
							result.Add(item);
							break;
					}
			}
		}
		public List<string> DanhSachTheoLoai(DanhSachMayTinh list, int loai)
		{
			List<string> result = new List<string>();
			foreach (var item in list.listMayTinh)
			{
				switch(loai)
				{
					case 0:
						ThemDanhSachTheoLoai(result, item.TimDanhSachTheoLoai(loai), loai);
						break;
					case 1:
						ThemDanhSachTheoLoai(result, item.TimDanhSachTheoLoai(loai), loai);
						break;
				}
			}
			return result;
		}
	}
}
