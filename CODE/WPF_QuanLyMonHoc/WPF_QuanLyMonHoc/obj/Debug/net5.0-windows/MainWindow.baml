   M S B A M L   `   `   `  ????K  GWPF_QuanLyMonHoc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WPF_QuanLyMonHocWPF_QuanLyMonHoc  5   	   !    WPF_QuanLyMonHoc.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WPF_QuanLyMonHoc     5   	   -   5          ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   .??5	      ? $??	0,0,0,-16q?6    ? 	Resources 5
   
    ?? 
TargetType ?? Property ?? Value ?? 
TargetType??%$  '??       ?? 5      " ??6   .?5      ??  ?@?OverridesDefaultStyle$
 True??6;   ?? 5       ? ?? 5      ?? 5      " ??6*   .R?5      ? .+?5   "   A? 
??? ? ?6*   ?? 5   "   $??Center=?63   $??Center=?6N   5      5      5      5      5       ? ColumnDefinitions 5   
   ?? 5      .+?5   
   ?? $??QUẢN LÝ MÔN HỌC??6   
???OO/?$??20(?6E   $
??Bold"?6S   $??Center=?6e   $??0,10,0,0q?6?   $	??Top=?6?   ?? 5   
   $??Mã môn??6   $
??Left=?6!   $??	66,50,0,0q?6<   $	??Top=?6O   ?? 5   
   $??	Tên môn??6   $
??Left=?6"   $??	66,90,0,0q?6=   $	??Top=?6P   ?? 5   
   $??	Tên khoa??6   $
??Left=?6#   $??
66,130,0,0q?6>   $	??Top=?6R   ?? 5    
   $??	Số tín??6   $
??Left=?6!   $??
66,170,0,0q?6<   $	??Top=?6P   ?? 5!   
   $??
Đơn giá??6   $
??Left=?6"   $??
66,210,0,0q?6=   $	??Top=?6Q   ?? 5#   
   -   5        $??	txt_MaMon??5#      $
??Left=?6#   $??
197,54,0,0q?6>    ?? TextWrapping$
 Wrap=?6R   $	??Top=?6f   $	??178??6~   $??22??6?   ?? 5$   
   -   5         ??Name$ 
txt_TenMon??5$      $
??Left=?6&   $??
197,94,0,0q?6A   $
 Wrap=?6U   $	??Top=?6i   $	??239??6?   $??22??6?   ?? 5%   
   -   5        $ 	txt_SoTin??5%      $
??Left=?6%   $??197,174,0,0q?6@   $
 Wrap=?6U   $	??Top=?6i   $	??138??6?   $??22??6?   ?? 5&   
   -   5        $ 
txt_DonGia??5&      $
??Left=?6&   $??197,217,0,0q?6A   $
 Wrap=?6V   $	??Top=?6j   $	??178??6?   $??22??6?   ?? 5(   
   -   5        $??
cbo_DSKhoa??5(      $
??Left=?6%   $??197,132,0,0q?6@   $	??Top=?6U   $	??178??6m   &   System.Windows.Controls.DataGrid  5)   
   -   5        $??dgv_DS??5*      	   AutoGenerateColumns$	 False??5+      
   CanUserAddRows$
 False??5,         AlternatingRowBackground
 ??? ?$??66,260,42,75q?5.         Columns 5/      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã môn??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 110 6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   ?? *MaMon+6O     51      $ 	Tên môn??6%   $	 130 6Q    66   ?? *TenMon+6Q     52      $ Mã Khoa??6%   $	 110 6Q    66   ?? *MaKhoa+6Q     53      $ 	Số tín??6%   $	 110 6O    65   ?? *SoTin+6O     54      $ 
Đơn giá??6%   $	 110 6Q    66   ?? *DonGia+6Q     55      $ Thành tiền??6%   $ * 6W    69   ?? *	ThanhTien+6W   57      ?? 59   
   -   5         ??Name$ btn_Add??59      $??Thêm??6#   $
??Left=?62   $??148,394,0,0q?6M   $	??Top=?6b   $??27??6z   $??89??6?   6?   ?? 5:   
   -	   5        $ btn_Changer??5:      $??Sửa??6'   $
??Left=?65   $??286,394,0,0q?6P   $	??Top=?6e   $??27??6}   $??89??6?   6?   ?? 5;   
   -
   5        $ 
btn_Remove??5;      $
??Xóa??6&   $
??Left=?64   $??412,394,0,0q?6O   $	??Top=?6d   $??27??6|   $??89??6?   6?   ?? 5<   
   -   5        $ 
btn_Search??5<      $
??Tìm??6&   $
??Left=?64   $??541,394,0,0q?6O   $	??Top=?6d   $??27??6|   $??89??6?   6?   5=      5>      