   M S B A M L   `   `   `  ????D  @OOOMuscle, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:OOOMuscle	OOOMuscle  5   	       OOOMuscle.Manager   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:OOOMuscle     5   	   -   5          ? Title$  Manager??5   	   $	??631??6   $	??800??6&    ? Icon$ win.png??62   $??Comic Sans MS)?6A   $??24(?6\   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $
??179* ?6   ?? 5      $
??613* ?6   .+?5   
   ?? -   5         ??Name$ order??5      $
??Left=?6"   $??	0,113,0,0q?6=   $	??Top=?6P   $	??169??6h   $??36??6t   6?   ?? 5   
   $??Номер заказа??6   $
??Left=?6'   $??0,57,0,0q?6B   $	??Top=?6T   $??51??6l   $	??169??6x    J? RenderTransformOrigin$ -0.395,0.615&?6?   ? 5   
   $
??Left=?6   $??52??6*   $	??Top=?66   $	??792??6N   $??2??6Z   ???	#FFAAFF97.+?5      ?? $
??Left=?6   $??52??6/   $	??Top=?6;   $??Files/master.jpg??6S   $	??159??6m   5      ? 5   
   $
??Left=?6   $	??792??6*   $??2??66   ???	#FFAAFF97$??	0,570,0,0q?6a   ?? 5   
   $??Менеджер??6   $
??Left=?6#   $??	165,1,0,0q?6>   $	??Top=?6Q   $??51??6i   $	??169??6u   $ -0.395,0.615&?6?   $??1??6?   ?? 5   
   -   5         ??Name$ nazad??5      $??
Назад??6    $??1??60   $
??Left=?6@   $??	450,0,0,0q?6[   $	??Top=?6n   $	??163??6?   $ 
0.12,0.243&?6?   $??52??6?   6?   ?? 5   
   $1??+|

|
|
|
|
|
|
|
|
|
|
| 
|
|??6   $
??Left=?6?   $??
174,63,0,0q?6?   $	??Top=?6?   $	??507??6?   $??15??6
  $ -0.395,0.615&?6  
??????????	#FFD100FF$??2??6d  ?? 5   
   -   5         ??Name$ fiooo??5      $??1??6!   $
??Left=?61   $??40??6L   $??349,154,0,0q?6X    ?? TextWrapping$
 Wrap=?6m   $	??Top=?6?   $	??249??6?   ?? 5   
   $??ФИО:??6   $
??Left=?6   $??349,112,0,0q?6:   $	??Top=?6O   $??37??6g   $	??192??6s   $ -0.395,0.615&?6   $??1??6?   ?? 5   
   $??------------------------??6   $??1??63   $
??Left=?6C   $??
349,82,0,0q?6^   $	??Top=?6r   
??????????	#FFE85DFF$	??254??6?   $??38??6?   ?? 5   
   $+??%-------------------------------------??6   $??1??6@   $
??Left=?6P   $??	10,82,0,0q?6k   $	??Top=?6~   
??????????	#FFE85DFF$	??324??6?   $??38??6?   ?? 5   
   $'??!Просмотреть заказ??6   $??1??6,   $
??Left=?6<   $??	60,57,0,0q?6W   $	??Top=?6j   $	??231??6?   $ 0.372,0.512&?6?   ?? 5   
   $!??Изменить заказ??6   $??1??6)   $
??Left=?69   $??
367,57,0,0q?6T   $	??Top=?6h   $	??231??6?   $ 0.372,0.512&?6?   ?? 5   
   $??Код:??6   $
??Left=?6   $??349,194,0,0q?6:   $	??Top=?6O   $??41??6g   $	??192??6s   $ -0.395,0.615&?6   $??1??6?   ?? 5   
   -   5        $	 Kod??5      $??1??6   $
??Left=?6/   $??40??6J   $??349,235,0,0q?6V   $
 Wrap=?6k   $	??Top=?6   $	??249??6?   6?   ?? 5   
   -   5         ??Name$ Address??5      $??Адрес:??6!   $
??Left=?62   $??349,280,0,0q?6M   $	??Top=?6b   $??41??6z   $	??192??6?   $ -0.395,0.615&?6?   $??1??6?   ?? 5    
   -   5        $ adress??5       $
??Left=?6#   $??349,326,0,0q?6>   $	??Top=?6S   $	??249??6k   $??36??6w   $??1??6?   ?? 5!   
   -   5        $ Address_Copy??5!      $??Статус:??6&   $
??Left=?68   $??349,367,0,0q?6S   $	??Top=?6h   $??41??6?   $	??192??6?   $ -0.395,0.615&?6?   $??1??6?   ?? 5"   
   -	   5        $ status??5"      $
??Left=?6#   $??349,413,0,0q?6>   $	??Top=?6S   $	??249??6k   $??36??6w   $??1??6?   ?? 5#   
   -
   5        	 ??Name$
	 list??5#      $??1??6    $
??Left=?60   $	??452??6K   $??
15,113,0,0q?6X   $	??Top=?6l   $	??314??6?   ?? 5$   
   $#??|

|
|
|
|
|
|
|
|
|
|
| 
|
|??6   $
??Left=?6p   $??
329,77,0,0q?6?   $	??Top=?6?   $	??488??6?   $??15??6?   $ -0.395,0.615&?6?   
??????????	#FFD100FF$??1??6  ?? 5%   
   -   5        $ zamena??5%      $!??Изменить заказ??6!   $??1??6:   $
??Left=?6J   $??349,469,0,0q?6e   $	??Top=?6z   $	??249??6?   $??53??6?   6?   ?? 5&   
   $??Дата заказа:??6   $
??Left=?6'   $??	0,184,0,0q?6B   $	??Top=?6U   $??51??6m   $	??169??6y   $ -0.395,0.615&?6?   ???	#FFE800FF6?   ?? 5'   
   -   5        $ N??5'      $??-??6   $
??Left=?6'   $??	0,235,0,0q?6B   $	??Top=?6U   $??51??6m   $	??169??6y   $ -0.395,0.615&?6?   ?? 5(   
   $ ??Дата доставки:??6   $
??Left=?6)   $??	0,280,0,0q?6D   $	??Top=?6W   $??51??6o   $	??179??6{   $ -0.395,0.615&?6?   $??20(?6?   ???	#FFE800FF6?   ?? 5)   
   -   5        $ D??5)      $??-??6   $
??Left=?6'   $??	0,326,0,0q?6B   $	??Top=?6U   $??51??6m   $	??169??6y   $ -0.395,0.615&?6?   5+      5,      