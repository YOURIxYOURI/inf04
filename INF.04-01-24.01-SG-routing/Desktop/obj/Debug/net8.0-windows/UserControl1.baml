   M S B A M L   `   `   `  ����B  >Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:DesktopDesktop  5          Desktop.UserControl1   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Desktop     5      .��5	      � .+�5
   
   �� $��Numer��6   $
��Left=�6    $��	43,39,0,0q�6;   $	��Top=�6N   $��77��6f   �� 5   
   $��Imię��6   $
��Left=�6   $��	43,70,0,0q�6:   $	��Top=�6M   $��77��6e   �� 5   
   $��Nazwisko��6   $
��Left=�6#   $��
43,101,0,0q�6>   $	��Top=�6R   $��77��6j   �� 5   
   -   5          ��Name$  numberEntry��5   %   
�������$
��Left=�6;   $��
111,43,0,0q�6V    �� TextWrapping$
 Wrap=�6j   $�� ��6~   $	��Top=�6�   $	��196��6�   6�   �� 5   
   -   5        $  firstNameEntry��5   %   
�������$
��Left=�6=   $��
111,74,0,0q�6X   $
 Wrap=�6l   $�� ��6�   $	��Top=�6�   $	��196��6�   �� 5   
   -   5        $  lastNameEntry��5   %   
�������$
��Left=�6<   $��111,105,0,0q�6W   $
 Wrap=�6l   $�� ��6�   $	��Top=�6�   $	��196��6�   �� 5   
   $��
Kolor Oczu��6   $��	31,0,0,41q�6'   $
��Left=�6:   $	��334��6U   $	��140��6a   $��Bottom=�6n   .��5      � $
��Left=�6   $	��322��6.    � ColumnDefinitions 5      �� 5      $
��145* �6'   �� 5      $
��178* �6'   .+�5      	� -   5         	�Name$ blueCheckbox��5   /    d� 	IsChecked$
 TrueY�6   $��
Niebieskie��6E    	� 	GroupName$ 	eyesColor��6Z   $��
10,10,3,91q�6p   $��16��6�   	� 5      -   5        $ greenCheckbox��5      $��Zielone��65   $ 	eyesColor��6G   $��
10,38,3,63q�6]   $��16��6q   	� 5      -   5        $ beerCheckbox��5      $��Piwne��64   $ 	eyesColor��6D   $��
10,67,3,34q�6Z   $��16��6n   5      5      �� 5   
   -   5         ��Name$ personImage��5   +   $
��Left=�6   $	��186��6@   $��
414,43,0,0q�6M   $	��Top=�6a   $	��157��6y   $��/000-zdjecie.jpg��6�   �� 5   
   -   5        $ 
printImage��5   +   $
��Left=�6   $	��180��6?   $��
614,43,0,0q�6L   $	��Top=�6`   $	��144��6x   $��/000-odcisk.jpg��6�   �� 5   
   -	   5        
�������$��OK��5   $   $
��Left=�61   $��414,248,0,0q�6L   $	��Top=�6a   $	��157��6y   $��36��6�   6�   �� 5   
   -
   5        
�������$��OK��5   $   $
��Left=�61   $��596,248,0,0q�6L   $	��Top=�6a   $	��156��6y   $��36��6�   6�   5      5       