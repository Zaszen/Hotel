   M S B A M L   `   `   `  ����C  ?AppHotel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:AppHotelAppHotel  5   	   7 clr-namespace:AppHotel.ViewModelAppHotel.ViewModel  5   	       AppHotel.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:AppHotel     5   	   3local1 clr-namespace:AppHotel.ViewModel     5   	     � Title$  
MainWindow��5	   	   $��605.52��6   $��1105.342��6,    � DataContext 5
      1   +AppHotel.ViewModel.ViewModelCollectionPiece  5   
   6,   .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6"   �� 5      $��5 �6   6+   �� 5      6!   �� 5      6!   �� 5       6!   .+�5"   
   �� -   5         ��Name$ 
listePiece��5"   "   $��4��6   $
��Left=�66   $	��566��6Q   $��6��6^   $	��Top=�6o   $	��537��6�   $��3��6�   $��0,2,0,0q�6�   ��6�   �� *Hotel+ �� SelectedItem 6�   ��  �� Path$ SelectedItem���5$      �� 5%      .R�5&      ��  �� Orientation$ 
Horizontal=�6!   .+�5'      �� $��-��6    6.   �� 5(      $��Superficie:��6    68   �� 5)      ��6    �� *
Superficie+6A   �� 5*      $��m², Capacité:��6    6:   �� 5+      ��6    �� *
Capacite+6?   �� 5,      $��place(s), Prix: ��6    6=   �� 5-      ��6    �� *PrixJournalier+6E   �� 5.      $��€, Climatisation: ��6    6?   �� 5/      ��6    �� *TxtClimatisation+6G   50      51      53      �� 54   
   $��Superficie: ��6   $��0��6'   $��1��67   $��
100,33,0,0q�6D   6Z   �� 55   
   -   5         ��Name$ txtboxSuperficie��55   .   $
��Left=�6   $��23��6H   $��28.6,36,0,0q�6T   	 �� TextWrapping$
	 Wrap=�6i   $	��Top=�6�   $	��120��6�   $��1��6�   $��1��6�   ��6}   �� *TempPiece.Superficie+
 �� Mode$
 TwoWay=�6�   �� 56   
   $��Capacité: ��6   $��0��6%   $��2��65   $��
100,33,0,0q�6B   6X   �� 57   
   -   5        $ txtboxCapacite��57   -   $
��Left=�6   $��23��6E   $��28.6,36,0,0q�6Q   $
	 Wrap=�6f   $	��Top=�6�   $	��120��6�   $��1��6�   $��2��6�   ��6z   �� *TempPiece.Capacite+$
 TwoWay=�6�   �� 58   
   $��Prix: ��6   $��0��6!   $��3��61   $��
100,33,0,0q�6>   6T   �� 59   
   -   5        $ 
txtBoxPrix��59   -   $
��Left=�6   $��23��6A   $��28.6,36,0,0q�6M   $
	 Wrap=�6b   $	��Top=�6�   $	��120��6�   $��1��6�   $��3��6�   ��6v   �� *TempPiece.PrixJournalier+$
 TwoWay=�6�   �� 5:   
   $��Climatisation: ��6   $��0��6*   $��4��6:   $��
100,24,0,0q�6G   6]   �� 5;   
   -   5         ��Name$ chkboxClimatisation��5;      $�� ��6   $��1��6w   $
��Left=�6�   $��28.6,30,0,0q�6�   $��4��6�   $	��Top=�6�    d� 	IsChecked 6<   �� *TempPiece.Climatisation+$
 TwoWay=�6�   �� 5<   
   $��Ajouter��6   $��2��6C   $
��Left=�6S   $��45.2,50,0,0q�6n   $��5��6�   $	��Top=�6�   $��75��6�   ��6#   �� *
AjoutPiece+6�   �� 5=   
   $��	Supprimer��6   $��1��6%   $
��Left=�65   $��70.6,50,0,0q�6�   $��5��6�   $	��Top=�6�   $��75��6�   ��6P   �� *SuprimmerPiece+��6s   ��  �� ElementName$ 
listePiece��$ SelectedItem�6�   �� 5>   
   $��Editer��6   $��0��6"   $
��Left=�62   $��70.6,50,0,0q�6�   $��5��6�   $	��Top=�6�   $��75��6�   ��6M   �� *EditerPiece+��6m   �� $ 
listePiece��$ SelectedItem�6�   5?      5@      