   M S B A M L   `   `   `  ����A  =kd2020, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:kd2020.Pageskd2020.Pages  5          kd2020.Pages.Towns   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:kd2020.Pages     5      -   5          N� Title$  Towns��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��35* �6   �� 5      $
��141* �6   �� 5      $	��41* �6   �� 5      $	��19* �6   .+�5   
   �� -   5         ��Name$
 BtnT��5   #   $��Таблицы��6   $��Center=�61   $��349,46.8,351,8.6q�6N   $	��100��6h   $��23��6�   $��2��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFDEECEC��6#    � Offset$ 0Q�65   � 5      $ 	#FFFFC6AC��6#   $ 1Q�65   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
DgridTowns��5         AutoGenerateColumns .  	   
IsReadOnly	 . $��
0,66,0,0.2q�6U   $��2��6i   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер города��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *townId+6d     5      $ Страна��6%   $	 200 6]    65   �� *country.countryName+6k     5      $ 
Город��6%   $ * 6Q    64   �� *
townName+6]   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)      CellTemplate 5       �� 5!      .R�5"      �� $ EditBtnT��6%   -   5        $ ��Редактировать��5"   7   ��5#   "   �� 5$   &   $ 0.5,1&�6:   $ 0.5,0&�6K   .��5%   *   � $ 	#FFDEECEC��67   $ 0Q�6I   � 5&   *   $ 	#FFFFC6AC��67   $ 1Q�6I   5'   '   5)      5*      5,      5.      �� 5/   
   -   5        $ AddBtn��5/   ?   $��Добавить��6   $
��Left=�6$   $��145,46.8,0,8.6q�6O   $	��100��6g   $
��23.2��6�   $��2��6�   ��50      �� 51      $ 0.5,1&�6&   $ 0.5,0&�67   .��52      � $ 	#FFDEECEC��6#   $ 0Q�65   � 53      $ 	#FFFFC6AC��6#   $ 1Q�65   54      56      �� 57   
   -   5        $ DelBtn��57   ?   $��Удалить��6   $��Right=�6#   $��0,46.8,145,8.6q�6O   $	��101��6g   $
��23.2��6�   $��2��6�   ��58      �� 59      $ 0.5,1&�6&   $ 0.5,0&�67   .��5:      � $ 	#FFDEECEC��6#   $ 0Q�65   � 5;      $ 	#FFFFC6AC��6#   $ 1Q�65   5<      5>      5?      5@      