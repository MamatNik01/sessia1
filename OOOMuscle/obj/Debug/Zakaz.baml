   M S B A M L   `   `   `  ????D  @OOOMuscle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:OOOMuscle	OOOMuscle  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       OOOMuscle.Zakaz   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:OOOMuscle     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   -   5          ?Name$  Zakaz1??5   ?    ? Title$ Zakaz??5	   	   $	??483??6   $	??898??6$    ? Icon$I CC:\Users\Nikita\Desktop\OOOMuscle\OOOMuscle\OOOMuscle\Files\win.png??60   $??Comic Sans MS)?6{   $??24         (?6?   .??5
      ?  ? ColumnDefinitions 5   
   ?? 5      $
??223* ?6   ?? 5      $
??569* ?6    ? RowDefinitions 5   
   ?? 5      $	??47* ?6   ?? 5      $
??325* ?6   ?? 5      $	??47* ?6   .+?5   
   ? $
??Left=?6   $??66??6*   $	??Top=?66   $	??890??6N   ???	#FFAAFF97$??2??6q   $??2??6?    5      ?? 5      $
??244* ?6#   ?? 5      $
??297* ?6#   ?? 5      $
??251* ?6#   .+?5      ?? $
??Left=?6   $??66??6/   $	??Top=?6;   $	??201??6S   $??Files/master.jpg??6_   $??22,0,0,0q?6y   ?? 5      -   5         ??Name$	 zak??5      $??
Заказ??6!   $??1??61   $
??Left=?6A   $??
136,13,0,0q?6\   $	??Top=?6p   $??24(?6?   ?? 5      -   5        $ zak_Copy??5      $??Кол-во (шт.)??6&   $
??Left=?6=   $??255,230,0,-207q?6X   $	??Top=?6p   $??24(?6?   $??2??6?   ?? 5      -   5        $ adres??5      $??
Адрес??6#   $
??Left=?63   $??11,310,0,-287q?6N   $	??Top=?6e   $??24(?6}   $??1??6?   ?? 5      -   5        $ 	zak_Copy1??5      $??Дата выдачи:??6'   $
??Left=?6>   $??148,359,0,-336q?6Y   $	??Top=?6q   $??24(?6?   $??1??6?   ?? 5      -   5        $ 	zak_Copy2??5      $??Дата заказа:??6'   $
??Left=?6>   $??148,279,0,-256q?6Y   $	??Top=?6q   $??24(?6?   $??1??6?   ?? 5       -   5        $
 nach??5       $
??-
-??6"   $??301,279,5,-256q?69   $	??Top=?6Q   $??24(?6i   $??1??6w   $??2??6?   ?? 5!      -   5        $ konec??5!      $	??-
-??6#   $
??Left=?65   $??317,359,0,-336q?6P   $	??Top=?6h   $??24(?6?   $??1??6?   $??2??6?   ?? 5"      -	   5        $ order222??5"      $
??-
-??6&   $
??Left=?6=   $??148,237,0,-214q?6X   $	??Top=?6p   $??24(?6?   $??1??6?    J? RenderTransformOrigin$ -1.277,2.744&?6?   
???????
???  ??6?   5#      ?? 5$   
   -
   5         ??Name$ nazad??5$      $??
Назад??6    $
??Left=?60   $??	398,0,0,0q?6K   $	??Top=?6^   $	??241??6v   $??66??6?   $??2??6?   $??24(?6?   $??1??6?   ?? 5%   
   -   5         ??Name$
 name??5%      $
??Left=?6!   $??0,24,0,0q?6<   $??1??6N   $	??Top=?6[   $	??223??6s   6   ?? 5&   
   -   5        	 ??Name$
	 list??5&      $
??Left=?6!   $	??236??6<   $??0,63,0,0q?6I   $??1??6[   $	??Top=?6h   $	??223??6?   
 ?? View
 5'      ?? 5(      .P?5)      ?? 5*      5,      ?? 5-   
   -   5        $ dobavit??5-      $!??Добавить товар??6"   $??
0,299,28,0q?6;   $	??Top=?6O   $??47??6g   $??24(?6s   $??1??6?   &   System.Windows.Controls.DataGrid  5.   
   -   5          Name$ datagrid??5.      $??1??6%   $
??Left=?65   $	??157??6P   $??0,24,0,0q?6]   $??1??6o   $	??Top=?6|   $	??407??6?   ?? 5/   
   -   5        $ oformit??5/      $!??Оформить заказ??6"   $
??Left=?6;   $??407,181,0,0q?6V   $	??Top=?6k   $	??232??6?   $??47??6?   $??24(?6?   $??1??6?   $??1??6?   ?? 50   
   -   5        $ kolvo??50      $??0,221,482,86q?6"   $??1??68   $??1??6E   .@?51      ?? $??1??6   ?? 52      $??2??6   ?? 53      $??3??6   ?? 54      $??4??6   ?? 55      $??5??6   ?? 56      $??6??6   ?? 57      $??7??6   ?? 58      $??8??6   ?? 59      $??9??6   ?? 5:      $??10??6   5;      ?? 5<   
   -   5        $ address??5<      $??0,299,482,13q?6$   $??1??6:   $??1??6G   ? 5=   
   $
??Left=?6   $??48??6*   $	??Top=?66   $	??890??6N   ???	#FFAAFF97$??2??6q   $??2??6~   $??0,2,0,0q?6?   ?? 5>   
   -   5        $ spisok??5>      $!??Список товаров??6!   $
??Left=?6:   $??54,3,0,0q?6U   $	??Top=?6g   $	??232??6   $??47??6?   $??24(?6?   $??2??6?   $??1??6?   5?      5@      