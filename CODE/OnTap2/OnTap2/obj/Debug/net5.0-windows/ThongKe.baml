   M S B A M L   `   `   `  ????A  =OnTap2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:OnTap2OnTap2  5   	       OnTap2.ThongKe   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:OnTap2     5   	   -   5          ? Title$  ThongKe??5   	   $	??450??6   $	??800??6&   .??5	      ?  ? 	Resources 5
   
   =  7System.Windows.Controls.Primitives.DataGridColumnHeader ?? 
TargetType ?? Property ?? Value??%?   '        ?? 5      "  6   .?5      ??  ? ??$
 Bold"?6/   ?? 5       ? ??$ Center=?6?   ?? 5       ? ??$ 14(?6-   5      5      .+?5   
   &   System.Windows.Controls.DataGrid  -   5        $??dgv_DS??5         AutoGenerateColumns$ False??5         CanUserAddRows$ False??5         AlternatingRowBackground
 ?????$??31,86,31,85q?5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 
Mã phòng??6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 150 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   ?? *	MaPhong+6S     5      $	 Tên phòng??6%   $	
 170 6U    68   ?? *
TenPhong+6U     5      $	 Số lượng nhân viên??6%   $	
 150 6^    6A   ?? *
CountEmp+6^     5      $	 Tổng lương??6%   $
 * 6W    69   ?? *	SumSalary+6W   5      5      5       