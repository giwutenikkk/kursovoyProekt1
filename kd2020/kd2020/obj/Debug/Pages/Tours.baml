   M S B A M L   `   `   `  ����A  =kd2020, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:kd2020.Pageskd2020.Pages  5          kd2020.Pages.Tours   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:kd2020.Pages     5      -   5          N� Title$  Tours��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��35* �6   �� 5      $
��141* �6   �� 5      $	��41* �6   �� 5      $	��19* �6   .+�5   
   �� -   5         ��Name$
 BtnT��5   #   $��Таблицы��6   $��Center=�6D   $��349,46.8,351,8.6q�6a   $	��101��6{   $��2��6�   $��24��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFDEECEC��6#    � Offset$ 0Q�65   � 5      $ 	#FFFFC6AC��6#   $ 1Q�65   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
DgridTours��5         AutoGenerateColumns .  	   
IsReadOnly	 . $��
0,66,0,0.2q�6U   $��2��6i   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер тура��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *tourId+6`     5      $ 
Город��6%   $ * 6W    64   �� *towns.townName+6c     5      $# Количество дней��6%   $ * 6Z    6>   �� *	daysQnt+6f     5      $ Дата отъезда��6%   $ * 6]    6;   �� *dateDeparture+6i     5       $ Дата приезда��6%   $ * 6Z    6;   �� *
dateArrive+6f     5!      $) #Количество путёвок��6%   $ * 6_    6A   �� *	ticketQnt+6k     5"      $ Цена��6%   $ * 6Q    63   �� *	tourPrice+6]   4  .System.Windows.Controls.DataGridTemplateColumn  5#      $
 auto 6)      CellTemplate 5$      �� 5%      .R�5&      �� $ Editbtn��6%   -   5        $ ��Редактировать��5&   6   ��5'   "   �� 5(   &   $ 0.5,1&�6:   $ 0.5,0&�6K   .��5)   *   � $ 	#FFDEECEC��67   $ 0Q�6I   � 5*   *   $ 	#FFFFC6AC��67   $ 1Q�6I   5+   '   5-      5.      50      52      �� 53   
   -   5        $��BtnAdd��53   L   $��Добавить��6   $��2��6$   $
��Left=�61   $��145,46.8,0,8.6q�6o   $	��101��6�   $
��23.2��6�   ��54      �� 55      $ 0.5,1&�6&   $ 0.5,0&�67   .��56      � $ 	#FFDEECEC��6#   $ 0Q�65   � 57      $ 	#FFFFC6AC��6#   $ 1Q�65   58      5:      �� 5;   
   -   5        $��BtnDel��5;   L   $��Удалить��6   $��2��6#   $��Right=�60   $��0,46.8,145,8.6q�6o   $	��101��6�   $
��23.2��6�   ��5<      �� 5=      $ 0.5,1&�6&   $ 0.5,0&�67   .��5>      � $ 	#FFDEECEC��6#   $ 0Q�65   � 5?      $ 	#FFFFC6AC��6#   $ 1Q�65   5@      5B      5C      5D      