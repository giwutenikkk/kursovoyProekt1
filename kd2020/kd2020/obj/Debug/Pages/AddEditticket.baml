   M S B A M L   `   `   `  ����A  =kd2020, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:kd2020.Pageskd2020.Pages  5           kd2020.Pages.AddEditticket   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:kd2020.Pages     5        N� Title$  AddEditticket��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��93* �6   �� 5      $
��107* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   ��  �� TextAlignment$ Center=�6   $
��Left=�6+   $��147,48.8,0,0q�6F   $��1��6\   $
��Wrap=�6i   $��Номер билета��6}   $	��Top=�6�    J� RenderTransformOrigin$ 0.737,0.688&�6�   �� 5   
   $ Center=�6   $
��Left=�6+   $��176,48.8,0,0q�6F   $��1��6\   $
��Wrap=�6i   $��Номер тура��6}   $	��Top=�6�   $��1��6�   �� 5   
   $ Center=�6   $
��Left=�6+   $��147,29.2,0,0q�6F   $��3��6\   $
��Wrap=�6i   $#��Фамилия клиента��6}   $	��Top=�6�   �� 5   
   $ Center=�6   $
��Left=�6+   $��155,29.4,0,0q�6F   $��3��6\   $
��Wrap=�6i   $)��#Фамилия сотрудника��6}   $	��Top=�6�   $��1��6�   �� 5   
   {�.  $
��Left=�6>   $��23��6Y   $��129,20.6,0,0q�6e   $��2��6{    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��120��6�   ��6   �� *
ticketId+6�   �� 5   
   -   5        $��
tourscroll��5      $
��Left=�6*   $��76��6E   $��147,74.8,0,0q�6Q   $��1��6g    J� 	AllowDrop . $	��Top=�6�   $	��123��6�   $��3��6�   ��. $��Visible=�6�   $��1��6�   �� 5   
   -   5        $��clientscroll��5      $
��Left=�6,   $��76��6G   $��126,74.2,0,0q�6S   $��3��6i    . $	��Top=�6�   $	��123��6�   $��2��6�   ��. $��Visible=�6�   �� 5    
   -   5        $��staffscroll��5       $
��Left=�6+   $��76��6F   $��	147,0,0,0q�6R   $��4��6e    . $	��Top=�6�   $	��123��6�   $��2��6�   ��. $��Visible=�6�   $��1��6�   �� 5"   
   -   5        $��BtnSave��5"      $��Сохранить��66   $��2��6J   $��333,27.8,366,23.6q�6^   $��5��6y   $��100.8��6�   $
��23.2��6�   ��5#      �� 5$       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5%      � 	 � Color$	 	#FFDEECEC��6#   
 � Offset$
 0Q�65   � 5&      $	 	#FFFFC6AC��6#   $
 1Q�65   5'      5)      �� 5*   
   -   5        $
��Back��5*      $��
Назад��60   $��1��6@   $
��Left=�6P   $��140,26.8,0,0q�6k   $��5��6�   $	��Top=�6�   $	��101��6�   $��24��6�   ��5+      �� 5,      $ 0.5,1&�6&   $ 0.5,0&�67   .��5-      � $	 	#FFDEECEC��6#   $
 0Q�65   � 5.      $	 	#FFFFC6AC��6#   $
 1Q�65   5/      51      53      54      