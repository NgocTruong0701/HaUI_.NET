   M S B A M L   `   `   `  ????J  FWPF_DB_QLKETQUA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WPF_DB_QLKETQUAWPF_DB_QLKETQUA  5   	        WPF_DB_QLKETQUA.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WPF_DB_QLKETQUA     5   	   -   5          ? Title$  Nhập điểm??5   	   $	??600??6   $	??900??6(   $??TimeNewRoman)?5	   	   $??16(?5
   	   $??Italic$?5   	   .??5      ? $??0,0,-2,0q?6   .+?5   
   ?? $??Mã sinh viên??6   $
??Left=?6'   $??	27,27,0,0q?6B   $	??Top=?6U   ?? 5   
   $??Tên môn học??6   $
??Left=?6&   $??	27,79,0,0q?6A   $	??Top=?6T   ?? 5   
   $??Điểm??6   $
??Left=?6   $??
27,135,0,0q?6:   $	??Top=?6N   ?? 5   
   -   5        $??txt_MaSV??5      $??Center=?6"   $
??Left=?6D   $??
195,23,0,0q?6_    ?? TextWrapping$
 Wrap=?6s   $	??Top=?6?   $	??346??6?   $??37??6?   ?? 5   
   -   5        $??txt_Diem??5      $??Center=?6"   $
??Left=?6D   $??195,131,0,0q?6_   $
 Wrap=?6t   $	??Top=?6?   $	??173??6?   $??37??6?   ?? 5   
   -   5        $??cbo_Mon??5      $
??Left=?6"   $??
195,81,0,0q?6=   $	??Top=?6Q   $	??255??6i   &   System.Windows.Controls.DataGrid  5   
   -   5        $??dgv_KQ??5      $??51,194,54,128q?5         AutoGenerateColumns$ False??5         AlternatingRowBackground
 ?????   CanUserAddRows$ False??5         Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã sinh viên??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 280 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   ?? *MaSv+6T     5#      $ Mã môn học??6%   $	 280 6R    69   ?? *MaMh+6R     5$      $ Điểm??6%   $ * 6L    63   ?? *Diem+6L   5'      ?? 5*   
   -   5        $??btn_Add??5*      $??Thêm??6    $
??Left=?6/   $??
83,493,0,0q?6J   $	??Top=?6^   	 J? RenderTransformOrigin$	 0.5,0.5&?6v   $??31??6?   $	??124??6?   6?   ?? 5+   
   -   5        
 ??Name$
 
btn_Change??5+      $??Sửa??6%   $
??Left=?63   $??226,493,0,0q?6N   $	??Top=?6c   $	 0.5,0.5&?6{   $??31??6?   $	??124??6?   6?   ?? 5,   
   -   5        $
 
btn_Remove??5,      $
??Xóa??6%   $
??Left=?63   $??374,493,0,0q?6N   $	??Top=?6c   $	 0.5,0.5&?6{   $??31??6?   $	??124??6?   ?? 5-   
   -	   5        $
 
btn_Search??5-      $
??Tìm??6%   $
??Left=?63   $??527,493,0,0q?6N   $	??Top=?6c   $	 0.5,0.5&?6{   $??31??6?   $	??124??6?   ?? 5.   
   -
   5        $
 btn_Statistical??5.      $??Thống kê??6*   $
??Left=?6=   $??688,493,0,0q?6X   $	??Top=?6m   $	 0.5,0.5&?6?   $??31??6?   $	??124??6?   5/      50      