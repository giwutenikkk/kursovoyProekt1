   M S B A M L   `   `   `  ����A  =kd2020, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:kd2020.Pageskd2020.Pages  5          kd2020.Pages.AddEdittour   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:kd2020.Pages     5        N� Title$  AddEdittour��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��375* �6   �� 5      $
��234* �6   �� 5      $
��191* �6    � RowDefinitions 5   
   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��51* �6   �� 5      $	��49* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   �� 5      $	��50* �6   .+�5   
   ��  �� TextAlignment$ Center=�6   $��Номер тура��6+   $��23��6=   $��127,16.4,163.2,10.2q�6I   $��1��6f   $��85��6s   6�   �� 5   
   $ Center=�6   $��
Город��6+   $��42.2,16.4,44,10.2q�68   $��1��6S   $��23��6`   $	��105��6l   $��2��6x   6�   �� 5   
   $ Center=�6   $#��Количество дней��6+   $��42.8,16.4,75.8,11.2q�6B   $��1��6_   $��22��6l   $	��115��6x   $��1��6�   6�   �� 5   
   $ Center=�6   $��Дата отъезда��6+   $��113,15.6,177.2,10.2q�6?   $��3��6\   $��23��6i   $��85��6u   6�   �� 5    
   $ Center=�6   $��Дата приезда��6+   $��71.8,15.6,75.8,8.2q�6?   $��3��6[   $��25��6h   $��86��6t   $��1��6   �� 5!   
   $ Center=�6   $)��#Количество путёвок��6+   $��100,10.4,150.2,13.2q�6E   $��5��6b   $��26��6o   $	��125��6{   6�   �� 5"   
   $ Center=�6   $��Цена��6+   $��82.8,10.4,89.8,7.2q�67   $��5��6S   $��32��6`   $��61��6l   $��1��6w   6�   �� 5#   
   {�.  $	��175��6<   $
��Left=�6H   $��2��6c   $��77,10.8,0,10.4q�6p   ��6$   �� *tourId+6p   �� 5$   
   $��1��6+   $��9.8,10.8,0,10.4q�6;   $��2��6T   $	��175��6a   $
��Left=�6m   ��6   �� *	daysQnt+6�   �� 5%   
   $��77,9.8,0,10.6q�6-   $��6��6D   $	��175��6Q   $
��Left=�6]   ��6   �� *	ticketQnt+6]   �� 5&   
   $��9.8,10.8,0,9.6q�6-   $��6��6E   $	��175��6R   $
��Left=�6^   $��1��6y   ��6   �� *	tourPrice+6y   �� 5'   
   -   5        $��BtnSave��5'   [   $��Сохранить��6   $��8��6%   $��320,17.8,187.8,9.6q�62   $
��Auto��6N   $
��Auto��6�   $��2��6�   ��5(      �� 5)       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5*      �  � Color$ 	#FFDEECEC��6#    � Offset$ 0Q�65   � 5+      $ 	#FFFFC6AC��6#   $ 0.992Q�65   5,      5.      �� 5/   
   -   5        $��townsscroll��5/      $��2��6*   $
��Left=�6:   $	��151��6U   $��42.2,49.4,0,0q�6b   $��1��6y    J� 	AllowDrop . $	��Top=�6�   $	��123��6�   $��5��6�   ��. $��Visible=�6�   (  "System.Windows.Controls.DatePicker  50   
   -   5        $��DD��50      $
��Left=�6E   $��100,9.8,0,0q�6`   $��4��6u   $	��Top=�6�   $��29��6�   $	��121��6�   	   DisplayDateStart$	 
11.01.2019X�6�   
   DisplayDate
 6   �� *dateDeparture+6�     51   
   -   5        $��DA��51      $��1��6B   $
��Left=�6R   $��58.8,9.8,0,0q�6m   $��4��6�   $	��Top=�6�   $��29��6�   $	��112��6�   $	 
11.02.2019X�6�   
 6   �� *
dateArrive+6�   �� 52   
   -   5        $
��Back��52      $��
Назад��60   $��1��6@   $
��Left=�6P   $��102.8,17.8,0,0q�6k   $��8��6�   $	��Top=�6�   $	��101��6�   $��23��6�   ��53      �� 54      $ 0.5,1&�6&   $ 0.5,0&�67   .��55      � $ 	#FFDEECEC��6#   $ 0Q�65   � 56      $ 	#FFFFC6AC��6#   $ 0.992Q�65   57      59      5:      5;      