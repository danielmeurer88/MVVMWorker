   M S B A M L   `   `   `  ����E  AWorkerList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WorkerList
WorkerList  5   	       WorkerList.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WorkerList     5   	     � Title$  Arbeiter��5   	   $	��370��6   $	��525��6'    � WindowStartupLocation$ CenterScreen=�63    � 	Resources 5
      (  "WorkerList.DegreeToStringConverter   degreeToStringConverter��%   &	          5   
   6(   5      .��5      ��   workerViewModel � DataContext# [ 6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ 
workerList��5   (    �� SelectedIndex$ 0��6   $	��300��6\   $	��250��6h   $	��Top=�6u   $
��Left=�6�   $��8q�6�   ��6<   �� *	Workers+��5      �� 5      .R�5      �� .+�5      �� $ 
Horizontal=�6%   .+�5      �� ��6(   �� *
Surename+6D   �� 5      $��8 0 0 0q�6(   ��69   �� *
Lastname+6U   5      �� 5      $ 
Horizontal=�6%   .+�5      �� $��Alter:��6(   68   �� 5      $��8 0 0 0q�6(   ��69   �� *Age+6P   �� 5      $��5 0 5 0q�6(   $��2��69   $��14��6C   
�������6O   �� 5      $��
Erfahrung:��6(   6<   �� 5      $��8 0 0 0q�6(   ��69   �� *YearsOfExperience+6^   �� 5       $��5 0 5 0q�6(   $��2��69   $��14��6C   
�������6O   �� 5"      $��
Abschluss:��6(   6<   �� 5#      $��8 0 0 0q�6(   ��69   �� *Degree+ �� 	Converter# [  6�   5%      5&      5'      5*      �� 5+      -   5         ��Name$ 
SaveButton��5+      $��Save (test)��6)   $	��150��6?   $��60��6K   	 �� Click	 6W      WorkerList.CallMethod  *MarkupEx_Save+5,      �� 5-   
   $��5q�6   $#��Selektierter Eintrag löschen��6   ��6C   �� 
 �� ElementName$
 
workerList����6w   �� *DeleteCommand+�� 5.   
   $��5q�6   $��Eintrag hinzufügen��6   	 69     *!MarkupEx_OpenWindowAddNewWorker+5/      50      