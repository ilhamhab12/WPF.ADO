   M S B A M L   `   `   `  ����F  BBootcampWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:BootcampWPFBootcampWPF  5   	       BootcampWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:BootcampWPF     5   	   -   5          � Title$  
MainWindow��5   	   $	��496��6   $	��598��6)   .��5
      � .+�5   
   �� -   5         ��Name$ 
tabControl��5      $
��Left=�6)   $	��348��6D   $��	21,23,0,0q�6Q   $	��Top=�6d   $	��543��6|   .@�5      �� $��Manage Supplier��6   .��5      � ���	#FFE5E5E5.+�5      �� -   5         ��Name$ 	NameLable��5      $
��Name��6/   $��2��6>   $
��Left=�6N   $��	10,33,0,0q�6i   $	��Top=�6|   �� 5      -   5         ��Name$ 
SaveButton��5      $
��Save��61   $
��Left=�6@   $��
82,118,0,0q�6[   $	��Top=�6o   $��75��6�   6�   �� 5      -   5         ��Name$ NameTextBox��5      $
��Left=�63   $��23��6~   $��	82,37,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��328��6�   6�   �� 5      -   5        $ LenghtTextBox��5      $
��Left=�65   $��23��6P   $��	82,76,0,0q�6\   $
 Wrap=�6o   $	��Top=�6�   $	��120��6�   6�   �� 5      -   5        $ LenghtLable��5      $��Length��61   $
��Left=�6B   $��	10,73,0,0q�6]   $	��Top=�6p   &   System.Windows.Controls.DataGrid  5      -   5          Name$ SupplierDataGrid��5      $
��Left=�69      
IsReadOnly .    AutoGenerateColumns .  $��
82,167,0,0q�6�   $	��Top=�6�   $	��153��6�   $	��445��6�   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Id��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   ��  �� Path$ Id�6[     5      $

 Name��61    6?   �� $
 Name�6_     5      $
 	Join Date��61    6D   �� $ JoinDate�6h   5      �� 5      -	   5         ��Name$ SupplierComboBox��5      $
��Left=�69    �� DisplayMemberPath$
 Name��6}    �� SelectedValuePath$ Id��6�   $��
290,77,0,0q�6�   $	��Top=�6�   $	��120��6�   ��6T   �� $ getSupplier�6�   �� 5      -
   5        $ SearchComboBox��5      $
��Left=�67   $��191,118,0,0q�6S   $	��Top=�6h   $	��120��6�   .@�5      �� $��Id��6'   $
��Left=�64   $	��118��6O   �� 5      $
��Name��6'   $
��Left=�66   $	��118��6Q   �� 5      $��	Join Date��6'   $
��Left=�6;   $	��118��6V   5      �� 5       -   5        $ SearchTextBox��5       $
��Left=�65   $��23��6P   $��325,117,0,0q�6\   $
 Wrap=�6q   $	��Top=�6�   $	��120��6�   6�   �� 5!      -   5        $ SearchButton��5!      $��Search��63   $
��Left=�6D   $��452,118,0,0q�6_   $	��Top=�6t   $��75��6�   6�   �� 5"      -   5        $ SupplierLabel��5"      $��Supplier��63   $
��Left=�6F   $��
231,73,0,0q�6a   $	��Top=�6u   5#      5$      �� 5%      $��TabItem��6   .��5&      � ���	#FFE5E5E56   5'      5(      5*      5+      