   M S B A M L   `   `   `  ????E  AWPF_OnTap1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WPF_OnTap1
WPF_OnTap1  5   	       WPF_OnTap1.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WPF_OnTap1     5   	   -   5          ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)   $??Times New Roman)?65   .??5	      ?  ? 	Resources 5   
    ?? 
TargetType ?? Property ?? Value=  7System.Windows.Controls.Primitives.DataGridColumnHeader ?? 
TargetType??%o  '??       '  {     '?? ?     ?? 5      " ??6   .?5      ??  ? ??$ Times New Roman)?6/   ?? 5       ? ??
 ??  ?6/   5      ?? 5      "  6   .?5      ??  ? ??$
 Bold"?6/   ?? 5       ? ??$ Center=?6?   5      ?? 5      " ??6   .?5      ??  ?@?OverridesDefaultStyle$
 True??6:   ?? 5       ? ??$ 20(?6-   ?? 5       ? ??$
 Bold"?6/   ?? 5!       ? ?? 5"      ?? 5$      " ??6*   .R?5&      ? .+?5(   "   A? 
???????6*   ?? 5*   "   $??Center=?63   $??Center=?6N   5+      5,      5.      5/      50      .+?52   
   ?? $??Mã bệnh nhân:??6   $
??Left=?6(   $??	31,25,0,0q?6C   $	??Top=?6V   ?? 53   
   $??
Họ tên:??6   $
??Left=?6"   $??	31,55,0,0q?6=   $	??Top=?6P   ?? 54   
   $??Số ngày nằm viện:??6   $
??Left=?6,   $??	31,85,0,0q?6G   $	??Top=?6Z   ?? 55   
   $??Khoa khám:??6   $
??Left=?6%   $??
31,115,0,0q?6@   $	??Top=?6T   ?? 57   
   -   5        $??txt_MaBN??57      $
??Left=?6"   $??Center=?6=   $??
196,25,0,0q?6_    ?? TextWrapping$
 Wrap=?6s   $	??Top=?6?   $	??204??6?   $??24??6?   ?? 58   
   -   5         ??Name$ 	txt_HoTen??58      $
??Left=?6%   $??Center=?6@   $??
196,55,0,0q?6b   $
 Wrap=?6v   $	??Top=?6?   $	??284??6?   $??24??6?   ?? 59   
   -   5        $ txt_SoNgayNV??59      $
??Left=?6(   $??Center=?6C   $??
196,85,0,0q?6e   $
 Wrap=?6y   $	??Top=?6?   $	??165??6?   $??24??6?   ?? 5;   
   -   5        $??cbo_Khoa??5;      $
??Left=?6#   $??196,117,0,0q?6>   $	??Top=?6S   $	??204??6k   $??22??6w   &   System.Windows.Controls.DataGrid  5=   
   -   5        $??dgv_DS??5>         CanUserAddRows$ False??5?      	   AutoGenerateColumns$	 False??5@      
   AlternatingRowBackground

 ?????$??31,158,56,104q?5B         Columns 5C      0  *System.Windows.Controls.DataGridTextColumn  5D      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã bệnh nhân??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 130 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   ?? *MaBn+6T     5E      $ 	Họ tên??6%   $	 150 6O    65   ?? *HoTen+6O     5F      $ Mã khoa??6%   $	 130 6Q    66   ?? *MaKhoa+6Q     5G      $ Số ngày nằm viện??6%   $	 130 6a    6?   ?? *SoNgayNamVien+6a     5H         
FontWeight$
 Bold"?6%   $ Viện phí??67   $ * 6e    6I   ?? *	VienPhi+6e   5J      ?? 5L   
   -   5         ??Name$ btn_Add??5L      $??Thêm??6"   $
??Left=?61   $??179,363,0,0q?6L   $	??Top=?6a   $??44??6y   $	??159??6?   6?   ?? 5M   
   -   5        $ 
btn_Search??5M      $
??Tìm??6%   $
??Left=?63   $??419,363,0,0q?6N   $	??Top=?6c   $??44??6{   $	??158??6?   6?   5N      5O      