   M S B A M L   `   `   `  ????F  BThuVienSach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ThuVienSachThuVienSach  5   	       ThuVienSach.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ThuVienSach     5   	   -   5          ? Title$  Chọn sách??5   	   $	??450??6   $	??800??6(   $??TimeNewRoman)?64   $??15(?6N   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      .+?5   
   ?? $??
Danh sách??6   $
??Left=?6$   $??	40,34,0,0q?6?   $	??Top=?6R   $??40??6j   $??79??6v    J? RenderTransformOrigin$ 0.5,0.5&?6?   z?5      V? 5      .~?5      ?? ?? 5      ?? 5       ?? Angle$ -0.024Q?6&   T? 5      5      5      ?? 5   
   $??Sách đã chọn??6   $
??Left=?6'   $??
476,34,0,0q?6B   $	??Top=?6V   $??40??6n   $	??108??6z   ?? 5   
   -   5         ??Name$ lst_DanhSachSource??5      $??10,90,488,10q?60    ?? SelectionMode$ Multiple=?6F   5       ?? 5!   
   -   5        $ lst_DanhSachChon??5!      $??476,90,10,10q?6,   $ Multiple=?6B   ?? 5$   
   -   5         ??Name$ btn_Add1??5$      $??>??6#   $??Center=?62   $??	0,112,0,0q?6O   $	??Top=?6b   $??38??6z   $??96??6?   6?   ?? 5%   
   -   5        $ btn_AddN??5%      $??>>??6#   $??Center=?66   $??	0,155,0,0q?6S   $	??Top=?6f   $??38??6~   $??96??6?   6?   ?? 5&   
   -   5        $ 
btn_AddAll??5&      $	??>>>??6%   $??Center=?6<   $??Center=?6Y   $??38??6t   $??96??6?   6?   ?? 5'   
   -   5        $ bnt_Remove1??5'      $??<??6&   $??Center=?65   $??	0,276,0,0q?6R   $	??Top=?6e   $??38??6}   $??96??6?   6?   ?? 5(   
   -   5        $ btn_RemoveN??5(      $??<<??6&   $??Center=?69   $??	0,319,0,0q?6V   $	??Top=?6i   $??38??6?   $??96??6?   6?   ?? 5)   
   -	   5        $ btn_RemoveAll??5)      $	??<<<??6(   $??Center=?6?   $??	0,362,0,0q?6\   $	??Top=?6o   $??38??6?   $??96??6?   6?   5*      5+      