   M S B A M L   `   `   `  ����B  >wpf-all, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:wpf_allwpf_all  5          wpf_all.MainPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:wpf_all     5      .��5	      � 
����ح�.+�5
   
   �� $��	Formularz��6   $��	10,10,0,0q�6&   $
��Left=�69   $	��303��6T   $	��191��6`   $	��Top=�6m   .��5      �   � ColumnDefinitions  5      �� 5      $��3* �6'   �� 5      $	��20* �6'   �� 5      $	��69* �6'   .+�5      �� $
��Name��6   $��11,3,175,139q�6'   $��2��6=   $��1��6Q   �� 5      -   5         ��Name$ 	nameEntry��5   C   $��52,7,18,143q�6    �� TextWrapping$
 Wrap=�6/   $�� ��6V   $��2��6^   	� 5      -   5         	�Name$ 	maleRadio��5   >   $
��Male��6    d� 	IsChecked$
 TrueY�6-    	� 	GroupName$ sexRadioGroup��6Q   $��17,43,180,110q�6k   $��2��6�   $��1��6�   	� 5      -   5        $ femaleRadio��5   I   $��Female��6   $ sexRadioGroup��6/   $��67,43,66,110q�6^   $��2��6t   �� 5      -   5         ��Name$ jobComboBox��5   @   $��50,72,50,74q�6   $��2��60   6@   �� 5      $��
Choose Job��6   $��11,70,175,72q�6-   $��2��6C   $��1��6W   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ 
datePicker��5   C   $��50,108,50,36q�6   $��2��63   6C   �� 5      $��	Join Date��6   $��11,107,175,35q�6,   $��2��6C   $��1��6W   �� 5      -   5         ��Name$ ageLabel��5   )   $��Age: 0��6   $��11,138,175,4q�6;   $��2��6Q   $��1��6e   �� 5      -   5        	 ��Name$	 	ageSlider��5   z   $��2��6   $��18,142,18,8q�6)   
 � Minimum$
 0Q�6>    � Maximum$ 99Q�6J   6z   5      5      �� 5   
   -   5         ��Name$ imageToChange��5   @   $��50,228,444,30q�6   $��/dotnet_bot.png��6'   6@   �� 5   
   -	   5        $�� ��5      $��400,225,52,31q�6   ��5      �� 5        �� ImageSource$ 
/obraz.jpg��6   5"      �� 5#   
   -
   5        $��Details��5#      $��
390,21,0,0q�6#   $��20��6K   $	��Top=�6W   $
��Left=�6o   $	��252��6�   �� 5$   
   -   5         ��Name$ jobListView��5$      $��
390,65,0,0q�6(   $	��110��6<   $	��Top=�6I   $
��Left=�6a   $	��316��6|   5&      5'      