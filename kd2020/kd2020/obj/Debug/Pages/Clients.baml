   M S B A M L   `   `   `  ����A  =kd2020, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:kd2020.Pageskd2020.Pages  5          kd2020.Pages.Clients   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:kd2020.Pages     5      -   5          N� Title$  Clients��5      $��454.762��6@   .��5
      �  � RowDefinitions 5   
   �� 5      $	��35* �6   �� 5      $
��141* �6   �� 5      $	��41* �6   �� 5      $	��19* �6   .+�5   
   �� -   5         ��Name$
 BtnT��5   #   $��Таблицы��6   $��Center=�6D   $��349,46.8,351,8.6q�6a   $	��101��6{   $��2��6�   $��23��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFDEECEC��6#    � Offset$ 0.048Q�65   � 5      $ 	#FFFFC6AC��6#   $ 1Q�65   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DgridClients��5         AutoGenerateColumns .  	   
IsReadOnly	 . $��
0,66,0,0.4q�6W   $��2��6k   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер клиента��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *
clientId+6e     5      $ Фамилия��6%   $ * 6P    66   �� *lname+6\     5      $ Имя��6%   $ * 6L    62   �� *fname+6X     5      $ Отчество��6%   $ * 6Q    67   �� *mname+6]     5      $! Номер паспорта��6%   $ * 6\    6=   �� *
passportId+6h     5       $! Серия паспорта��6%   $ * 6]    6=   �� *passportSer+6i   4  .System.Windows.Controls.DataGridTemplateColumn  5!      $
 auto 6)      CellTemplate 5"      �� 5#      .R�5$      �� $ Editbtn��6%   -   5        $ ��Редактировать��5$   6   ��5%   "   �� 5&   &   $ 0.5,1&�6:   $ 0.5,0&�6K   .��5'   *   � $ 	#FFDEECEC��67   $ 0Q�6I   � 5(   *   $ 	#FFFFC6AC��67   $ 1Q�6I   5)   '   5+      5,      5.      50      �� 51   
   -   5        $ AddBtn��51   L   $��Добавить��6   $��2��6$   $
��Left=�61   $��145,46.8,0,8.6q�6\   $	��101��6t   $
��23.2��6�   ��52      �� 53      $ 0.5,1&�6&   $ 0.5,0&�67   .��54      � $ 	#FFDEECEC��6#   $ 0Q�65   � 55      $ 	#FFFFC6AC��6#   $ 1Q�65   56      58      �� 59   
   -   5        $ DelBtn��59   L   $��Удалить��6   $��2��6#   $��Right=�60   $��0,46.8,145,8.6q�6\   $	��101��6t   $
��23.2��6�    J� RenderTransformOrigin$ 
0.117,1.19&�6�   ��5:      �� 5;      $ 0.5,1&�6&   $ 0.5,0&�67   .��5<      � $ 	#FFDEECEC��6#   $ 0Q�65   � 5=      $ 	#FFFFC6AC��6#   $ 1Q�65   5>      5@      5A      5B      