   M S B A M L   `   `   `  ????E  AWPF_OnTap1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPF_OnTap1
WPF_OnTap1  5   	       WPF_OnTap1.Search   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WPF_OnTap1     5   	   -   5          ? Title$  Search??5   	   $	??450??6   $	??800??6%   .??5	      ?  ? 	Resources 5
   
   =  7System.Windows.Controls.Primitives.DataGridColumnHeader ?? 
TargetType ?? Property ?? Value??%|   '        ?? 5      "  6   .?5      ??  ? ??$
 Bold"?6/   ?? 5       ? ??$ Center=?6?   5      5       ? ColumnDefinitions 5   
   ?? 5      $	??21* ?6   ?? 5      $
??139* ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5        $??dgv_DS??5         CanUserAddRows$ False??5         AutoGenerateColumns$ False??5         AlternatingRowBackground
 ?????$??31,158,56,104q?5      $??2??6$   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Mã bệnh nhân??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 130 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   ?? *MaBn+6T     5      $
 	Họ tên??6%   $	 150 6O    65   ?? *HoTen+6O     5      $
 Mã khoa??6%   $	 130 6Q    66   ?? *MaKhoa+6Q     5      $
 Số ngày nằm viện??6%   $	 130 6a    6?   ?? *SoNgayNamVien+6a     5         
FontWeight$
 Bold"?6%   $
 Viện phí??67   $ * 6e    6I   ?? *	VienPhi+6e   5!      5"      5#      