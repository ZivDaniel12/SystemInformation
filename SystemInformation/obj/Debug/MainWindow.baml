   M S B A M L   `   `   `  ����=  9SI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SystemInformationSystemInformation  5   	   +clr-namespace:SI.ViewModelSI.ViewModel  5   	       SI.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:SystemInformation     5   	   0	ViewModelclr-namespace:SI.ViewModel     5   	     � Title$  
MainWindow��5	   	   $��371.473��6   $��386.97��6-    � DataContext 5
          SI.ViewModel.MainViewModel  5   
   .��5      � $	��520��6   $��Bottom=�6   $��Right=�63   $	��379��6O   $��
0,0,0,-180q�6[    � RowDefinitions 5   
   �� 5      $	��40* �6   �� 5      $	��25* �6   �� 5      $	��23* �6   .+�5   
   �� -   5         ��Name$ 
btnRefresh��5      $��Refresh��6%   $
��Left=�67   $��284,105,0,0q�6R   $	��Top=�6g   $��75��6   $��20��6�   �� 5   
   -   5         ��Name$ txtUpdateStatus��5      $
��Left=�6-   $��	15,10,0,0q�6H   $
��Wrap=�6[   $	��Top=�6o   $	��344��6�   �� 5   
   -   5        $ txtblockCPU��5      $
��Left=�6)   $��
157,48,0,0q�6D   $
��Wrap=�6X   $	��Top=�6�   $��21��6�   $	��158��6�   ��6l   �� *CPU+ �� Mode$ OneWay=�6�   �� 5   
   -   5         ��Name$ lblCPU��5      $
��Left=�6J   $��	13,43,0,0q�6e   $	��Top=�6x   $	��139��6�   $��26��6�   ��6    �� *
CPULabel+$ OneWay=�6�   �� 5   
   -   5        $ txtblockMemoryCommitted��5      $
��Left=�65   $��222,79,-1,0q�6P   $
��Wrap=�6e   $	��Top=�6�   $��21��6�   $	��158��6�   ��6y   �� *MemoryCommitted+$ OneWay=�6�   �� 5   
   -   5        $ lblMemoryCommitted��5      $
��Left=�6c   $��	13,74,0,0q�6~   $	��Top=�6�   $	��218��6�   $��26��6�   ��6,   �� *MemoryCommittedLabel+$ OneWay=�6�   �� 5   
   -   5        $ lblNumberOfProcess��5      $��13,100,276,109q�6a   ��6,   �� *ProccessNumberLabel+$ OneWay=�6a   �� 5   
   -   5        $ txtNumberOfProccess��5      $��100,105,227,109q�6^   ��61   �� *ProccessNumber+$ OneWay=�6^   �� 5!   
   $��Enter URL address��6   $
��Left=�6,   $��	9,166,0,0q�6G   $	��Top=�6Z   $��26��6r   $	��106��6~   �� 5"   
   -	   5         ��Name$ 	txtboxURL��5"      $
��Left=�6%   $��22��6@   $��
13,189,0,0q�6L    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��346��6�   �� 5#   
   -
   5        $ btn_CheckURLValid��5#      	 � Cursor$
	 Hand��6,   $��	Check url��6:   $
��Left=�6N   $��287,213,0,0q�6i   $	��Top=�6~   $��72��6�   4  .System.Windows.Automation.AutomationProperties
   HelpText$
 Check if the URL is valid��6�   $��20��6�   ��5$      �� 5%       �� 
TargetType" ��6   .�5&      ��  �� Property � {� �� Value . 62    �� Triggers 5'      �� 5(       �� Binding 6&   �� *Text+ �� ElementName$ 	txtboxURL�� �� Value  6V   .a�5)      ��  � {� .  6:   5*      5,      5.      �� 5/   
   -   5        $ txtblckIsURLValid��5/      $
��Left=�6/   $��
15,213,0,0q�6J   $
��Wrap=�6^   $	��Top=�6r   $	��266��6�   $��20��6�   �� 52   
   $��
Enter path��6   $
��Left=�6%   $��12,5,0,0q�6@   $	��Top=�6R   $��31��6j   $��65��6v   $��1��6�   �� 53   
   -   5        $ txtboxDicPath��53      $��22��6)   $��	13,27,0,0q�65   $
 Wrap=�6J   $�� ��6^   $	��Top=�6f   $
��Left=�6~   $	��346��6�   $��1��6�   �� 54   
   -   5        $ btn_CheckPathExists��54      $��
Check path��6/   $
��Left=�6D   $��
287,52,0,0q�6_   $	��Top=�6s   $��72��6�   $!
 Check if the Path is exists��6�   $��20��6�   $��1��6�   ��55      �� 56      " ��6   .�57      ��  � {� . 62    58      �� 59       6&   �� *Text+$ txtboxDicPath��  6Z   .a�5:      ��  � {� .  6:   5;      5=      5?      �� 5@   
   -   5        $ txtblckIsPathExits��5@      $��
13,51,97,0q�60   $
��Wrap=�6D   $	��Top=�6X   $��20��6p   $��1��6|   5B      5C      