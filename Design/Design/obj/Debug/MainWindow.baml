   M S B A M L   `   `   `  ����A  =Design, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DesignDesign  5   	       Design.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Design     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�5	   	    � WindowStyle$
 None=�5
   	   .��5      � ���#F8F3F2 � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      .+�5   
   �� -   5        ���#050038$��0��5      5      � 5   
   $��0��6    � ColumnDefinitions 5      �� 5      $
��134* �6#   �� 5      $
��134* �6#   �� 5      $
��133* �6#   �� 5      $
��133* �6#   �� 5      $
��205* �6#   �� 5      $	��61* �6#   .+�5      �� -   5        $��BtnExit��5"      $��X��5      $��5��5         SuperButton#��[  5       
���  ��$��40��5!   &   $��	11,8,10,0q�5"   $   $��25��67   $	��Top=�6C   6[   �� 5#      -   5        $��BtnMenu��5&      $��1��5#      $��Меню��5$      #��[  5%      5&       �� 5'      -   5        $��2��5'      $��Автомобили��5(      #��[  5)      66   �� 5*      -   5        $��	BtnDriver��5+      $��3��5*      $��Водители��5,      #��[  5-      6:   �� 5.      -   5        $��BtnOrder��51      $��4��5.      $��Заказы��5/      #��[  50      51   %   52       � 53   
   -   5        $��FrmMain��54        � NavigationUIVisibility$ Hidden=�53      $��1��55      56      57      