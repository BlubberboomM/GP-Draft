   M S B A M L   `   `   `  ����F  BTest GP App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Test_GP_AppTest_GP_App  5          Test_GP_App.Page2   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Test_GP_App     5        N� Title$  Page2��5      .��5
      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 1Q�6-   � 5      $	 Red��6   $ 0Q�6+   5      .+�5   
   (� $��	-1,-5,0,0q�6   .��5      �� $	��375��6   $	��667��6!   .+�5      � $	��651��6   $	��375��6$   
 �� Top$ 33.167��60    � RowDefinitions 5      �� 5      $��1015* �6(   �� 5      $��0* �6(   �� 5      $
��249* �6(   .+�5      �� $��Center=�6#   $	��523��6@   $��Center=�6M   $	��375��6h    J� IsManipulationEnabled$
 True��6t   .��5      �� -   5         ��Name$
 Menu��5   %   $
��1808��63   $	��365��6A   .+�5      � $	��245��6#   $	��330��60   .+�5   "   �� -   5        	 ��Name$	 Pork_kebabs��5   ,   
���   �$	��330��6P   $	��245��6\   $��0,5,0,-5q�6i   ��5   &   �� 5   *   
 �� ImageSource$
 /Pork Kebabs.png��65   5    #   �� 5!   "   -   5        $	 drop_down_pk��5!   ,   $
��Left=�6B   $��35��6]   $��	278,9,0,0q�6i   
���   �$	��Top=�6�   $��35��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5"   &   V� 5#   *   .~�5$   .   �� �� 5%   .   �� 5&   .    �� Angle$ -90.424Q�6>   T� 5'   .   5(   +   ��5*   &   �� 5+   *   $
 
/image.png��65   5-   #   5.      � 5/      -   5         �Name$ Main_Pork_Kebab��5/   #   $��52��6<   $	��365��6H   .+�50   "   � $��Center=�6'   $��Center=�6D   .+�51   &   �� -   5        $	 Pork_Kebabs1��51   0   $��Center=�6F   $��52��6c   
���   �$	��Top=�6~   $	��365��6�   ���	#FFC4C4C4 �� RadiusX$ 35.33��6�    �� RadiusY$ 43��6�   �� 52   &   -   5         ��Name$ Pork_kebab_price��52   0   $
��Left=�6J   $��44��6e   $��70,8,0,0q�6q   $��$6.99  Pork Kebabs(3): ��6�   $
��Wrap=�6�   $	��Top=�6�   $	��260��6�   $��23(�6�   
���������53   *   �� 54   .    �� Color$ Black��6>    �� Opacity$ 0Q�6L   56   '   57   #   �� 58   "   -   5        $	 minus��58   ,   
�������$��16,21,300,21q�6H   ��59   &   �� 5:   *   $ Black��6:   $ 0Q�6H   5<   #   � 5=   "   -   5        $ plus14��5=   '   $��302,20,14,21q�67   .+�5>   &   �� -	   5        $
	 plus��5>   0   
�������$ 0.5,0.5&�6K   $��0,1,0,0q�6k   ��5?   *   �� 5@   .   $ Black��6>   $ 0Q�6L   z�5B   *   V� 5C   .   .~�5D   2   �� �� 5E   2   �� 5F   2   $ 90.50200000000001Q�6B   T� 5G   2   5H   /   5J   '   �� 5K   &   -
   5        $	 plus1��5K   0   
�������$��0,0,0,1q�6L   ��5L   *   �� 5M   .   $ Black��6>   $ 0.004Q�6L   5O   '   5Q   #   5S      � 5T      $	��245��6#   $	��329��60   .+�5U   "   �� -   5        $	 Chicken_kebabs��5U   ,   
���   �$	��330��6S   $	��245��6_   ��5V   &   �� 5W   *   $
 /Chicken Kebabs.png��65   5Y   #   �� 5Z   "   -   5        $	 drop_down_ck��5Z   ,   $
��Left=�6B   $��35��6]   $��	278,9,0,0q�6i   
���   �$	��Top=�6�   $��35��6�   $ 0.5,0.5&�6�   z�5[   &   V� 5\   *   .~�5]   .   �� �� 5^   .   �� 5_   .   $ -90.424Q�6>   T� 5`   .   5a   +   ��5c   &   �� 5d   *   $
 
/image.png��65   5f   #   5g      � 5h      -   5        $ Main_Chicken_Kebab��5h   #   $��52��6?   $	��365��6K   .+�5i   "   � $��Center=�6'   $��Center=�6D   .+�5j   &   �� -   5        $	 Pork_Kebabs2��5j   0   $��Center=�6F   $��52��6c   
���   �$	��Top=�6~   $	��365��6�   ���	#FFC4C4C4$ 35.33��6�   $ 43��6�   �� 5k   &   -   5        $ Pork_kebab_price1��5k   0   $
��Left=�6K   $��44��6f   $��	71,10,0,0q�6r   $��$6.99 Chicken Kebabs(3): ��6�   $
��Wrap=�6�   $	��Top=�6�   $	��260��6�   $��20(�6�   
���������5l   *   �� 5m   .   $ Black��6>   $ 0Q�6L   5o   '   5p   #   �� 5q   "   -   5        $	 minus1��5q   ,   
�������$��16,21,300,21q�6I   ��5r   &   �� 5s   *   $ Black��6:   $ 0Q�6H   5u   #   � 5v   "   -   5        $ plus15��5v   '   $��302,20,14,21q�67   .+�5w   &   �� -   5        $	 plus16��5w   0   
�������$ 0.5,0.5&�6M   $��0,1,0,0q�6m   ��5x   *   �� 5y   .   $ Black��6>   $ 0Q�6L   z�5{   *   V� 5|   .   .~�5}   2   �� �� 5~   2   �� 5   2   $ 90.50200000000001Q�6B   T� 5�   2   5�   /   5�   '   �� 5�   &   -   5        $	 plus17��5�   0   
�������$��0,0,0,1q�6M   ��5�   *   �� 5�   .   $ Black��6>   $ 0.004Q�6L   5�   '   5�   #   5�      � 5�      $	��245��6#   $	��329��60   .+�5�   "   �� -   5        $	 Sweet_Potato_Fries��5�   ,   
���   �$	��330��6W   $	��245��6c   ��5�   &   �� 5�   *   $
 /Sweet Potato Fries.png��65   5�   #   �� 5�   "   -   5        $	 drop_down_sf��5�   ,   $
��Left=�6B   $��35��6]   $��	278,9,0,0q�6i   
���   �$	��Top=�6�   $��35��6�   $ 0.5,0.5&�6�   z�5�   &   V� 5�   *   .~�5�   .   �� �� 5�   .   �� 5�   .   $ -90.424Q�6>   T� 5�   .   5�   +   ��5�   &   �� 5�   *   $
 
/image.png��65   5�   #   5�      � 5�      -   5        $ Main_Sweet_fries��5�   #   $��52��6=   $	��365��6I   .+�5�   "   � $��Center=�6'   $��Center=�6D   .+�5�   &   �� -   5        $	 Pork_Kebabs3��5�   0   $��Center=�6F   $��52��6c   
���   �$	��Top=�6~   $	��365��6�   ���	#FFC4C4C4$ 35.33��6�   $ 43��6�   �� 5�   &   -   5        $ Pork_kebab_price2��5�   0   $
��Left=�6K   $��44��6f   $��76,8,0,0q�6r   $ ��$5.99 Sweet Potato fries: ��6�   $
��Wrap=�6�   $	��Top=�6�   $	��260��6�   $��20(�6�   
���������5�   *   �� 5�   .   $ Black��6>   $ 0Q�6L   5�   '   5�   #   �� 5�   "   -   5        $	 minus2��5�   ,   
�������$��16,21,300,21q�6I   ��5�   &   �� 5�   *   $ Black��6:   $ 0Q�6H   5�   #   � 5�   "   -   5        $ plus18��5�   '   $��302,20,14,21q�67   .+�5�   &   �� -   5        $	 plus19��5�   0   
�������$ 0.5,0.5&�6M   $��0,1,0,0q�6m   ��5�   *   �� 5�   .   $ Black��6>   $ 0Q�6L   z�5�   *   V� 5�   .   .~�5�   2   �� �� 5�   2   �� 5�   2   $ 90.50200000000001Q�6B   T� 5�   2   5�   /   5�   '   �� 5�   &   -   5        $	 plus20��5�   0   
�������$��0,0,0,1q�6M   ��5�   *   �� 5�   .   $ Black��6>   $ 0.004Q�6L   5�   '   5�   #   5�      � 5�      $	��245��6#   $	��329��60   .+�5�   "   �� -   5        $	 French_Fries��5�   ,   
���   �$	��330��6Q   $	��245��6]   ��5�   &   �� 5�   *   $
 /French Fries.png��65   5�   #   �� 5�   "   -   5        $	 drop_down_ff��5�   ,   $
��Left=�6B   $��35��6]   $��	278,9,0,0q�6i   
���   �$	��Top=�6�   $��35��6�   $ 0.5,0.5&�6�   z�5�   &   V� 5�   *   .~�5�   .   �� �� 5�   .   �� 5�   .   $ -90.424Q�6>   T� 5�   .   5�   +   ��5�   &   �� 5�   *   $
 
/image.png��65   5�   #   5�      � 5�      -   5        $ Main_French_fries��5�   #   $��52��6>   $	��365��6J   .+�5�   "   � $��Center=�6'   $��Center=�6D   .+�5�   &   �� -    5        $	 Pork_Kebabs4��5�   0   $��Center=�6F   $��52��6c   
���   �$	��Top=�6~   $	��365��6�   ���	#FFC4C4C4$ 35.33��6�   $ 43��6�   �� 5�   &   -!   5        $ Pork_kebab_price3��5�   0   $
��Left=�6K   $��44��6f   $��85,8,0,0q�6r   $��$4.99  French fries: ��6�   $
��Wrap=�6�   $	��Top=�6�   $	��260��6�   $��23(�6�   
���������5�   *   �� 5�   .   $ Black��6>   $ 0Q�6L   5�   '   5�   #   �� 5�   "   -"   5        $	 minus3��5�   ,   
�������$��16,21,300,21q�6I   ��5�   &   �� 5�   *   $ Black��6:   $ 0Q�6H   5�   #   � 5�   "   -#   5        $ plus21��5�   '   $��302,20,14,21q�67   .+�5�   &   �� -$   5        $	 plus22��5�   0   
�������$ 0.5,0.5&�6M   $��0,1,0,0q�6m   ��5�   *   �� 5�   .   $ Black��6>   $ 0Q�6L   z�5�   *   V� 5�   .   .~�5�   2   �� �� 5�   2   �� 5�   2   $ 90.50200000000001Q�6B   T� 5�   2   5�   /   5�   '   �� 5�   &   -%   5        $	 plus23��5�   0   
�������$��0,0,0,1q�6M   ��5�   *   �� 5�   .   $ Black��6>   $ 0.004Q�6L   5�   '   5�   #   5�      � 5�      $	��245��6#   $	��329��60   .+�5   "   �� -&   5        $	 	Pork_Ribs��5   ,   
���   �$	��330��6N   $	��245��6Z   ��5  &   �� 5  *   $
 /Pork Ribs.png��65   5  #   �� 5  "   -'   5        $	 drop_down_pr��5  ,   $
��Left=�6B   $��35��6]   $��	278,9,0,0q�6i   
���   �$	��Top=�6�   $��35��6�   $ 0.5,0.5&�6�   z�5  &   V� 5  *   .~�5  .   �� �� 5	  .   �� 5
  .   $ -90.424Q�6>   T� 5  .   5  +   ��5  &   �� 5  *   $
 
/image.png��65   5  #   5     � 5     -(   5        $ Main_Pork_Ribs��5  #   $��52��6;   $	��365��6G   .+�5  "   � $��Center=�6'   $��Center=�6D   .+�5  &   �� -)   5        $	 Pork_Kebabs5��5  0   $��Center=�6F   $��52��6c   
���   �$	��Top=�6~   $	��365��6�   ���	#FFC4C4C4$ 35.33��6�   $ 43��6�   �� 5  &   -*   5        $ Pork_kebab_price4��5  0   $
��Left=�6K   $��44��6f   $��95,8,0,0q�6r   $��$11.99 Pork Ribs: ��6�   $
��Wrap=�6�   $	��Top=�6�   $	��260��6�   $��23(�6�   
���������5  *   �� 5  .   $ Black��6>   $ 0Q�6L   5  '   5  #   �� 5  "   -+   5        $	 minus4��5  ,   
�������$��16,21,300,21q�6I   ��5  &   �� 5  *   $ Black��6:   $ 0Q�6H   5   #   � 5!  "   -,   5        $ plus24��5!  '   $��302,20,14,21q�67   .+�5"  &   �� --   5        $	 plus25��5"  0   
�������$ 0.5,0.5&�6M   $��0,1,0,0q�6m   ��5#  *   �� 5$  .   $ Black��6>   $ 0Q�6L   z�5&  *   V� 5'  .   .~�5(  2   �� �� 5)  2   �� 5*  2   $ 90.50200000000001Q�6B   T� 5+  2   5,  /   5.  '   �� 5/  &   -.   5        $	 plus26��5/  0   
�������$��0,0,0,1q�6M   ��50  *   �� 51  .   $ Black��6>   $ 0.004Q�6L   53  '   55  #   57     � 58     -/   5        $
 Grid��58  #   $	��245��61   $	��329��6>   .+�59  "   �� -0   5        $	 Onion_Rings��59  ,   
���   �$	��330��6P   $	��245��6\   ��5:  &   �� 5;  *   $
 /Onion Rings.png��65   5=  #   �� 5>  "   -1   5        $	 drop_down_or��5>  ,   $
��Left=�6B   $��35��6]   $��	278,9,0,0q�6i   
���   �$	��Top=�6�   $��35��6�   $ 0.5,0.5&�6�   z�5?  &   V� 5@  *   .~�5A  .   �� �� 5B  .   �� 5C  .   $ -90.424Q�6>   T� 5D  .   5E  +   ��5G  &   �� 5H  *   $
 
/image.png��65   5J  #   5K     � 5L     -2   5        $ Main_Onion_rings��5L  #   $��52��6=   $	��365��6I   .+�5M  "   � $��Center=�6'   $��Center=�6D   .+�5N  &   �� -3   5        $	 Pork_Kebabs7��5N  0   $��Center=�6F   $��52��6c   
���   �$	��Top=�6~   $	��365��6�   ���	#FFC4C4C4$ 35.33��6�   $ 43��6�   �� 5O  &   -4   5        $ Pork_kebab_price5��5O  0   $
��Left=�6K   $��44��6f   $��95,8,0,0q�6r   $��$6.99 Onion rings: ��6�   $
��Wrap=�6�   $	��Top=�6�   $	��260��6�   $��23(�6�   
���������5P  *   �� 5Q  .   $ Black��6>   $ 0Q�6L   5S  '   5T  #   �� 5U  "   -5   5        $	 minus5��5U  ,   
�������$��16,21,300,21q�6I   ��5V  &   �� 5W  *   $ Black��6:   $ 0Q�6H   5Y  #   � 5Z  "   -6   5        $ plus27��5Z  '   $��302,20,14,21q�67   .+�5[  &   �� -7   5        $	 plus28��5[  0   
�������$ 0.5,0.5&�6M   $��0,1,0,0q�6m   ��5\  *   �� 5]  .   $ Black��6>   $ 0Q�6L   z�5_  *   V� 5`  .   .~�5a  2   �� �� 5b  2   �� 5c  2   $ 90.50200000000001Q�6B   T� 5d  2   5e  /   5g  '   �� 5h  &   -8   5        $	 plus29��5h  0   
�������$��0,0,0,1q�6M   ��5i  *   �� 5j  .   $ Black��6>   $ 0.004Q�6L   5l  '   5n  #   5p     5q     5r     �� 5s     -9   5        
���   ����	#FFBA0000$ 35.333��5s  @   $ 35.333��6Q   $��14,25,10,37q�6�   $��2��6�    J� Effect 5t     3  -System.Windows.Media.Effects.DropShadowEffect  5u     5w     �� 5x     -:   5        $��Center=�5x      $��49��6=   $��2��6I   $
��Wrap=�6V   $	��Top=�6j   $	��142��6�   $��24(�6�   
�������$��0,38,0,0q�6�   �� 6�   $�Review Order��6�   �� 6  �� 6  6  5z     �� 5{     
���   ����	#FFC4C4C4$��37��6<   $	��375��6H   �� 5|     $
��Wrap=�6    �� TextAlignment$
 Left=�60   $��24(�6E   $��32��6S    �� Left$ 47��6_   $ 5��6p   $��97��6   �� 6�   $
�Menu��6�   �� 6�   �� 6�   6�   A� 5}     
���   �$��37��6)   $��39��65   ��5~     �� 5     $
 /Smokies.png��6%    �� RelativeTransform 5�     V� 5�  "   .~�5�  &   ��  �� CenterY$	 0.5Q�65    �� CenterX$	 0.5Q�6C    �� ScaleX$	 1.2Q�6Q    �� ScaleY$	 1.2Q�6^   �� 5�  &    �� CenterY$	 0.5Q�64    �� CenterX$	 0.5Q�6B   �� 5�  &    �� CenterY$	 0.5Q�66    �� CenterX$	 0.5Q�6D   T� 5�  &    T� X$ 0Q�69     T� Y$  0Q�6?   5�  #   5�     5�     5�     5�     5�     5�     