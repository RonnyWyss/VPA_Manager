   M S B A M L   `   `   `  ����E  AVerwaltung, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Verwaltung.ViewsVerwaltung.Views  5      !    Verwaltung.Views.TimePicker   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Verwaltung.Views     5      $	��450��5      $	��800��6   .��5	      � $
��Auto��6   $
��Auto��6     � ColumnDefinitions  5
   
   �� 5      $
��0.2* �6   �� 5      $��0.05* �6   �� 5      $
��0.2* �6   �� 5      $��0.05* �6   �� 5      $
��0.2* �6   .+�5   
   � -   5         �Name$
 hour��5      |�. .+�5"      �� -   5         ��Name$ mmTxt��5"      $
��Wrap=�6'    �� TextAlignment$ Center=�5%      $��Center=�6/   $��Goudy Stout)�6J   $��14(�6c   ��5"   ;   ��  �� Path$ Hours� �� ElementName$ UserControl�� �� Mode$ Default=�5%   c   5(      � 5+   
   $��1��6   .+�5.      �� -   5        $
 sep1��5.      $
��Wrap=�6&   $��Center=�6:   $��Goudy Stout)�6k   $��14(�51      $��:��6&   $ Center=�6/   ��5.   U   Z� 51   /   54      � 57   
   -   5        $	 min��57      $��2��6   |�. .+�5:      �� -   5        $ ddTxt��5:      $
��Wrap=�6'   $ Center=�5=      $��Center=�6/   $��Goudy Stout)�6J   $��14(�6c   ��5:   ;   �� $ Minutes�$ UserControl��$ Default=�5=   c   5@      � 5C   
   $��3��6   .+�5F      �� -   5        $
 sep2��5F      $
��Wrap=�6&   $��Center=�6:   $��Goudy Stout)�6k   $��14(�5I      $��:��6&   $ Center=�6/   ��5F   U   Z� 5I   /   5L      � 5O   
   -   5        $	��sec��5O      $��4��6   |�. .+�5R      �� -   5        $ yyTxt��5R      $
��Wrap=�6'   $ Center=�5U      $��Center=�6/   $��Goudy Stout)�6J   $��14(�6c   ��5R   ;   �� $ Seconds�$ UserControl��$ Default=�5U   c   5X      5[      5\      