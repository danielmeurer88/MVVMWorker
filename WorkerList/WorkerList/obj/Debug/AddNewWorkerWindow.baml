   M S B A M L   `   `   `  ����E  AWorkerList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WorkerList
WorkerList  5   	   #    WorkerList.AddNewWorkerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WorkerList     5   	     � Title$  Arbeiter hinzufügen��5   	   $	��300��6%   $	��300��62    � WindowStartupLocation$ CenterScreen=�6>      addWorkerViewModel � DataContext# [  5	   	    � Closed 5
   	      WorkerList.CallMethod  *&$MarkupEx_OnClosingWindowAddNewWorker+.��5      � -   5         �Name$ FormGrid��5       � 	Resources 5   
    �� 
TargetType �� Property �� Value��%�  '��       '�� �     �� 5      " ��6   .�5      ��  � ��$ Center=�66   �� 5       � ��$
 Left=�68   �� 5       � ��$ 12 0 0 0q�6+   �� 5       � ��$ 16(�6-   5      �� 5      " ��6   .�5      ��  � ��$ Center=�66   �� 5       � ��$
 Left=�68   �� 5       � ��$ 12 0 0 0q�6+   �� 5       � ��$ 16(�6-   �� 5       � ��$	 120��6*   5      5      	 � RowDefinitions	 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       �� 5!      
 � ColumnDefinitions
 5#   
   �� 5$      �� 5%      .+�5(   
   �� $��0��6   $��0��6!   $��Vorname:��61   �� 5)   
   $��1��6   $��0��6!   $��	Nachname:��61   �� 5*   
   $��2��6   $��0��6!   $��Alter:��61   �� 5+   
   $��3��6   $��0��6!   $��Erfahrung (Jahre):��61   �� 5,   
   $��4��6   $��0��6!   $��
Abschluss:��61   �� 50   
   $��0��6   $��1��6   .��6/   ��51      �� 52       �� Path$ NewSurename�6    �� UpdateSourceTrigger$ PropertyChanged=�6-    �� ValidationRules 53      '   !WorkerList.NoEmptyStringValidator  54      56      .��57      58      �� 59   
   $��1��6   $��1��6   .��6/   ��5:      �� 5;      $ NewLastname�6   $ PropertyChanged=�6-    5<        5=      5?      .��5@      5A      �� 5B   
   $��2��6   $��1��6   .��6/   ��5C      �� 5D      $ NewAge�6   $ PropertyChanged=�6(    5E        5F      .   (WorkerList.StringPositiveNumberValidator  5G      5I      .��5J      5K      �� 5L   
   $��3��6   $��1��6   .��6/   ��5M      �� 5N      $ NewYearsOfExperience�6   $ PropertyChanged=�66    5O        5P        5Q      5S      .��5T      5U      �� 5W   
   $��4��6   $��1��6     �� SelectedIndex$ 0��60   $��10 12 10 12q�6B    �� SelectionChanged 6W     *MarkupEx_DegreeChanged+.@�5X      �� $��keinen��6   $ 0��6,   �� 5Y      $��Bachlor��6   $ 1��6-   �� 5Z      $��Master��6   $ 2��6,   �� 5[      $��Doktor��6   $ 3��6,   5\      �� 5^   
   $��5��6   $��1��6   $��	Erstellen��6.   $��8q�6B   ��6M   �� *AddWorkerCommand+��6r   ��  �� ElementName$ FormGrid���� 5`   
   $��5��6   $��0��6   $��Leeren��6.   $��8q�6?    �� Click 6J     *MarkupEx_Empty+5b      5c      