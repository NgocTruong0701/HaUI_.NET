   M S B A M L   `   `   `  ????H  DWPF_QLBanHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPF_QLBanHangWPF_QLBanHang  5   	       WPF_QLBanHang.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPF_QLBanHang     5   	   -   5          ? Title$  Quản lý bán hàng??5   	   $	??550??6"   $	??800??6/   .??5	      ? $??0,0,0,8q?6    ? 	Resources 5
   
    ?? 
TargetType ?? Property ?? Value ?? Triggers P? Property P? Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader ?? 
TargetType	 ?? CornerRadius??%?  '??       '  ?     '?? 8    ?? 5      " ??6   .?5      ??  ? ??$ Times New Roman)?6/    5      P? 5       ?@J?IsMouseOver$
 True??65   . ?5      ??  ? ??
 ?  ??67   5      5      ?? 5      "  6   .?5      ??  ? ??$
 Bold"?6/   ?? 5       ? ??$ Center=?6?   5      ?? 5      " ??6   .?5      ??  ?@?OverridesDefaultStyle$
 True??6:   ?? 5       ? ??
 ?????6/   ?? 5       ? ?? 5      ?? 5      " ??6*   .R?5      ? .+?5    "   ?? $	 13??6)   
??? ? ?6;   ?? 5!   "   $??Center=?63   $??Center=?6P   5"      5#      5%       5&      P? 5'       ?@J?IsMouseOver$
 True??65   . ?5(      ??  ? ?? 5)      ?? 5*   "   " ??62   .R?5+   &   ? .+?5,   *   A? 
????  ?62   ?? 5-   *   $??Center=?6;   $??Center=?6V   5.   '   5/   #   51      52      54      55      .+?57   
   ?? $??QUẢN LÝ BÁN HÀNG??6   $??20(?6+   $
??Bold"?69   
????? ?$??Center=?6a   $??0,22,0,0q?6~   $	??Top=?6?   ?? 58   
   $??Mã sản phẩm:??6   $
??Left=?6'   $??	65,60,0,0q?6B   $	??Top=?6U   ?? 59   
   $??Tên sản phẩm:??6   $
??Left=?6(   $??	65,90,0,0q?6C   $	??Top=?6V   ?? 5:   
   $??Mã loại:??6   $
??Left=?6#   $??
65,120,0,0q?6>   $	??Top=?6R   ?? 5;   
   $??Số lượng:??6   $
??Left=?6$   $??
65,150,0,0q?6?   $	??Top=?6S   ?? 5<   
   $??Đơn giá:??6   $
??Left=?6#   $??
65,180,0,0q?6>   $	??Top=?6R   ?? 5>   
   -   5        $??txt_MaSP??5>      $
??Left=?6"   $??
226,63,0,0q?6=   
 ?? TextWrapping$

 Wrap=?6Q   $	??Top=?6e   $	??174??6}   $??20??6?   ?? 5?   
   -   5        $??	txt_TenSP??5?      $
??Left=?6#   $??
226,93,0,0q?6>   $

 Wrap=?6R   $	??Top=?6f   $	??279??6~   $??20??6?   ?? 5@   
   -   5         ??Name$ txt_SoLuong??5@      $
??Left=?6'   $??226,153,0,0q?6B   $

 Wrap=?6W   $	??Top=?6k   $	??113??6?   $??20??6?   ?? 5A   
   -   5        $ 
txt_DonGia??5A      $
??Left=?6&   $??226,183,0,0q?6A   $

 Wrap=?6V   $	??Top=?6j   $	??174??6?   $??20??6?   ?? 5C   
   -   5        $??
cbo_LoaiSP??5C      $
??Left=?6%   $??226,122,0,0q?6@   $	??Top=?6U   $	??174??6m   &   System.Windows.Controls.DataGrid  5E   
   -   5        $??dgv_DS??5F         AlternatingRowBackground
 ????   AutoGenerateColumns$ False??5H         CanUserAddRows$ False??5I      $??65,223,72,78q?5J         Columns 5K      0  *System.Windows.Controls.DataGridTextColumn  5L      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã sản phẩm??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 110 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   ?? *MaSp+6S     5M      $ Tên sản phẩm??6%   $	 120 6U    6;   ?? *TenSp+6U     5N      $ Mã loại sản phẩm??6%   $	 110 6Z    6?   ?? *MaLoai+6Z     5O      $ Số lượng??6%   $ 90 6S    67   ?? *	SoLuong+6S     5P      $ 
Đơn giá??6%   $	 100 6Q    66   ?? *DonGia+6Q     5Q      $ Thành tiền??6%   $ * 6W    69   ?? *	ThanhTien+6W   5S      ?? 5U   
   -   5        $??btn_Add??5U      $??Thêm??6    $
??Left=?6/   $??
124,0,0,10q?6J   $??Bottom=?6^   $??24??6y   $??78??6?   6?   ?? 5V   
   -	   5        $??
btn_Change??5V      $??Sửa??6#   $
??Left=?61   $??
233,0,0,10q?6L   $??Bottom=?6`   $??24??6{   $??78??6?   6?   ?? 5W   
   -
   5         ??Name$ 
btn_Remove??5W      $
??Xóa??6%   $
??Left=?63   $??346,377,0,10q?6N   $??Bottom=?6d   $??24??6   $??78??6?   6?   ?? 5X   
   -   5        $ 
btn_Search??5X      $
??Tìm??6%   $
??Left=?63   $??462,377,0,10q?6N   $??Bottom=?6d   $??24??6   $??78??6?   6?   ?? 5Y   
   -   5        $ btn_Statistical??5Y      $??Thống kê??6*   $
??Left=?6=   $??571,377,0,10q?6X   $??Bottom=?6n   $??24??6?   $??78??6?   6?   5Z      5[      