   M S B A M L   `   `   `  ????H  DWPF_QLBanHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPF_QLBanHangWPF_QLBanHang  5   	       WPF_QLBanHang.Statistical   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPF_QLBanHang     5   	   -   5          ? Title$  Statistical??5   	   $	??450??6   $	??800??6*   .??5	      ?  ? 	Resources 5
   
   =  7System.Windows.Controls.Primitives.DataGridColumnHeader ?? 
TargetType ?? Property ?? Value??%|   '        ?? 5      "  6   .?5      ??  ? ??$
 Bold"?6/   ?? 5       ? ??$ Center=?6?   5      5       ? ColumnDefinitions 5   
   ?? 5      .+?5   
   ?? $$??THÔNG TIN LOẠI SẢN PHẨM??6   $??20(?62   $
??Bold"?6@   
????? ?$??Center=?6h   $??0,22,0,0q?6?   $	??Top=?6?   &   System.Windows.Controls.DataGrid  5   
   -   5        $??dgv_DS??5         AlternatingRowBackground
 ?????   AutoGenerateColumns$ False??5         CanUserAddRows$ False??5      $??65,76,65,76q?5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Mã loại sản phảm??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   ?? *MaLoai+6Z     5      $
 Tên loại sản phẩm??6%   $	 170 6\    6@   ?? *	TenLoai+6\     5      $ 
 Số lượng sản phẩm??6%   $	 120 6^    6@   ?? *	SoLuongSP+6^     5      $
 Tổng tiền??6%   $ * 6U    68   ?? *
TongTien+6U   5       5"      5#      