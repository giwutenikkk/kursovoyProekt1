   M S B A M L   `   `   `  ����A  =kd2020, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:kd2020.Pageskd2020.Pages  5          kd2020.Pages.Roles   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:kd2020.Pages     5      -   5          N� Title$  Roles��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��35* �6   �� 5      $
��141* �6   �� 5      $	��41* �6   �� 5      $	��19* �6   .+�5   
   �� -   5         ��Name$
 BtnT��5   #   $��Таблицы��6   $��Center=�6D   $��349,46.8,351,8.6q�6a   $	��100��6{   $��2��6�   $
��23.2��6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FFDEECEC��6#    � Offset$ 0Q�65   � 5      $ 	#FFFFC6AC��6#   $ 1Q�65   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
DgridRoles��5         AutoGenerateColumns .  	   
IsReadOnly	 . $��
0,66,0,0.2q�6U   $��2��6i   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$) #Фамилия сотрудника��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6c   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *staffs.lname+6o     5      $ 
Логин��6%   $ * 6N    64   �� *login+6Z     5      $ Пароль��6%   $ * 6R    65   �� *
password+6^     5      $ Роль��6%   $ * 6L    63   �� *role+6X   4  .System.Windows.Controls.DataGridTemplateColumn  5!      $
 auto 6)      CellTemplate 5"      �� 5#      .R�5$      �� $ Editbtn��6%   -   5        $ ��Редактировать��5$   6   ��5%   "   �� 5&   &   $ 0.5,1&�6:   $ 0.5,0&�6K   .��5'   *   � $ 	#FFDEECEC��67   $ 0Q�6I   � 5(   *   $ 	#FFFFC6AC��67   $ 1Q�6I   5)   '   5+      5,      5.      50      �� 51   
   -   5        $��BtnAdd��51      $��Добавить��64   $
��Left=�6G   $��145,46.8,0,8.6q�6b   $��2��6z   $	��101��6�   $��23��6�   ��52      �� 53      $ 0.5,1&�6&   $ 0.5,0&�67   .��54      � $ 	#FFDEECEC��6#   $ 0.008Q�65   � 55      $ 	#FFFFC6AC��6#   $ 1Q�65   56      58      �� 59   
   -   5        $ BtnDel��59      $��Удалить��66   $��Right=�6H   $��0,46.8,145,8.6q�6d   $��2��6|   $	��101��6�   $��23��6�   ��5:      �� 5;      $ 0.5,1&�6&   $ 0.5,0&�67   .��5<      � $ 	#FFDEECEC��6#   $ 0Q�65   � 5=      $ 	#FFFFC6AC��6#   $ 1Q�65   5>      5@      5A      5B      