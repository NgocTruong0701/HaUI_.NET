   M S B A M L   `   `   `  ????A  =OnTap2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:OnTap2OnTap2  5   	       OnTap2.Search   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:OnTap2     5   	   -   5          ? Title$  Search??5   	   $	??450??6   $	??800??6%   .??5	      ?  ? 	Resources 5
   
   =  7System.Windows.Controls.Primitives.DataGridColumnHeader ?? 
TargetType ?? Property ?? Value??%?   '        ?? 5      "  6   .?5      ??  ? ??$
 Bold"?6/   ?? 5       ? ??$ Center=?6?   ?? 5       ? ??$ 14(?6-   5      5       ? ColumnDefinitions 5   
   ?? 5      $	??33* ?6   ?? 5      $
??767* ?6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5        $??dgv_DS??5         AlternatingRowBackground
 ??? ?   AutoGenerateColumns$ False??5         CanUserAddRows$ False??5      $??38,57,71,99q?5      $??1??6"   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 
Mã phòng??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 110 6S   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   ?? *	MaPhong+6S     5      $
 Mã nhân viên??6%   $	 110 6T    6;   ?? *MaNv+6T     5      $
 	Họ tên??6%   $	 120 6O    65   ?? *Hoten+6O     5          
Foreground
 ??  ?$
 Lương??67   $	 100 6`    6F   ?? *Luong+6`     5!      
 ??  ?$
 	Thường??67   $	 100 6b    6G   ?? *Thuong+6b     5"      
 ??  ?   
FontWeight$ Black"?67   $
 Tổng tiền??6J   $ * 6z    6]   ?? *
TongTien+6z   5$      5%      5&      