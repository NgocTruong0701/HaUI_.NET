   M S B A M L   `   `   `  ????H  DWPF_QLBanHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPF_QLBanHangWPF_QLBanHang  5   	       WPF_QLBanHang.Search   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPF_QLBanHang     5   	   -   5          ? Title$  Search??5   	   $	??450??6   $	??800??6%   .??5	      ?  ? 	Resources 5
   
   =  7System.Windows.Controls.Primitives.DataGridColumnHeader ?? 
TargetType ?? Property ?? Value??%|   '        ?? 5      "  6   .?5      ??  ? ??$
 Bold"?6/   ?? 5       ? ??$ Center=?6?   5      5       ? ColumnDefinitions 5   
   ?? 5      .+?5   
   ?? $"??THÔNG TIN CÁC SẢN PHẨM??6   $??20(?61   $
??Bold"?6?   
????? ?$??Center=?6g   $??0,22,0,0q?6?   $	??Top=?6?   &   System.Windows.Controls.DataGrid  5   
   -   5        $??dgv_DS??5         AlternatingRowBackground
 ????   AutoGenerateColumns$ False??5         CanUserAddRows$ False??5      $??68,92,68,91q?5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Mã sản phẩm??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 110 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   ?? *MaSp+6S     5      $
 Tên sản phẩm??6%   $	 120 6U    6;   ?? *TenSp+6U     5      $
 Mã loại sản phẩm??6%   $	 110 6Z    6?   ?? *MaLoai+6Z     5       $
 Số lượng??6%   $ 90 6S    67   ?? *	SoLuong+6S     5!      $
 
Đơn giá??6%   $	 100 6Q    66   ?? *DonGia+6Q     5"      $
 Thành tiền??6%   $ * 6W    69   ?? *	ThanhTien+6W   5$      5%      5&      